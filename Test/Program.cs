using Tera.Core.Cryptography;
using Tera.Core.Network;
using Tera.Core.Network.OpCodes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Test.Internals;
using Tera.Core.Network.Protocol.Packets;
using Tera.Core.Plugins;
using Tera.Core.Game;

namespace Test
{
    class Program
    {
        #region Fields
        private static GameClient _client;
        private static Stopwatch sw = new Stopwatch();
        private static int _totalPackets = 0;
        #endregion
        #region EntryPoint
        static void Main(string[] args)
        {
            Test();
            TeraEncryptionKeys keys = new TeraEncryptionKeys(PacketReceiver.ClientKey1, PacketReceiver.ClientKey2, PacketReceiver.ServerKey1, PacketReceiver.ServerKey2);
            MessageTables tables = new MessageTables(DicFromPath(@"D:\gMessages.txt"), DicFromPath(@"D:\sMessages.txt"));
            _client = new GameClient(keys, tables);
            PluginLoader pLoader = new PluginLoader("Plugins");
            pLoader.Start(_client);
            PacketReceiver.PacketReceived += PacketReceiver_PacketReceived;
            PacketReceiver.Start();
            Console.ReadKey(true);
        }
        #endregion
        #region [PRIVATE]Handlers
        private static bool Handle_CChat(GameClient client, PacketDirection direction, C_CHAT packet)
        {
            packet.Message = "<FONT>Hello, World*</FONT>";
            return true;
        }
        private static void PacketReceiver_PacketReceived(EncryptedPacket packet)
        {
            _totalPackets++;
            byte[] data = _client.ProcessData(packet.Data, packet.Direction);
        }
        #endregion
        #region [PRIVATE]Methods
        private static void Test()
        {
            Type type = typeof(ChatChannel);
            string[] names = type.GetEnumNames();
            Array values = type.GetEnumValues();
            int length = names.Length;
            for (int i = 0; i < length; i++) Console.WriteLine($"{names[i]}: {((uint)values.GetValue(i)).ToString()}");
            string s = type.Name;
            Console.WriteLine();
        }
        private static Dictionary<ushort, string> DicFromPath(string path)
        {
            Dictionary<ushort, string> dic = new Dictionary<ushort, string>();

            string[] rows = File.ReadAllText(path).Split(new[] { "\r\n" }, StringSplitOptions.None);
            foreach (string row in rows)
            {
                string[] parts = row.Split(new[] { "\t\t" }, StringSplitOptions.None);
                dic.Add(ushort.Parse(parts[0]), parts[1]);
            }
            return dic;
        }
        #endregion
    }
}