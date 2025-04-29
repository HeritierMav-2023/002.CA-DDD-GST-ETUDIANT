
using CA.GestionEtudiant.Deskptop.ViewModels.Commons;

namespace CA.GestionEtudiant.Deskptop.Stores
{
    /// <summary>
    /// /// This class is responsible for managing the current ViewModel in the application.
    /// </summary>
    public class NavigationStore
    {
        private ViewModelBase? _currentViewModel;
        public ViewModelBase CurrentViewModel
        {
            get
            {
                return _currentViewModel!;
            }
            set
            {
                _currentViewModel = value;
                CurrentViewModelChanged?.Invoke();
            }
        }

        public event Action? CurrentViewModelChanged;
    }
}
