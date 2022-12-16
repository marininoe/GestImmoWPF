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

namespace GestImmoWPF.Views.Subviews
{
    /// <summary>
    /// Logique d'interaction pour BienView.xaml
    /// </summary>
    public partial class BienView : Page
    {
        public BienView()
        {
            InitializeComponent();

            ListBien bienview = new ListBien(this.AjtBiens);
            this.listBiens.Navigate(bienview);
            this.AjtBiens.Navigate(new GererBienFrom(bienview));
        }

        private void AjtBiens_Navigated(object sender, NavigationEventArgs e)
        {
           
        }

        private void listBiens_Navigated(object sender, NavigationEventArgs e)
        {
           
        }

        private void Frame_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void Frame_Navigated_1(object sender, NavigationEventArgs e)
        {
            
        }
    }
}

