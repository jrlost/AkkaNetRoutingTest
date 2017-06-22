using Akka.Actor;
using Topshelf;

namespace NonSeed {
	public class NonSeedService : ServiceControl {
		protected ActorSystem ClusterSystem;

		public bool Start(HostControl hostControl) {
			ClusterSystem = ActorSystem.Create("TestCluster");

			return true;
		}

		public bool Stop(HostControl hostControl) {
			ClusterSystem.Terminate();
			return true;
		}
	}
}