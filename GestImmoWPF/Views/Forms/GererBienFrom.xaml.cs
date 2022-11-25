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

namespace GestImmoWPF.Views.Forms
{
    /// <summary>
    /// Logique d'interaction pour GererBienFrom.xaml
    /// </summary>
    public partial class GererBienFrom : Page
    {
        public GererBienFrom()
        {
            InitializeComponent();
        }

        private void ComboBox_TypeBien_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComboBox_TypeBien.SelectedIndex == 0)
            {
                this.Frame_Ajouter_Bien.Navigate(new GererBoxFrom());
            }
            else if (ComboBox_TypeBien.SelectedIndex == 1)
            {
                this.Frame_Ajouter_Bien.Navigate(new GererMaisonFrom());
            }
            else if (ComboBox_TypeBien.SelectedIndex == 2)
            {
                this.Frame_Ajouter_Bien.Navigate(new GererAppartementFrom());
            }
        }
    }
}
