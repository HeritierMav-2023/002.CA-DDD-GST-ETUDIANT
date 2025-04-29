using CA.GestionEtudiant.Deskptop.Commands.Posts;
using CA.GestionEtudiant.Deskptop.Models;
using CA.GestionEtudiant.Deskptop.Stores;
using CA.GestionEtudiant.Deskptop.Stores.Posts;
using CA.GestionEtudiant.Deskptop.ViewModels.Commons;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

using System.Windows.Input;

namespace CA.GestionEtudiant.Deskptop.ViewModels.Posts
{
    public class PostListingViewModel : ViewModelBase
    {
        //1- Properties
        private readonly PostStore _postStore;
        private readonly ObservableCollection<PostViewModel> _posts;
        public IEnumerable<PostViewModel> Posts => _posts;
        public bool HasPosts => _posts.Count > 0;
        public ICommand LoadPostsCommand { get; }

        //2- Constructor
        public PostListingViewModel(PostStore postStore, MessageStore messageStore)
        {
            _postStore = postStore;
            _posts = new ObservableCollection<PostViewModel>();

            _posts.CollectionChanged += Posts_CollectionChanged!;

            _postStore.PostCreated += PostStore_PostCreated;
            _postStore.PostsLoaded += UpdatePosts;

            LoadPostsCommand = new LoadPostsCommand(_postStore, messageStore);
        }

        //3- Methods LoadViewModel
        public static PostListingViewModel LoadViewModel(PostStore postStore, MessageStore messageStore)
        {
            var postListingViewModel = new PostListingViewModel(postStore, messageStore);
            postListingViewModel.LoadPostsCommand.Execute(null);
            return postListingViewModel;
        }

        //4- Methods
        public override void Dispose()
        {
            _postStore.PostCreated -= PostStore_PostCreated;
            _postStore.PostsLoaded -= UpdatePosts;
            base.Dispose();
        }

        private void PostStore_PostCreated(Post post)
        {
            PostViewModel postViewModel = new PostViewModel(post);
            _posts.Insert(0, postViewModel);
        }

        private void UpdatePosts()
        {
            _posts.Clear();

            foreach (Post post in _postStore.Posts
                .OrderByDescending(p => p.DateCreated))
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
