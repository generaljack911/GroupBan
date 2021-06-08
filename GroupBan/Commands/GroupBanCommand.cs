using Rocket.API;
using Rocket.Core.Logging;
using Rocket.Unturned.Player;
using SDG.Unturned;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupBan.Commands
{
    class GroupBanCommand : IRocketCommand
    {
        public AllowedCaller AllowedCaller => AllowedCaller.Both;

        public string Name => "groupban";

        public string Help => "This group bans Groups that are online";

        public string Syntax => "";

        public List<string> Aliases => new List<string>();

        public List<string> Permissions => new List<string>();

        public void Execute(IRocketPlayer caller, string[] command)
        {
            UnturnedPlayer player = UnturnedPlayer.FromName(command[0]);

            if (player != null)
            {
                foreach (SteamPlayer otherplayer in Provider.clients)
                {
                    UnturnedPlayer sameplayer = UnturnedPlayer.FromSteamPlayer(otherplayer);

                    if (sameplayer.SteamGroupID == player.SteamGroupID)
                    {
                        sameplayer.Ban("You were banned!", 999999999);


                        Logger.Log($"{sameplayer.DisplayName} was banned!");
                    }
                }
            }
        }
    }
}
