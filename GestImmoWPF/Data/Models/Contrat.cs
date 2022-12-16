using System;
using System.Collections.Generic;
using System.Runtime;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace WPF_TP.Data.Models
{
    public class Contrat
    {
        private int loyer;
        private DateTime dateDebut;
        private DateTime dateFin;
        private List<Locataire> listLocataire = new List<Locataire>();
        private Biens unbien;
        
        public Contrat(int loyer, DateTime dateDebut, DateTime dateFin, List<Locataire> listLocataires,Biens unbien)
        {
            this.Loyer = loyer;
            this.DateDebut = dateDebut;
            this.DateFin = dateFin;
            this.ListLocataire = listLocataires;
           
        }
        public Contrat()
        {

        }
        public int ContratId { get; set; }
        public int Loyer { get => loyer; set => loyer = value; }
        public DateTime DateDebut { get => dateDebut; set => dateDebut = value; }
        public DateTime DateFin { get => dateFin; set => dateFin = value; }
        internal List<Locataire> ListLocataire { get => listLocataire; set => listLocataire = value; }


        public static DateTime dateBailEnCours = new DateTime(2000, 1, 1);

        public void afficher()
        {
            Console.WriteLine("===Bail===");
            Console.WriteLine("Loyer : " + Loyer + " €");
            Console.WriteLine("Date début : " + DateDebut);
            Console.WriteLine("Date fin : " + DateFin);
            foreach (Locataire locataire in ListLocataire)
            {
                Console.WriteLine("\n===Locataire===");
                Console.WriteLine("\n" + locataire.Nom + locataire.Prenom + " - " + locataire.Age + " - " + locataire.Profession);
            }

            


            // List<Locataire> listLocataire.Add(jean, paul, 50, prof);

        }
    }
}