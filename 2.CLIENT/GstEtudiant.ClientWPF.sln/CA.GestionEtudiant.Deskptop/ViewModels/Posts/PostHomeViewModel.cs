using CA.GestionEtudiant.Deskptop.ViewModels.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA.GestionEtudiant.Deskptop.ViewModels.Posts
{
    public class PostHomeViewModel : ViewModelBase
    {
        //1- Properties
        public CreatePostViewModel CreatePostViewModel { get; }
        public RecentPostListingViewModel RecentPostListingViewModel { get; }

        //2- Constructor
        public PostHomeViewModel(CreatePostViewModel createPostViewModel, RecentPostListingViewModel recentPostListingViewModel)
        {
            CreatePostViewModel = createPostViewModel;
            RecentPostListingViewModel = recentPostListingViewModel;
        }
    }
}
