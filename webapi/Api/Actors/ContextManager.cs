using Akka.Actor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.Actors
{
    public class ContextManager
    {
        public static IActorRef BookActor;

        public static void Init()
        {
            var system = ActorSystem.Create("truqueando");
            BookActor = system.ActorOf<BookActor>("book");
        }
    }
}