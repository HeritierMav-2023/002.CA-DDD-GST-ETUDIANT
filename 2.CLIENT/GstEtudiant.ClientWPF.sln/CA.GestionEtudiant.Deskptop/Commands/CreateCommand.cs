
using CA.GestionEtudiant.Deskptop.ViewModels.Commons;
using System.Windows.Input;

namespace CA.GestionEtudiant.Deskptop.Commands
{
    /// <summary>
    /// Delegate for creating a command.
    /// </summary>
    /// <typeparam name="TViewModel"></typeparam>
    /// <param name="viewModel"></param>
    /// <returns></returns>
    public delegate ICommand CreateCommand<TViewModel>(TViewModel viewModel) where TViewModel : ViewModelBase;
}
