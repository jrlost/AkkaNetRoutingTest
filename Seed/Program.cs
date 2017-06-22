using System;
using Akka.Actor;
using Akka.Routing;
using Shared;

namespace Seed {
	public class Program {
		static void Main(string[] args) {
			var system = ActorSystem.Create("TestCluster");
			Console.ReadLine();

			var actors = system.ActorOf(
				Props
					.Create<Actor>()
					.WithRouter(FromConfig.Instance),
				"nonseed-test"
			);

			actors.Tell(new Message());

			system.WhenTerminated.Wait();
		}
	}
}
