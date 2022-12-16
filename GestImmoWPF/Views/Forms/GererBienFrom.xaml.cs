using GestImmoWPF.Views.Tools;
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
        
        private IObserver obs;
        public GererBienFrom(IObserver obs)
        {
            InitializeComponent();
            this.obs = obs;

            
        }
   
        private void ComboBox_TypeBien_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComboBox_TypeBien.SelectedIndex == 0)
            {
                GererBoxFrom gererBoxFrom = new GererBoxFrom();
                gererBoxFrom.Observers.Add(this.obs);
                this.Frame_Ajouter_Bien.Navigate((gererBoxFrom));
            }
            else if (ComboBox_TypeBien.SelectedIndex == 1)
            {
                GererMaisonFrom gererMaisonFrom = new GererMaisonFrom();
                gererMaisonFrom.Observers.Add(this.obs);
                this.Frame_Ajouter_Bien.Navigate((gererMaisonFrom));
            }
            else if (ComboBox_TypeBien.SelectedIndex == 2)
            {
                GererAppartementFrom gererAppartementFrom = new GererAppartementFrom();
                gererAppartementFrom.Observers.Add(this.obs);
                this.Frame_Ajouter_Bien.Navigate((gererAppartementFrom));
            }
        }

    }
}
