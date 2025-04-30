

namespace CA.GestionEtudiant.Deskptop.Models
{

    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Cours { get; set; } = null!;
        public string Entreprise { get; set; } = null!;
        public int NbreHeures { get; set; }
        public decimal Prix { get; set; }
        public DateTime DebutCours { get; set; }
        public DateTime FinCours { get; set; }
        public string Enseignant { get; set; } = null!;
    }
}
