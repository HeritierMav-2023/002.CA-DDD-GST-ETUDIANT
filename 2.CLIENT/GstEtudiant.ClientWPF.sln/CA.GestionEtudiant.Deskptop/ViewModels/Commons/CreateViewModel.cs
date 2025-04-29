
namespace CA.GestionEtudiant.Deskptop.ViewModels.Commons
{
    /// <summary>
    /// /// Delegate for creating ViewModels.
    /// </summary>
    /// <typeparam name="TViewModel"></typeparam>
    /// <returns></returns>
    public delegate TViewModel CreateViewModel<TViewModel>() where TViewModel : ViewModelBase;

    public delegate TViewModel CreateViewModel<TParameter, TViewModel>(TParameter parameter) where TViewModel : ViewModelBase;
}
