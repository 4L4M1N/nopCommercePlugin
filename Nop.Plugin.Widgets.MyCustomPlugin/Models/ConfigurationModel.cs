using Nop.Web.Framework.Models;
using Nop.Web.Framework.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nop.Plugin.Widgets.MyCustomPlugin.Models
{
    public class ConfigurationModel : BaseNopModel
    {
        [NopResourceDisplayName("Plugin.Widgets.MyCustomPlugin.UseSandbox")]
        public bool UseSandbox { get; set; }
        [NopResourceDisplayName("Plugin.Widgets.MyCustomPlugin.Message")]
        public string Message { get; set; }
    }
}
