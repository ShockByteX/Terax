using System;
using System.Collections.Generic;
using System.ComponentModel.Composition.Hosting;
using System.IO;
using System.Linq;
using System.Reflection;
using Tera.Core.Network;

namespace Tera.Core.Plugins
{
    public sealed class PluginLoader
    {
        #region Constants
        private const string CLASS_SUFFIX = "Plugin";
        private const string NAMESPACE_PREFIX = "Terax.Plugins.";
        #endregion
        #region Fields
        private List<IPlugin> _plugins = new List<IPlugin>();
        #endregion
        #region Fields
        public readonly IEnumerable<FileInfo> Files;
        public IReadOnlyList<IPlugin> Plugins => _plugins.AsReadOnly();
        #endregion
        #region Proprties
        public PluginLoader(string directory, string pluginFilePattern = "Terax.Plugins.*.dll")
        {
            DirectoryInfo dirPlugins = new DirectoryInfo($"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\\{directory}");
            if (!dirPlugins.Exists) throw new PluginException($"Coudn't find path: {dirPlugins.FullName}");
            Files = dirPlugins.EnumerateFiles(pluginFilePattern, SearchOption.TopDirectoryOnly);
            foreach (FileInfo file in Files)
            {
                byte[] buffer;
                using (FileStream stream = file.OpenRead()) { buffer = new byte[stream.Length]; stream.Read(buffer, 0, buffer.Length); };
                Assembly assembly = Assembly.Load(buffer);
                _plugins.Add((IPlugin)assembly.CreateInstance($"{assembly.GetName().Name}.Main"));
            }
        }
        #endregion
        #region [PUBLIC]Methods
        public void Start(GameClient client) { foreach (IPlugin plugin in _plugins) plugin.Start(client); }
        public void Stop(GameClient client) { foreach (IPlugin plugin in Plugins) plugin.Stop(client); }
        #endregion
    }
}