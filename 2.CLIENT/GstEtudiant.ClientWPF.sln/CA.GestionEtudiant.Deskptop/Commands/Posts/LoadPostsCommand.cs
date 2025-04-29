using CA.GestionEtudiant.Deskptop.Stores;
using CA.GestionEtudiant.Deskptop.Stores.Posts;


namespace CA.GestionEtudiant.Deskptop.Commands.Posts
{
    public class LoadPostsCommand : AsyncCommandBase
    {
        //1- Properties
        private readonly PostStore _postStore;
        private readonly MessageStore _messageStore;

        //2- Constructor
        public LoadPostsCommand(PostStore postStore, MessageStore messageStore)
        {
            _postStore = postStore;
            _messageStore = messageStore;
        }

        protected override async Task ExecuteAsync(object parameter)
        {
            try
            {
                await _postStore.LoadPosts();
            }
            catch (Exception)
            {
                _messageStore.SetCurrentMessage("Failed to load posts.", MessageType.Error);
            }
        }
    }
}
