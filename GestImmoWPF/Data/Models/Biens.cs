using System;
using System.Collections.Generic;
using System.Text;

namespace WPF_TP.Data.Models
{
    public class Biens
    {
        private string nom;
        private string adresse;
        private int valeur;
        private int surface;
        private List<Contrat> listContrat = new List<Contrat>();
        private Pret? pret;
        private Intervention? intervention;

        public Biens(string nom, string adresse, int valeur, int surface)
        {
            this.nom = nom;
            this.adresse = adresse;
            this.valeur = valeur;
            this.surface = surface;
        }

        public Biens(string nom, string adresse, int valeur, int surface, List<Contrat> listContrat, Pret pret, Intervention intervention)
        {
            this.nom = nom;
            this.adresse = adresse;
            this.valeur = valeur;
            this.surface = surface;

            ListContrat = listContrat;
            Pret = pret;
            Intervention = intervention;
        }
        public int BiensId { get; set; }
        public string Nom { get => nom; set => nom = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public int Valeur { get => valeur; set => valeur = value; }
        public int Surface { get => surface; set => surface = value; }
        internal List<Contrat> ListContrat { get => listContrat; set => listContrat = value; }
        internal Pret Pret { get => pret; set => pret = value; }
        internal Intervention Intervention { get => intervention; set => intervention = value; }
       

        public int benefNet()
        {
            int loyer = ListContrat[listContrat.Count - 1].Loyer;
            int mensualite = Pret.Mensualite;

            int benef = mensualite - loyer;
            return benef;
        }

        public virtual void afficher()
        {
            Console.WriteLine("Adresse : " + Adresse);
            Console.WriteLine("Valeur : " + Valeur);
            Console.WriteLine("Surface : " + Surface);
            Console.WriteLine("Benefice Net : " + benefNet());
        }



       


        public int calculerRentabiliteNetMensuel()
        {
            int montantPret = 0;
            int loyer = 0;

            if(this.pret != null)
            {
                montantPret = this.Pret.Mensualite;
            }
            if(this.ListContrat.Count > 0)
            {
                foreach(Contrat contrat in this.listContrat)
                {
                    if (contrat.DateFin == Contrat.dateBailEnCours)
                    {
                        loyer = contrat.Loyer;
                        break;
                    }
                }
            }
            return loyer - montantPret;
        }
    }
}
