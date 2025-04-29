using CA.GestionEtudiant.Deskptop.Commands.Students;
using CA.GestionEtudiant.Deskptop.Models;
using CA.GestionEtudiant.Deskptop.Stores;
using CA.GestionEtudiant.Deskptop.Stores.Students;
using CA.GestionEtudiant.Deskptop.ViewModels.Commons;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Windows.Input;


namespace CA.GestionEtudiant.Deskptop.ViewModels.Students
{
    public class StudentListingViewModel : ViewModelBase
    {
        //1- Properties
        private readonly StudentStore _studentStore;
        private readonly ObservableCollection<StudentViewModel> _students;
        public IEnumerable<StudentViewModel> Students => _students;
        public bool HasStudents => _students.Count > 0;
        public ICommand LoadStudentsCommand { get; }

        //2- Constructor
        public StudentListingViewModel(StudentStore studentStore, MessageStore messageStore)
        {
            _studentStore = studentStore;
            _students = new ObservableCollection<StudentViewModel>();

            _students.CollectionChanged += Students_CollectionChanged!;
            _studentStore.StudentCreated += StudentStore_StudentCreated;
            _studentStore.StudentsLoaded += UpdateStudents;

            LoadStudentsCommand = new LoadStudentsCommand(_studentStore, messageStore);
        }

        //3- Methods
        public static StudentListingViewModel LoadViewModel(StudentStore studentStore, MessageStore messageStore)
        {
            var studentViewModel = new StudentListingViewModel(studentStore, messageStore);

            studentViewModel.LoadStudentsCommand.Execute(null);

            return studentViewModel;
        }

        public override void Dispose()
        {
            _studentStore.StudentCreated -= StudentStore_StudentCreated;
            _studentStore.StudentsLoaded -= UpdateStudents;
            base.Dispose();
        }

        private void StudentStore_StudentCreated(Student student)
        {
            var studentViewModel = new StudentViewModel(student);
            _students.Add(studentViewModel);
        }

        private void UpdateStudents()
        {
            _students.Clear();

            foreach (var student in _studentStore.Students)
            {
                var studentViewModel = new StudentViewModel(student);
                _students.Add(studentViewModel);
            }
        }

        private void Students_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            OnPropertyChanged(nameof(HasStudents));
        }
    }
}
