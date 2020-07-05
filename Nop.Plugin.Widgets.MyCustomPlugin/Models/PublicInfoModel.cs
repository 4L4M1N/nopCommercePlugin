using Nop.Web.Framework.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nop.Plugin.Widgets.MyCustomPlugin.Models
{
    public class PublicInfoModel : BaseNopModel
    {
        public bool UseSandbox { get; set; }
        public string Message { get; set; }
    }
}
