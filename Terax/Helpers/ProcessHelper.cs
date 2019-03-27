using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terax.Helpers
{
    public static class ProcessHelper
    {
        #region [PUBLIC]Methods
        public static Process GetProcess(string processName)
        {
            try { return Process.GetProcessesByName(processName)[0]; }
            catch { return null; }                    
        }
        #endregion
    }
}