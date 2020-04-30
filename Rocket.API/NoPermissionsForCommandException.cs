using System;

namespace Rocket.API
{
    public class NoPermissionsForCommandException : Exception
    {
        private readonly IRocketCommand command;
        private readonly IRocketPlayer player;
        public NoPermissionsForCommandException(IRocketPlayer player, IRocketCommand command)
        {
            this.command = command;
            this.player = player;
        }
        public override string Message
        {
            get
            {
               return "The player " + player.DisplayName + " has no permission to execute the command " + command.Name;
            }
        }
    }
}
