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

namespace GestImmoWPF.Views.Subviews
{
    /// <summary>
    /// Logique d'interaction pour ListBien.xaml
    /// </summary>
    public partial class ListBien : Page, IObserver
    {
        ImmoContext ctx = ImmoContext.getInstace();
        public ListBien()
        {
            InitializeComponent();
            ListBiensView.Items.Clear();

            foreach (Biens bien in ctx.Biens)
            {
                ListBiensView.Items.Add(bien.Nom);
            }
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


        private void ListBiensView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

    
    }
}
