using System;
using System.Linq;
using System.Reflection;

namespace Tera.Core.Helpers
{
    public static class AssemblyHelper
    {
        #region Fields

        #endregion
        public static Assembly Assembly = Assembly.GetExecutingAssembly();
        #region [PUBLIC]Methods
        public static Type[] GetTypes(string strNamespace)
        {
            return (from type in Assembly.GetTypes() where type.Namespace == strNamespace select type).ToArray();
        }
        #endregion
    }
}