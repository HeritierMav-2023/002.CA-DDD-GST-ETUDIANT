
using CA.GestionEtudiant.Deskptop.Stores;
using CA.GestionEtudiant.Deskptop.ViewModels.Commons;

namespace CA.GestionEtudiant.Deskptop.Services.Navigations
{
    public class NavigationService<TViewModel> : INavigationService where TViewModel : ViewModelBase
    {
        //1- Propriétes
        private readonly NavigationStore _navigationStore;
        private readonly CreateViewModel<TViewModel> _createViewModel;

        //2- Constructeur
        public NavigationService(NavigationStore navigationStore, CreateViewModel<TViewModel> createViewModel)
        {
            _navigationStore = navigationStore;
            _createViewModel = createViewModel;
        }

        //3- Méthodes
        public void Navigate()
        {
            _navigationStore.CurrentViewModel = _createViewModel();
        }
    }
}
