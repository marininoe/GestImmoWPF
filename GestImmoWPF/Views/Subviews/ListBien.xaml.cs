using GestImmoWPF.Data.DAL;
using GestImmoWPF.Views.Forms;
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

namespace GestImmoWPF.Views.Subviews
{
    /// <summary>
    /// Logique d'interaction pour ListBien.xaml
    /// </summary>
    public partial class ListBien : Page, IObserver
    {
        private Frame frmDetailView;
        public ListBien(Frame frmDetailView)
        {
            InitializeComponent();
            this.frmDetailView = frmDetailView;
            this.refeshList();
        }


        private void refeshList()
        {
            ImmoContext ctx = ImmoContext.getInstace();
            this.ListBiensView.Items.Clear();

            foreach (Biens biens in ctx.Biens)
            {
                this.ListBiensView.Items.Add(biens.Nom);
            }

        }
        public void update()
        {
            this.refeshList();
        }
        

         private void affiche(object sender, SelectionChangedEventArgs e)
        {
            this.frmDetailView.Navigate(new AfficheBiensView());
        }

       
    }
}
