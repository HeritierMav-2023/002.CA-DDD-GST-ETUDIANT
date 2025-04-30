
using CA.GestionEtudiant.Deskptop.Models;
using CA.GestionEtudiant.Deskptop.Stores;
using CA.GestionEtudiant.Deskptop.Stores.Students;
using CA.GestionEtudiant.Deskptop.ViewModels.Students;

namespace CA.GestionEtudiant.Deskptop.Commands.Students
{
    /// <summary>
    /// /// Command to create a new student.
    /// </summary>
    public class CreateStudentCommand : CommandBase
    {
        //1- Properties
        private readonly CreateStudentViewModel _viewModel;
        private readonly StudentStore _studentStore;
        private readonly MessageStore _messageStore;

        //2- Constructor
        public CreateStudentCommand(CreateStudentViewModel viewModel, StudentStore studentStore, MessageStore messageStore)
        {
            _viewModel = viewModel;
            _studentStore = studentStore;
            _messageStore = messageStore;
        }
        //3- Methods
        public override void Execute(object? parameter)
        {
            //1- Create a new student
            var student = new Student
            {
                FirstName = _viewModel.FirstName,
                LastName = _viewModel.LastName,
                Email = _viewModel.Email,
                Cours = _viewModel.Cours,
                Entreprise = _viewModel.Entreprise
            };
            //2- Add the student to the store
            _studentStore.AddStudent(student);
            _studentStore.StudentCreated += (s) =>
            {
                _messageStore.SetCurrentMessage($"Student {s.FirstName} {s.LastName} created successfully.", MessageType.Status);
            };

            //3- Clear the view model
            _viewModel.FirstName = string.Empty;
            _viewModel.LastName = string.Empty;
            _viewModel.Email = string.Empty;
            _viewModel.Cours = string.Empty;
            _viewModel.Entreprise = string.Empty;
            _viewModel.Prix = 0;
            _viewModel.NbreHeures = 0;
            _viewModel.DebutCours = DateTime.Now;
            _viewModel.FinCours = DateTime.Now;
            _viewModel.Enseignant = string.Empty;

        }
    }
}
