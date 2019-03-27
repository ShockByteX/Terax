using EasyHook;
using System.Collections.Generic;

namespace TeraxHook.Internals
{
    public class HooksController
    {
        #region Fields
        private static List<LocalHook> hooks = new List<LocalHook>();
        #endregion
        #region [PUBLIC]Methods
        public static void InstallHook(LocalHook hook)
        {
            hook.ThreadACL.SetExclusiveACL(new int[] { 0 });
            hooks.Add(hook);
        }
        public static void RemoveHook(LocalHook hook)
        {
            int hooksCount = hooks.Count;
            for (int i = 0; i < hooksCount; i++)
            {
                if (hooks[i].HookBypassAddress == hook.HookBypassAddress)
                {
                    hooks[i].Dispose();
                    hooks.RemoveAt(i);
                    break;
                }
            }
        }
        public static void RemoveAllHooks()
        {
            int hooksCount = hooks.Count;
            for (int i = 0; i < hooksCount; i++) hooks[i].Dispose();
        }
        #endregion
    }
}