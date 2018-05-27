﻿using Rocket.API.Eventing;
using Rocket.API.Player;
using Rocket.API.User;
using Rocket.Core.Player.Events;
using Rocket.Core.User.Events;

namespace Rocket.Core.Player.Events
{
    public class PlayerDisconnectedEvent: UserDisconnectedEvent
    {
        public IPlayer Player { get; }
        public PlayerDisconnectedEvent(IPlayer player) : base(player.Extend().User)
        {
            Player = player;
        }
        public PlayerDisconnectedEvent(IPlayer player, string reason = null) : base(player.Extend().User, reason)
        {
            Player = player;
        }
        public PlayerDisconnectedEvent(IPlayer player, string reason = null, bool global = true) : base(player.Extend().User, reason, global)
        {
            Player = player;
        }
        public PlayerDisconnectedEvent(IPlayer player, string reason = null, EventExecutionTargetContext executionTarget = EventExecutionTargetContext.Sync, bool global = true) : base(player.Extend().User, reason, executionTarget, global)
        {
            Player = player;
        }
        public PlayerDisconnectedEvent(IPlayer player, string reason = null, string name = null, EventExecutionTargetContext executionTarget = EventExecutionTargetContext.Sync, bool global = true) : base(player.Extend().User, reason, name, executionTarget, global)
        {
            Player = player;
        }
    }
}