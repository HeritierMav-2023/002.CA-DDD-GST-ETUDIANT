using CA.GestionEtudiant.Deskptop.Models;
using CA.GestionEtudiant.Deskptop.ViewModels.Commons;


namespace CA.GestionEtudiant.Deskptop.ViewModels.Posts
{
    public class PostViewModel : ViewModelBase
    {
        private readonly Post _post;

        public string Title => _post.Title;
        public string Content => _post.Content;
        public DateTime DateCreated => _post.DateCreated;

        public PostViewModel(Post post)
        {
            _post = post;
        }
    }
}
