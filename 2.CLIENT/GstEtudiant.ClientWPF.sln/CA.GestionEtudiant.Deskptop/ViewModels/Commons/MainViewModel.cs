using CA.GestionEtudiant.Deskptop.Stores;


namespace CA.GestionEtudiant.Deskptop.ViewModels.Commons
{
    public class MainViewModel : ViewModelBase
    {
        //1- Propriétes
        private readonly NavigationStore _navigationStore;
        public ViewModelBase CurrentViewModel => _navigationStore.CurrentViewModel;

        //2- Constructeur
        public MainViewModel(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
            _navigationStore.CurrentViewModelChanged += OnCurrentViewModelChanged;
        }

        //3- Méthodes
        private void OnCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }

    }
}
