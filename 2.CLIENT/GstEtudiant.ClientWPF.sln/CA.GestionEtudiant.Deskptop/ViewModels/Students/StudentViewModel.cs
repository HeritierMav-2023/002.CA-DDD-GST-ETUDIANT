using CA.GestionEtudiant.Deskptop.Models;
using CA.GestionEtudiant.Deskptop.ViewModels.Commons;


namespace CA.GestionEtudiant.Deskptop.ViewModels.Students
{
    public class StudentViewModel : ViewModelBase
    {
        //1- Properties
        private readonly Student _studentModel;

        //public int Id => _studentModel.Id;
        public string FirstName => _studentModel.FirstName;
        public string LastName => _studentModel.LastName;
        public string Email => _studentModel.Email;
        public string Cours => _studentModel.Cours;
        public string Entreprise => _studentModel.Entreprise;
        public int NbreHeure => _studentModel.NbreHeure;
        public decimal Prix => _studentModel.Prix;
        public DateTime DebutCours => _studentModel.DebutCours;
        public DateTime FinCours => _studentModel.FinCours;
        public string Enseignant => _studentModel.EnseignantFullName;

        //2- Constructor
        public StudentViewModel(Student studentModel)
        {
            _studentModel = studentModel;
        }

    }
}
