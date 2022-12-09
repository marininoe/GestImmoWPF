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
    /// Logique d'interaction pour GererBoxFrom.xaml
    /// </summary>
    public partial class GererBoxFrom : Page, IObservable
    {

        public List<IObserver> Observers { get; set; }

        public GererBoxFrom()
        {
            
            InitializeComponent();
            this.Observers = new List<IObserver>();
        }

        

        private void btnAjouter_Click(object sender, RoutedEventArgs e)
        {
            string nom = txtBxNom.Text;
            int valeur = int.Parse(txtBxValeur.Text);
            string adresse = txtBxAdresse.Text;
            int surface = int.Parse(txtBxSurface.Text);

            Box box = new Box(nom, adresse, valeur, surface);
            ImmoContext ctx = new ImmoContext();
            ctx.Biens.Add(box);
            ctx.SaveChanges();
            this.notifyObservers();
        }
        void notifyObservers()
        {
            foreach(IObserver obs in Observers)
            {
                obs.update();
            }
        }
    }
}
