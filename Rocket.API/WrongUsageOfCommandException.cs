using System;

namespace Rocket.API
{
    public class WrongUsageOfCommandException : Exception
    {
        private readonly IRocketCommand command;
        private readonly IRocketPlayer player;
        public WrongUsageOfCommandException(IRocketPlayer player, IRocketCommand command)
        {
            this.command = command;
            this.player = player;
        }
        public override string Message
        {
            get
            {
               return "The player " + player.DisplayName + " did not correctly use the command " + command.Name;
            }
        }
    }
}
