

using CA.GestionEtudiant.Deskptop.Stores;

namespace CA.GestionEtudiant.Deskptop.Commands
{
    /// <summary>
    /// /// Command to clear the current message in the MessageStore.
    /// </summary>
    public class ClearMessageCommand : CommandBase
    {
        private readonly MessageStore _messageStore;

        public ClearMessageCommand(MessageStore messageStore)
        {
            _messageStore = messageStore;
        }

        public override void Execute(object? parameter)
        {
            _messageStore.ClearCurrentMessage();
        }
    }
}
