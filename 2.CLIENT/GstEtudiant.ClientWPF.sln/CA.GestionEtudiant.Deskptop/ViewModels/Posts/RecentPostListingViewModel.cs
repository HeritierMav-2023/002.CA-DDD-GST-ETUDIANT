using CA.GestionEtudiant.Deskptop.Commands.Posts;
using CA.GestionEtudiant.Deskptop.Models;
using CA.GestionEtudiant.Deskptop.Stores;
using CA.GestionEtudiant.Deskptop.Stores.Posts;
using CA.GestionEtudiant.Deskptop.ViewModels.Commons;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CA.GestionEtudiant.Deskptop.ViewModels.Posts
{
    public class RecentPostListingViewModel : ViewModelBase
    {
        //1- Propriétes
        private readonly PostStore _postStore;
        private readonly ObservableCollection<PostViewModel> _posts;
        public IEnumerable<PostViewModel> Posts => _posts;
        public bool HasPosts => _posts.Count > 0;
        public ICommand LoadPostsCommand { get; }

        //2- Constructeur
        public RecentPostListingViewModel(PostStore postStore, MessageStore messageStore)
        {
            _postStore = postStore;
            _posts = new ObservableCollection<PostViewModel>();

            _posts.CollectionChanged += Posts_CollectionChanged!;

            _postStore.PostCreated += PostStore_PostCreated;
            _postStore.PostsLoaded += UpdatePosts;

            LoadPostsCommand = new LoadPostsCommand(_postStore, messageStore);
        }

        //3- Méthodes
        public static RecentPostListingViewModel LoadViewModel(PostStore postStore, MessageStore messageStore)
        {
            var viewModel = new RecentPostListingViewModel(postStore, messageStore);
            viewModel.LoadPostsCommand.Execute(null);
            return viewModel;
        }

        public override void Dispose()
        {
            _postStore.PostCreated -= PostStore_PostCreated;
            _postStore.PostsLoaded -= UpdatePosts;
            base.Dispose();
        }

        private void PostStore_PostCreated(Post post)
        {
            var postViewModel = new PostViewModel(post);
            _posts.Insert(0, postViewModel);
            if (_posts.Count > 5)
            {
                _posts.RemoveAt(_posts.Count - 1);
            }
        }

        private void UpdatePosts()
        {
            _posts.Clear();

            foreach ( CA.GestionEtudiant.Deskptop.Models. Post post in _postStore.Posts
                .OrderByDescending(p => p.DateCreated)
                .Take(5))
            {
                PostViewModel postViewModel = new PostViewModel(post);
                _posts.Add(postViewModel);
            }
        }


        private void Posts_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            OnPropertyChanged(nameof(HasPosts));
        }
    }
}
