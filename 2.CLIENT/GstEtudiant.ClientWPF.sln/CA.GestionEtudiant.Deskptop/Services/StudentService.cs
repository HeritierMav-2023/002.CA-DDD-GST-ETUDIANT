using CA.GestionEtudiant.Deskptop.Models;

namespace CA.GestionEtudiant.Deskptop.Services
{
    public class StudentService
    {
        public Task<IEnumerable<Student>> GetStudentsAsync()
        {
            // Simulate an asynchronous operation
            return Task.FromResult<IEnumerable<Student>>(new List<Student>
            {
                new Student()
                {
                    Id =  1,
                    FirstName = "John",
                    LastName = "Doe",
                    Email = "email@yahoo.fr",
                    Cours = "Math",
                    Entreprise = "Google",
                    NbreHeures = 20,
                    Prix = 1000,
                    DebutCours = new DateTime(2023, 1, 1),
                    FinCours = new DateTime(2023, 6, 1),
                    Enseignant = "Jane Smith",
                },
                new Student() {
                    Id = 2,
                    FirstName = "Alice",
                    LastName = "Johnson",
                    Email = "email1@ gmail.com",
                    Cours = "Science",
                    Entreprise = "Microsoft",
                    NbreHeures = 15,
                    Prix = 1200,
                    DebutCours = new DateTime(2023, 2, 1),
                    FinCours = new DateTime(2023, 7, 1),
                    Enseignant  = "Bob Brown"
                },

                new Student() {
                    Id = 3,
                    FirstName = "Charlie",
                    LastName = "Davis",
                    Email ="email2@gmail.com",
                    Cours = "History",
                    Entreprise = "Amazon",
                    NbreHeures = 10,
                    Prix = 800,
                    DebutCours = new DateTime(2023, 3, 1),
                    FinCours = new DateTime(2023, 8, 1),
                    Enseignant = "Eve White"
                },

                new Student() {
                    Id = 4,
                    FirstName = "David",
                    LastName = "Wilson",
                    Email= "enza@ gmail.com",
                    Cours = "Geography",
                    Entreprise = "Facebook",
                    NbreHeures = 25,
                    Prix = 1500,
                    DebutCours = new DateTime(2023, 4, 1),
                    FinCours = new DateTime(2023, 9, 1),
                    Enseignant = "Frank Green"
                }
            });
        }

    }
}
