﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WPF_TP.Data.Models
{
    public class Contrat
    {
        private int loyer;
        private string dateDebut;
        private string dateFin;
        private List<Locataire> listLocataire = new List<Locataire>();
        private Biens unbien;

        public Contrat(int loyer, string dateDebut, string dateFin, List<Locataire> listLocataires)
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
        public string DateDebut { get => dateDebut; set => dateDebut = value; }
        public string DateFin { get => dateFin; set => dateFin = value; }
        internal List<Locataire> ListLocataire { get => listLocataire; set => listLocataire = value; }
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
        }
    }
}