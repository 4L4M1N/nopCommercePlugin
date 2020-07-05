using Nop.Core.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nop.Plugin.Widgets.MyCustomPlugin
{
    public class MyCustomPluginSettings : ISettings
    {
        public bool UseSandbox { get; set; }
        public string Message { get; set; }
    }
}
