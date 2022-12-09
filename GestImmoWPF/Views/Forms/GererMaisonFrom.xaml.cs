using GestImmoWPF.Data.DAL;
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
using WPF_TP.Data.Models;

namespace GestImmoWPF.Views.Forms
{
    /// <summary>
    /// Logique d'interaction pour GererMaisonFrom.xaml
    /// </summary>
    public partial class GererMaisonFrom : Page
    {
        public List<IObserver> Observers { get; set; }
        public GererMaisonFrom()
        {
            InitializeComponent();
            this.Observers = new List<IObserver>();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnAjouter_Click(object sender, RoutedEventArgs e)
        {
            string nom = txtMsNom.Text;
            int valeur = int.Parse(txtMsValeur.Text);
            string adresse = txtMsAdresse.Text;
            int surface = int.Parse(txtMsSurface.Text);
            int NbPiece = int.Parse(txtMsNbPiece.Text);
            int NbChambre = int.Parse(txtMsNbChambre.Text);
            int cave = int.Parse(txtMsCave.Text);
            int parking = int.Parse(txtMsParking.Text);

            Maison maison = new Maison(nom, adresse, valeur, surface, NbChambre,NbChambre,cave,parking);
            ImmoContext ctx = new ImmoContext();
            ctx.Biens.Add(maison);
            ctx.SaveChanges();
            this.notifyObservers();
        }

        void notifyObservers()
        {
            foreach (IObserver obs in Observers)
            {
                obs.update();
            }
        }
    }
}
