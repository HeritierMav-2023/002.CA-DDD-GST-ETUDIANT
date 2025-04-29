using CA.GestionEtudiant.Deskptop.Commands;
using CA.GestionEtudiant.Deskptop.Services.Navigations;
using System.Windows.Input;

namespace CA.GestionEtudiant.Deskptop.ViewModels.Commons
{
    /// <summary>
    /// /// ViewModel for the navigation bar in the application.
    /// </summary>
    public class NavigationBarViewModel : ViewModelBase
    {
        //1- Propriétés
        public ICommand NavigatePostHomeCommand { get; }
        public ICommand NavigatePostListingCommand { get; }

        public ICommand NavigateStudentListingCommand { get; }

        //2- Constructeur
        public NavigationBarViewModel(INavigationService postsHomeNavigationService,
             INavigationService postListingNavigationService, INavigationService studentListingService)
        {
            NavigatePostHomeCommand = new NavigateCommand(postsHomeNavigationService);
            NavigatePostListingCommand = new NavigateCommand(postListingNavigationService);
            NavigateStudentListingCommand = new NavigateCommand(studentListingService);
        }

    }
}
