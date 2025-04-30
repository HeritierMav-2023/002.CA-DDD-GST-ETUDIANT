using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CA.GestionEtudiant.Deskptop.Views.Students
{
    /// <summary>
    /// Logique d'interaction pour StudentListingView.xaml
    /// </summary>
    public partial class StudentListingView : UserControl
    {
        public StudentListingView()
        {
            InitializeComponent();
           
        }
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            var parentWindow = Window.GetWindow(this); // Obtient la fenêtre parent
            if (parentWindow != null)
            {
                this.MaxWidth = parentWindow.ActualWidth * 0.8; // 80% de la largeur de la fenêtre
            }
        }

        private void btnOpenDialogue_Click(object sender, RoutedEventArgs e)
        {
            DialogOverlay.Visibility = Visibility.Visible;
        }

        private void CloseDialogButton_Click(object sender, RoutedEventArgs e)
        {
            DialogOverlay.Visibility = Visibility.Collapsed;
        }
    }
}
