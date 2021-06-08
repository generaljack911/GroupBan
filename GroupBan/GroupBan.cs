using Rocket.Core.Logging;
using Rocket.Core.Plugins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupBan
{
    public class GroupBan : RocketPlugin
    {
        protected override void Load()
        {
            Logger.Log("GroupBan has loaded!");
        }
        protected override void Unload()
        {
            Logger.Log("GroupBan has unloaded!");
        }
    }
}
