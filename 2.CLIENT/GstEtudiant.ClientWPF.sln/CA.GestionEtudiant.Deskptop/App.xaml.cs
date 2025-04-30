using CA.GestionEtudiant.Deskptop.Services.Navigations;
using CA.GestionEtudiant.Deskptop.Stores;
using CA.GestionEtudiant.Deskptop.Stores.Students;
using CA.GestionEtudiant.Deskptop.ViewModels.Commons;
using CA.GestionEtudiant.Deskptop.ViewModels.Messages;
using CA.GestionEtudiant.Deskptop.ViewModels.Students;
using System.Windows;

namespace CA.GestionEtudiant.Deskptop
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        //1- Proprietes
        private readonly NavigationStore _navigationStore;
        private readonly StudentStore _studentStore;
        private readonly MessageStore _messageStore;

        //2- Constructeur
        public App()
        {
            _navigationStore = new NavigationStore();
            _studentStore = new StudentStore( new Services.StudentService());
            _messageStore = new MessageStore();
        }
        //3- Méthodes
        protected override void OnStartup(StartupEventArgs e)
        {
            var navigationService = CreateStudentListingNavigationService();

            //1- Navigation vers la page d'accueil
            navigationService.Navigate();

            //1- Appel de la méthode de base
            base.OnStartup(e);
            //2- Création de la fenêtre principale
            MainWindow mainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_navigationStore)
            };

            //3- Affichage de la fenêtre principale
            mainWindow.Show();
        }

        //1- Create ViewModel
        private StudentListingViewModel CreateStudentListingViewModel() 
        {
            return StudentListingViewModel.LoadViewModel(_studentStore, _messageStore);
        }

        //2- Create NavigationService
       
        private INavigationService CreateStudentListingNavigationService() 
        {
            return new LayoutNavigationService<StudentListingViewModel>(_navigationStore,
                CreateStudentListingViewModel,
                CreateGlobalMessageViewModel,
                CreateNavigationBarViewModel);
        }
        //3- Create Bar navigation
        private NavigationBarViewModel CreateNavigationBarViewModel()
        {
            return new NavigationBarViewModel(
                CreateStudentListingNavigationService());// ajout de la navigation vers la liste des produits Tod 3
        }

        //4- Méthode
        private GlobalMessageViewModel CreateGlobalMessageViewModel()
        {
            return new GlobalMessageViewModel(_messageStore);
        }
    }

}
