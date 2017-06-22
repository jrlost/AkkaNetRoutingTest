using Akka.Actor;
using Akka.Event;

namespace Shared {
	public class Actor : ReceiveActor {

		public Actor() {
			Context.GetLogger().Info("Created Actor");
			Receive<Message>(m => Context.GetLogger().Info("Received Message"));
		}
	}
}
