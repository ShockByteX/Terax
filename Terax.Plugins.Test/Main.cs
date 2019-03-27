using System.Numerics;
using Tera.Core.Network;
using Tera.Core.Network.Protocol.Packets;
using Tera.Core.Plugins;

namespace Terax.Plugins.Test
{
    public class Main : IPlugin
    {
        #region Properties
        public string Name => "Test-Plugin";
        #endregion
        #region Fields
        private Vector3 prevPosition = Vector3.Zero;
        #endregion
        #region [PUBLIC]Methods
        public void Start(GameClient client)
        {
            client.Processor.AddHandler<C_PLAYER_LOCATION>(Handle_CPlayerLocation);
        }
        public void Stop(GameClient client)
        {
            client.Processor.RemoveHandler<C_PLAYER_LOCATION>(Handle_CPlayerLocation);
        }
        #endregion
        #region Handlers
        private bool Handle_CPlayerLocation(GameClient client, PacketDirection direction, C_PLAYER_LOCATION packet)
        {
            if (prevPosition == Vector3.Zero) { prevPosition = packet.Position; return true; }
            packet.Position = ((packet.Position - prevPosition) * 2) + packet.Position;
            return true;
        }
        #endregion
    }
}