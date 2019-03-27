using System.ComponentModel.Composition;
using Tera.Core.Network;

namespace Tera.Core.Plugins
{
    [InheritedExport(typeof(IPlugin))]
    public interface IPlugin
    {
        string Name { get; }
        void Start(GameClient client);
        void Stop(GameClient client);
    }
}