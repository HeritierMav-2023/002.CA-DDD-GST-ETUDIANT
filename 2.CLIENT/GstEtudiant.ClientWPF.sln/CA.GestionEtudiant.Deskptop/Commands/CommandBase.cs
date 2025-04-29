using System.Windows.Input;

namespace CA.GestionEtudiant.Deskptop.Commands
{
    /// <summary>
    /// /// Base class for commands in the MVVM pattern.
    /// </summary>
    public abstract class CommandBase : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public virtual bool CanExecute(object? parameter)
        {
            return true;
        }

        public abstract void Execute(object? parameter);

        protected void OnCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, new EventArgs());
        }
    }
}
