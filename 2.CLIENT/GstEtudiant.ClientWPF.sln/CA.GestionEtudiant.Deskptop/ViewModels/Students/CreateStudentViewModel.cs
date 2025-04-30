using CA.GestionEtudiant.Deskptop.Commands;
using CA.GestionEtudiant.Deskptop.Stores;
using CA.GestionEtudiant.Deskptop.Stores.Students;
using CA.GestionEtudiant.Deskptop.ViewModels.Commons;
using System.Windows;
using System.Windows.Input;


namespace CA.GestionEtudiant.Deskptop.ViewModels.Students
{
    public class CreateStudentViewModel : ViewModelBase
    {
        //1. Properties
        private string? _firstname;

        public string FirstName
        {
            get { return _firstname!; }
            set {
                _firstname = value; 
                OnPropertyChanged(nameof(FirstName)); 
            }
        }

        private string? _lastname;
        public string LastName
        {
            get { return _lastname!; }
            set
            {
                _lastname = value;
                OnPropertyChanged(nameof(LastName));
            }
        }

        private string? _email;
        public string Email
        {
            get { return _email!; }
            set
            {
                _email = value;
                OnPropertyChanged(nameof(Email));
            }
        }
        private string? _cours;
        public string Cours
        {
            get { return _cours!; }
            set
            {
                _cours = value;
                OnPropertyChanged(nameof(Cours));
            }
        }

        private string? _entreprise;
        public string Entreprise
        {
            get { return _entreprise!; }
            set
            {
                _entreprise = value;
                OnPropertyChanged(nameof(Entreprise));
            }
        }
        private decimal _prix;
        public decimal Prix
        {
            get { return _prix; }
            set
            {
                _prix = value;
                OnPropertyChanged(nameof(Prix));
            }
        }

        private string? _enseignant;
        public string Enseignant
        {
            get { return _enseignant!; }
            set
            {
                _enseignant = value;
                OnPropertyChanged(nameof(Enseignant));
            }
        }
        private int _nbreHeures;
        public int NbreHeures
        {
            get { return _nbreHeures; }
            set
            {
                _nbreHeures = value;
                OnPropertyChanged(nameof(NbreHeures));
            }
        }

        private DateTime _debutCours;
        public DateTime DebutCours
        {
            get { return _debutCours; }
            set
            {
                _debutCours = value;
                OnPropertyChanged(nameof(DebutCours));
            }
        }

        private DateTime _finCours;
        public DateTime FinCours
        {
            get { return _finCours; }
            set
            {
                _finCours = value;
                OnPropertyChanged(nameof(FinCours));
            }
        }

        public Visibility DialogVisibility
        {
            get => _dialogVisibility;
            set
            {
                _dialogVisibility = value;
                OnPropertyChanged(nameof(DialogVisibility));
            }
        }

        public Visibility SpinnerVisibility
        {
            get => _spinnerVisibility;
            set
            {
                _spinnerVisibility = value;
                OnPropertyChanged(nameof(SpinnerVisibility));
            }
        }

        public string DialogResult
        {
            get => _dialogResult;
            set
            {
                _dialogResult = value;
                OnPropertyChanged(nameof(DialogResult));
            }
        }

        public string StatusMessage
        {
            get => _statusMessage;
            set
            {
                _statusMessage = value;
                OnPropertyChanged(nameof(StatusMessage));
            }
        }


        // Others Properties
        private Visibility _dialogVisibility = Visibility.Hidden;
        private Visibility _spinnerVisibility = Visibility.Hidden;
        private string _dialogResult;
        private string _statusMessage;

        // Commands
        public ICommand OpenDialogCommand { get; }
        public ICommand CloseDialogCommand { get; }
        public ICommand CreateStudentCommand { get; }

        //2. Constructor
        public CreateStudentViewModel(StudentStore studentStore, MessageStore messageStore)
        {
            CreateStudentCommand = new Commands.Students.CreateStudentCommand(this, studentStore, messageStore);
            OpenDialogCommand = new RelayCommand(OpenDialog);
            CloseDialogCommand = new RelayCommand<string>(CloseDialog);
        }

        //3. Methods
        private void OpenDialog()
        {
            SimulateShort();
            DialogVisibility = Visibility.Visible;
        }
        private void CloseDialog(string result)
        {
            DialogVisibility = Visibility.Collapsed;
            DialogResult = $"Résultat: {result} - {DateTime.Now:T}";
        }
        public async void SimulateShort()
        {
            StatusMessage = "Chargement en cours...";
            SpinnerVisibility = Visibility.Visible;

            await Task.Delay(2000); // Simulation d'une opération longue

            StatusMessage = "Chargement terminé !";
            await Task.Delay(500);

            SpinnerVisibility = Visibility.Collapsed;

        }

    }
}
