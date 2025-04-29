using System.ComponentModel;


namespace CA.GestionEtudiant.Deskptop.ViewModels.Commons
{
    /// <summary>
    /// Base class for all ViewModels in the application.
    /// </summary>
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public virtual void Dispose() { }
    }
}
