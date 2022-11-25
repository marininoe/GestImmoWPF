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

namespace GestImmoWPF.Views.Subviews
{
    /// <summary>
    /// Logique d'interaction pour NavigationView.xaml
    /// </summary>
    public partial class NavigationView : Page
    {
        public NavigationView()
        {
            InitializeComponent();
            this.MainFrame.Navigate(new HomeView());
        }

        private void Button_Acceuil_Click(object sender, RoutedEventArgs e)
        {
            this.MainFrame.Navigate(new HomeView());
        }

        private void Button_Bien_Click(object sender, RoutedEventArgs e)
        {
            this.MainFrame.Navigate(new BienView());
        }

        private void Prets_Click(object sender, RoutedEventArgs e)
        {
            this.MainFrame.Navigate(new PretView());
        }

        private void Prestataires_Click(object sender, RoutedEventArgs e)
        {
            this.MainFrame.Navigate(new PrestataireView());
        }
    }
}
