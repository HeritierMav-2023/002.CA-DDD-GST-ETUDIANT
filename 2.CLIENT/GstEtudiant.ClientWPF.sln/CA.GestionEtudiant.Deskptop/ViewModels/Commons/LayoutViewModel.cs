using CA.GestionEtudiant.Deskptop.ViewModels.Messages;


namespace CA.GestionEtudiant.Deskptop.ViewModels.Commons
{
    /// <summary>
    /// /// ViewModel for the main layout of the application, including the navigation bar and global messages.
    /// </summary>
    public class LayoutViewModel : ViewModelBase
    {
        //1- Propriétés
        public NavigationBarViewModel NavigationBarViewModel { get; }
        public GlobalMessageViewModel GlobalMessageViewModel { get; }
        public ViewModelBase ContentViewModel { get; }

        //2- Constructeur
        public LayoutViewModel(NavigationBarViewModel navigationBarViewModel,
            GlobalMessageViewModel globalMessageViewModel,
            ViewModelBase contentViewModel)
        {
            NavigationBarViewModel = navigationBarViewModel;
            GlobalMessageViewModel = globalMessageViewModel;
            ContentViewModel = contentViewModel;
        }

        //3- Méthodes
        public override void Dispose()
        {
            NavigationBarViewModel.Dispose();
            GlobalMessageViewModel.Dispose();
            ContentViewModel.Dispose();

            base.Dispose();
        }
    }
}
