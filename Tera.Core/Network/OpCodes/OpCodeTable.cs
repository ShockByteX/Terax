using System.Collections.Generic;

namespace Tera.Core.Network.OpCodes
{
    public sealed class OpCodeTable
    {
        #region Fields
        public readonly IReadOnlyDictionary<ushort, string> OpCodeToName;
        public readonly IReadOnlyDictionary<string, ushort> NameToOpCode;
        #endregion
        #region Constructors
        public OpCodeTable(Dictionary<ushort, string> table)
        {
            Dictionary<string, ushort> ntoc = new Dictionary<string, ushort>();
            foreach (KeyValuePair<ushort, string> kvp in table) ntoc.Add(kvp.Value, kvp.Key);
            OpCodeToName = table;
            NameToOpCode = ntoc;
        }
        #endregion
    }
}