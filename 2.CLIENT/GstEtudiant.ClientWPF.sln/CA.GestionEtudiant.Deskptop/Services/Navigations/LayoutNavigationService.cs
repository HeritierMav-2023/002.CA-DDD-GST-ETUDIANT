
using CA.GestionEtudiant.Deskptop.Stores;
using CA.GestionEtudiant.Deskptop.ViewModels.Commons;
using CA.GestionEtudiant.Deskptop.ViewModels.Messages;

namespace CA.GestionEtudiant.Deskptop.Services.Navigations
{
    /// <summary>
    /// Service for navigating to a layout view model with a navigation bar and global message view model.
    /// </summary>
    /// <typeparam name="TViewModel"></typeparam>
    public class LayoutNavigationService<TViewModel> : INavigationService where TViewModel : ViewModelBase
    {
        //1- Propriétés
        private readonly NavigationStore _navigationStore;
        private readonly CreateViewModel<TViewModel> _createViewModel;
        private readonly CreateViewModel<GlobalMessageViewModel> _createGlobalMessageViewModel;
        private readonly CreateViewModel<NavigationBarViewModel> _createNavigationBarViewModel;

        //2- Constructeur
        public LayoutNavigationService(
            NavigationStore navigationStore,
            CreateViewModel<TViewModel> createViewModel,
            CreateViewModel<GlobalMessageViewModel> createGlobalMessageViewModel,
            CreateViewModel<NavigationBarViewModel> createNavigationBarViewModel)
        {
            _navigationStore = navigationStore;
            _createViewModel = createViewModel;
            _createGlobalMessageViewModel = createGlobalMessageViewModel;
            _createNavigationBarViewModel = createNavigationBarViewModel;
        }
        //3- Méthode
        public void Navigate()
        {
            _navigationStore.CurrentViewModel = new LayoutViewModel(
                _createNavigationBarViewModel(),
                _createGlobalMessageViewModel(),
                _createViewModel());
        }
    }
}
