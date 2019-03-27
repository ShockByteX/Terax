using System.Runtime.InteropServices;

namespace TeraxHook.Native
{
    public static class Kernel32
    {
        [DllImport("Kernel32.dll", EntryPoint = "RtlMoveMemory", SetLastError = false)]
        public static extern unsafe void MoveMemory(void* dest, void* src, int size);
    }
}