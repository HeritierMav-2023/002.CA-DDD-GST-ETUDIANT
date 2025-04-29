using CA.GestionEtudiant.Deskptop.Models;
using CA.GestionEtudiant.Deskptop.Services;


namespace CA.GestionEtudiant.Deskptop.Stores.Students
{
    public class StudentStore
    {
        // Fields
        private readonly StudentService _studentService;
        private List<Student> _students;

        private Lazy<Task> _loadStudentLazy;
        public IEnumerable<Student> Students => _students;

        public event Action StudentsLoaded;
        public event Action<Student> StudentCreated;

        // Constructor
        public StudentStore(StudentService studentService)
        {
            _studentService = studentService;
            _students = new List<Student>();
            _loadStudentLazy = CreateLoadStudentsLazy();
        }

        // Methods
        public async Task LoadStudentsAsync()
        {
            await _loadStudentLazy.Value;
        }

        private async Task InitializePosts()
        {
            var students = await _studentService.GetStudentsAsync();
            _students.Clear();
            foreach (var student in students)
            {
                _students.Add(student);
                StudentCreated?.Invoke(student);
            }
            StudentsLoaded?.Invoke();
        }

        private Lazy<Task> CreateLoadStudentsLazy()
        {
            return new Lazy<Task>(() =>
            {
                return Task.Run(async () =>
                {
                    await InitializePosts();
                });
            });
        }

        public async Task RefreshStudents()
        {
            _loadStudentLazy = CreateLoadStudentsLazy();
            await LoadStudentsAsync();
        }

        //public void AddStudent(StudentModel student)
        //{
        //    _students.Add(student);
        //    StudentCreated?.Invoke(student);
        //}

    }
}
