using System;
using System.Collections.Generic;
using System.Text;
using WPF_TP.Data.Models;

namespace WPF_TP.Data.Models
{
    class Box : Biens
    {
        public Box(string nom, string adresse, int valeur, int surface)
            : base( nom,  adresse,  valeur,  surface)
        {

        }
        public int BoxId { get; set; }
        public override void afficher()
        {
            base.afficher();
        }
    }
}
