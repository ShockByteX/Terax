using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Tera.Core.Network.OpCodes;
using TeraxHook.Memory;

namespace TeraxHook
{
    public static class Globals
    {
        #region Delegates
        private delegate IntPtr GetMessageNameFunc(int opCode);
        #endregion
        #region Fields
        private static uint _clientVersion1, _clientVersion2;
        private static MessageTables _tables;
        #endregion
        #region Properties
        public static uint ClientVersion1 => _clientVersion1;
        public static uint ClientVersion2 => _clientVersion2;
        public static MessageTables Tables => _tables;
        #endregion
        #region [PUBLIC]Methods
        public static void RefreshData()
        {
            using (ModuleSnapshot snapshot = new ModuleSnapshot(Process.GetCurrentProcess().MainModule))
            {
                _clientVersion1 = GetVersion(snapshot, "8B 55 EC 8B 35 ? ? ? ?", 5);
                _clientVersion2 = GetVersion(snapshot, "66 83 02 0C 8B 3D ? ? ? ?", 6);
                _tables = new MessageTables(GetGameMessages(snapshot, "55 8B EC 8B 45 08 0F B7 C0 3D 88 13 00 00"), GetSystemMessages(snapshot, "55 8B EC 8B 45 08 85 C0 78 10 3D ? ? ? ?", 11));
                //Analog to GetGameMessages: 55 8B EC 0F B7 45 08 3D 88 13 00 00
            }
        }
        #endregion
        #region [PRIVATE]Methods
        private static uint GetVersion(ModuleSnapshot snapshot, string pattern, int patternOffset) => LocalMemory.Read<uint>((IntPtr)snapshot.FindPattern(pattern, patternOffset, 0, true, false));
        private static Dictionary<ushort, string> GetGameMessages(ModuleSnapshot snapshot, string pattern)
        {
            Dictionary<ushort, string> result = new Dictionary<ushort, string>();
            GetMessageNameFunc func = new IntPtr(snapshot.FindPattern(pattern, 0, 0, false, false)).ToDelegate<GetMessageNameFunc>();
            for (ushort i = 0; i < ushort.MaxValue; i++)
            {
                string opCodeName;
                if ((opCodeName = Marshal.PtrToStringAnsi(func(i))) != string.Empty) result.Add(i, opCodeName);
            }
            return result;
        }
        private static Dictionary<ushort, string> GetSystemMessages(ModuleSnapshot snapshot, string pattern, int patternOffset)
        {
            Dictionary<ushort, string> result = new Dictionary<ushort, string>();
            IntPtr funcAddress = new IntPtr(snapshot.FindPattern(pattern, 0, 0, false, false));
            GetMessageNameFunc func = funcAddress.ToDelegate<GetMessageNameFunc>();
            uint count = LocalMemory.Read<uint>(funcAddress + patternOffset);
            for (ushort i = 0; i < count; i++) result.Add(i, Marshal.PtrToStringUni(func(i)));
            return result;
        }
        #endregion
    }
}