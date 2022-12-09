
using GestImmoWPF.Data.DAL;
using GestImmoWPF.Views.Subviews;
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

namespace GestImmoWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
            
        {
            // ligne à ajouter pour la compatibilité des dates
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

            InitializeComponent();
            this.Content = new NavigationView();

            ImmoContext context = ImmoContext.getInstace();

            foreach(Biens bien in context.Biens)
            {
               // bien.ListContrat.Add(new Contrat(200, new DateTime(2019, 10, 06), new DateTime(2022, 11, 25), List < Locataire > listLocataire);
            }
        }

    }
}
