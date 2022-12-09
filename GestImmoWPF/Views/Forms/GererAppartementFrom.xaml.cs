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
using WPF_Exo.Data.Models;
using WPF_TP.Data.Models;

namespace GestImmoWPF.Views.Forms
{
    /// <summary>
    /// Logique d'interaction pour GererAppartementFrom.xaml
    /// </summary>
    public partial class GererAppartementFrom : Page
    {
        public List<IObserver> Observers { get; set; }
        public GererAppartementFrom()
        {
            InitializeComponent();
            this.Observers = new List<IObserver>();
        }


        private void btnAjouter_Click(object sender, RoutedEventArgs e)
        {
            string nom = txtApNom.Text;
            int valeur = int.Parse(txtApValeur.Text);
            string adresse = txtApAdresse.Text;
            int surface = int.Parse(txtApSurface.Text);
            int NbPiece = int.Parse(txtApNbPiece.Text);
            int NbChambre = int.Parse(txtApNbChambre.Text);
            int cave = int.Parse(txtApCave.Text);
            int parking = int.Parse(txtApParking.Text);
            int etage = int.Parse(txtApEtage.Text);
            bool ascenseur = false;
            bool chauffage = false;


            Appartement appartement = new Appartement(nom, adresse, valeur, surface, NbChambre, NbChambre, cave, parking, etage, ascenseur, chauffage) ;
                 ImmoContext ctx = new ImmoContext();
                 ctx.Biens.Add(appartement);
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

