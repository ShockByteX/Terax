using System;
using System.Collections.Generic;
using System.Linq;

namespace Tera.Core.Network.Protocol
{
    public class PacketProcessor
    {
        #region [PUBLIC]Fields
        public readonly PacketSerializer Serializer;
        #endregion
        #region [PRIVATE]Fields
        private readonly Dictionary<ushort, HashSet<Delegate>> _handlers = new Dictionary<ushort, HashSet<Delegate>>();
        private readonly IReadOnlyCollection<Delegate> _emptyHandlers = new List<Delegate>();
        private readonly Dictionary<ushort, HashSet<RawPacketHandler>> _rawHandlers = new Dictionary<ushort, HashSet<RawPacketHandler>>();
        private object _lockList = new object();
        private object _lockInvoke = new object();
        #endregion
        #region Constructors
        public PacketProcessor(PacketSerializer serializer)
        {
            Serializer = serializer ?? throw new ArgumentNullException(nameof(serializer));
            foreach (ushort opCode in Serializer.Tables.Game.OpCodeToName.Keys)
            {
                _rawHandlers.Add(opCode, new HashSet<RawPacketHandler>());
                _handlers.Add(opCode, new HashSet<Delegate>());
            }
        }
        #endregion
        #region [PUBLIC]Operations
        public void AddHandler<T>(PacketHandler<T> handler) where T : Packet
        {
            if (handler == null) throw new ArgumentNullException(nameof(handler));
            lock (_lockList) _handlers[Serializer.Tables.Game.NameToOpCode[typeof(T).Name]].Add(handler);
        }
        public void RemoveHandler<T>(PacketHandler<T> handler) where T : Packet
        {
            if (handler == null) throw new ArgumentNullException(nameof(handler));
            lock (_lockList) _handlers[Serializer.Tables.Game.NameToOpCode[typeof(T).Name]].Remove(handler);
        }
        #endregion
        #region [PUBLIC]Methods
        public bool Process(GameClient client, ref RawPacket packet)
        {
            IReadOnlyCollection<Delegate> handlers = _handlers[packet.OpCode];
            lock (_lockList) handlers = handlers.Count != 0 ? handlers.ToArray() : _emptyHandlers;
            bool send = true;
            try
            {
                Packet sPacket = Serializer.Deserialize(packet);
                foreach (Delegate handler in handlers)
                {
                    lock (_lockInvoke) send &= (bool)handler.DynamicInvoke(client, packet.Direction, sPacket);
                    packet = Serializer.Serialize(sPacket);
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            return send;
        }
        #endregion
    }
}