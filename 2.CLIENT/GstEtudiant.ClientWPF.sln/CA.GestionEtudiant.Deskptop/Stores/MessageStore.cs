﻿
namespace CA.GestionEtudiant.Deskptop.Stores
{
    /// <summary>
    /// /// Represents the type of message to be displayed.
    /// </summary>
    public enum MessageType
    {
        Status,
        Error
    }

    /// <summary>
    /// /// A store for managing messages in the application.
    /// </summary>
    public class MessageStore
    {
        private string? _currentMessage;
        public string CurrentMessage
        {
            get => _currentMessage!;
            private set
            {
                _currentMessage = value;
                CurrentMessageChanged?.Invoke();
            }
        }

        private MessageType _currentMessageType;
        public MessageType CurrentMessageType
        {
            get => _currentMessageType;
            private set
            {
                _currentMessageType = value;
                CurrentMessageTypeChanged?.Invoke();
            }
        }

        public bool HasCurrentMessage => !string.IsNullOrEmpty(CurrentMessage);

        public event Action? CurrentMessageChanged;
        public event Action? CurrentMessageTypeChanged;

        public void SetCurrentMessage(string message, MessageType messageType)
        {
            CurrentMessage = message;
            CurrentMessageType = messageType;
        }

        public void ClearCurrentMessage()
        {
            CurrentMessage = string.Empty;
        }
    }
}
