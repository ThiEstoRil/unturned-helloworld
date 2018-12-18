using System;
using Rocket.API.DependencyInjection;
using Rocket.API.Eventing;
using Rocket.Core.Eventing;
using Rocket.Core.Player.Events;
using Rocket.Core.Plugins;
using Rocket.Core.User;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thiestoril.HelloWorld
{
    public class Main : Plugin <Config>
    {
        public Main (IDependencyContainer container) : base("Welcome Messager", container) { }

    }
}
