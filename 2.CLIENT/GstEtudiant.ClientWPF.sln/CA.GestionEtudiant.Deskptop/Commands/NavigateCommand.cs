

using CA.GestionEtudiant.Deskptop.Services.Navigations;

namespace CA.GestionEtudiant.Deskptop.Commands
{
    /// <summary>
    /// Command to navigate to a different view or page.
    /// </summary>
    public class NavigateCommand : CommandBase
    {
        private readonly INavigationService _navigationService;

        public NavigateCommand(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public override void Execute(object? parameter)
        {
            _navigationService.Navigate();
        }
    }
}
