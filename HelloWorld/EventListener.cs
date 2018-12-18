using Rocket.API.Eventing;
using Rocket.Core.Eventing;
using Rocket.Core.Player.Events;
using Rocket.Core.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thiestoril.HelloWorld
{
    public class EventListener : IEventListener<PlayerConnectedEvent>
    {
        private Config config;

        public EventListener(Config config)
        {
            this.config = config;
        }

        [Rocket.Core.Eventing.EventHandler]
        public void HandleEvent (IEventEmitter emitter, PlayerConnectedEvent @event)
        {
            @event.User.SendMessage(config.WelcomeMsg);
        }
    }
}
