using CA.GestionEtudiant.Deskptop.Components.Posts;
using CA.GestionEtudiant.Deskptop.Services;

namespace CA.GestionEtudiant.Deskptop.Stores.Posts
{
    public class PostStore
    {
        // Fields
        private readonly PostService _postService;
        private readonly List<CA.GestionEtudiant.Deskptop.Models.Post> _posts;

        private Lazy<Task> _loadPostsLazy;

        public IEnumerable<CA.GestionEtudiant.Deskptop.Models. Post> Posts => _posts;

        public event Action PostsLoaded;
        public event Action<CA.GestionEtudiant.Deskptop.Models.Post> PostCreated;

        // Constructor
        public PostStore(PostService postService)
        {
            _postService = postService;
            _posts = new List<CA.GestionEtudiant.Deskptop.Models.Post>();

            _loadPostsLazy = CreateLoadPostsLazy();
        }

        // Methods
        public async Task LoadPosts()
        {
            await _loadPostsLazy.Value;
        }
        public async Task RefreshPosts()
        {
            _loadPostsLazy = CreateLoadPostsLazy();
            await LoadPosts();
        }

        public void CreatePost(CA.GestionEtudiant.Deskptop.Models.Post post)
        {
            _posts.Add(post);
            PostCreated?.Invoke(post);
        }

        private Lazy<Task> CreateLoadPostsLazy()
        {
            return new Lazy<Task>(() => InitializePosts());
        }

        private async Task InitializePosts()
        {
            var posts = await _postService.GetAllPosts();

            _posts.Clear();
            _posts.AddRange(posts);

            PostsLoaded?.Invoke();
        }
    }
}
