using System.Collections.Generic;

namespace Tera.Core.Network.OpCodes
{

    public sealed class MessageTables
    {
        #region Fields
        public readonly OpCodeTable Game;
        public readonly OpCodeTable System;
        #endregion
        #region Constructors
        public MessageTables(Dictionary<ushort, string> game, Dictionary<ushort, string> system) { Game = new OpCodeTable(game); System = new OpCodeTable(system); }
        #endregion
    }
}