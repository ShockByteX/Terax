using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using Tera.Core.Cryptography;
using Tera.Core.Internals;
using Tera.Core.Network.OpCodes;
using Tera.Core.Network.Protocol;
using Tera.Core.Network.Protocol.Packets;

namespace Tera.Core.Network
{
    public class GameClient
    {
        #region Constants
        public static readonly byte[] C_SIGNATURE = new byte[] { 0xFF, 0xFF, 0xFF, 0xFF };
        #endregion
        #region [PUBLIC]Fields
        public readonly PacketProcessor Processor;
        public RawPacket CPacket = null;
        #endregion
        #region Fields
        private TeraEncryptionSession _tesClient, _tesServer;
        private PacketBuffer _bufClient = new PacketBuffer(PacketDirection.ClientToServer), _bufServer = new PacketBuffer(PacketDirection.ServerToClient);
        #endregion
        #region Constructors
        public GameClient(TeraEncryptionKeys keys, MessageTables tables)
        {
            if (keys == null) throw new ArgumentNullException(nameof(keys));
            _tesClient = new TeraEncryptionSession(PacketDirection.ServerToClient, keys);
            _tesServer = new TeraEncryptionSession(PacketDirection.ClientToServer, keys);
            Processor = new PacketProcessor(new PacketSerializer(tables));
        }
        #endregion
        #region [PUBLIC]Methods
        public byte[] ProcessData(byte[] data, PacketDirection direction)
        {
            PacketBuffer buffer;
            TeraEncryptionSession tesFrom, tesTo;
            switch (direction)
            {
                case PacketDirection.ClientToServer: buffer = _bufClient; tesFrom = _tesClient; tesTo = _tesServer; break;
                case PacketDirection.ServerToClient: buffer = _bufServer; tesFrom = _tesServer; tesTo = _tesClient; break;
                default: throw new Exception();
            }
            tesFrom.Decrypt(data, 0, data.Length);
            buffer.WriteData(data);
            RawPacket packet;
            bool c = false;
            while ((packet = buffer.ReadPacket()) != null)
            {
                if (packet.OpCode == 39820 && CPacket != null) { packet = CPacket; c = true; CPacket = null; }
                if (Processor.Process(this, ref packet)) buffer.WritePacket(packet);
                PacketReceived?.Invoke(packet);
            }
            byte[] encrypted = buffer.ReadData();
            tesTo.Encrypt(encrypted, 0, encrypted.Length);
            if (c)
            {
                byte[] cEnc = new byte[encrypted.Length + 4];
                cEnc[0] = C_SIGNATURE[0]; cEnc[1] = C_SIGNATURE[1]; cEnc[2] = C_SIGNATURE[2]; cEnc[3] = C_SIGNATURE[3];
                Array.Copy(encrypted, 0, cEnc, 4, encrypted.Length);
                return cEnc;
            }
            else return encrypted;
        }
        public byte[] Encrypt(RawPacket packet)
        {
            TeraEncryptionSession tes;
            switch (packet.Direction)
            {
                case PacketDirection.ClientToServer: tes = _tesServer; break;
                case PacketDirection.ServerToClient: tes = _tesClient; break;
                default: throw new Exception();
            }
            byte[] encrypted = packet.Data.ToArray();
            tes.Encrypt(encrypted, 0, encrypted.Length);
            return encrypted;
        }
        public byte[] Decrypt(byte[] data, PacketDirection direction)
        {
            TeraEncryptionSession tes;
            switch (direction)
            {
                case PacketDirection.ClientToServer: tes = _tesClient; break;
                case PacketDirection.ServerToClient: tes = _tesServer; break;
                default: throw new Exception();
            }
            byte[] decrypted = data.ToArray();
            tes.Decrypt(decrypted, 0, decrypted.Length);
            return decrypted;
        }
        #endregion
        #region Events
        public Action<RawPacket> PacketReceived;
        #endregion
    }
}