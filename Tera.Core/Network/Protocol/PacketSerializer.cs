using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Tera.Core.Helpers;
using Tera.Core.Internals;
using Tera.Core.IO;
using Tera.Core.Network.OpCodes;

namespace Tera.Core.Network.Protocol
{
    public class PacketSerializer
    {
        #region Constants
        private const string PACKETS_CONTRACT = "Tera.Core.Network.Protocol.Packets";
        #endregion
        #region [PUBLIC]Fields
        public MessageTables Tables;
        #endregion
        #region [PRIVATE]Fields
        private Dictionary<string, PacketReflectionInfo> _info = new Dictionary<string, PacketReflectionInfo>();
        #endregion
        #region Properties
        public IReadOnlyDictionary<string, PacketReflectionInfo> Info => _info;
        #endregion
        #region Constructors
        public PacketSerializer(MessageTables tables)
        {
            Tables = tables ?? throw new ArgumentNullException(nameof(tables));
            Type[] types = AssemblyHelper.GetTypes(PACKETS_CONTRACT);
            foreach (Type type in types)
            {
                FieldInfo[] fields = type.GetFields();
                _info.Add(type.Name, new PacketReflectionInfo(type, fields.Take(0, fields.Length - 1)));
            }
        }
        #endregion
        #region [PUBLIC]Methods
        public Packet Deserialize(RawPacket packet)
        {
            PacketReflectionInfo info;
            if (!_info.TryGetValue(Tables.Game.OpCodeToName[packet.OpCode], out info)) return null;
            object obj = Activator.CreateInstance(info.Type);
            using (TeraBinaryReader reader = new TeraBinaryReader(packet.GetPayloadData()))
            {
                foreach (FieldInfo field in info.Fields) field.SetValue(obj, reader.Read(field.FieldType));
            }
            return (Packet)obj;
        }
        public RawPacket Serialize(Packet packet)
        {
            PacketReflectionInfo info;
            if (!_info.TryGetValue(packet.OpCode, out info)) return null;
            byte[] data;
            using (TeraBinaryWriter writer = new TeraBinaryWriter())
            {
                writer.Position = 2;
                writer.Write(Tables.Game.NameToOpCode[packet.OpCode]);
                foreach (FieldInfo field in info.Fields) writer.Write(field.FieldType, field.GetValue(packet));
                writer.Position = 0;
                writer.Write((ushort)writer.Length);
                data = new byte[writer.Length];
                writer.Position = 0;
                ((MemoryStream)writer.Stream).Read(data, 0, writer.Length);
            }
            return new RawPacket(data, packet.OpCode[0] == 'C' ? PacketDirection.ClientToServer : PacketDirection.ServerToClient);
        }
        #endregion
    }
}