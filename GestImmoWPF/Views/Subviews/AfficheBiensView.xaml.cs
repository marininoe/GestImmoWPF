using GestImmoWPF.Data.DAL;
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
    /// Logique d'interaction pour AfficheBiensView.xaml
    /// </summary>
    public partial class AfficheBiensView : Page
    {
        public AfficheBiensView(int BienId)
        {
            InitializeComponent();
            ImmoContext ctx = ImmoContext.getInstace();

            Biens bien = ctx.Biens.Find(BienId);

            if (bien is Box) ;
            {
                this.FrmAfficheBien.navigate(new Bow)
            }



        }
    }
}
