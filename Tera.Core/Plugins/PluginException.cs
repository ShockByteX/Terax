using System;

namespace Tera.Core.Plugins
{
    public class PluginException : Exception
    {
        public PluginException(string message) : base(message) { }
    }
}