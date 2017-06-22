using Topshelf;

namespace NonSeed {
	class Program {
		static void Main(string[] args) {
			HostFactory.Run(x => {
				x.SetServiceName("NonSeedNode");
				x.SetDisplayName("Test Non-Seed Node");
				x.SetDescription("Test Non-Seed Node");

				x.UseAssemblyInfoForServiceInfo();
				x.RunAsLocalSystem();
				x.StartAutomatically();
				x.Service<NonSeedService>();
				x.EnableServiceRecovery(r => r.RestartService(1));
			});
		}
	}
}
