using CA.GestionEtudiant.Deskptop.Commands;
using CA.GestionEtudiant.Deskptop.Stores;
using CA.GestionEtudiant.Deskptop.ViewModels.Commons;

using System.Windows.Input;

namespace CA.GestionEtudiant.Deskptop.ViewModels.Messages
{
    /// <summary>
    /// /// ViewModel for displaying global messages in the application.
    /// </summary>
    public class GlobalMessageViewModel : ViewModelBase
    {
        // 1- Properties
        private readonly MessageStore _messageStore = null!;

        public string Message => _messageStore.CurrentMessage;
        public bool IsStatusMessage => _messageStore.CurrentMessageType == MessageType.Status;
        public bool IsErrorMessage => _messageStore.CurrentMessageType == MessageType.Error;
        public bool HasMessage => _messageStore.HasCurrentMessage;

        public ICommand ClearMessageCommand { get; }

        //2- Constructor
        public GlobalMessageViewModel(MessageStore messageStore)
        {
            _messageStore = messageStore;

            _messageStore.CurrentMessageChanged += MessageStore_CurrentMessageChanged;
            _messageStore.CurrentMessageTypeChanged += MessageStore_CurrentMessageTypeChanged;

            ClearMessageCommand = new ClearMessageCommand(_messageStore);
        }

        //3- Methods
        public override void Dispose()
        {
            _messageStore.CurrentMessageChanged -= MessageStore_CurrentMessageChanged;
            _messageStore.CurrentMessageTypeChanged -= MessageStore_CurrentMessageTypeChanged;

            base.Dispose();
        }

        private void MessageStore_CurrentMessageChanged()
        {
            OnPropertyChanged(nameof(Message));
            OnPropertyChanged(nameof(HasMessage));
        }

        private void MessageStore_CurrentMessageTypeChanged()
        {
            OnPropertyChanged(nameof(IsStatusMessage));
            OnPropertyChanged(nameof(IsErrorMessage));
        }
    }
}
