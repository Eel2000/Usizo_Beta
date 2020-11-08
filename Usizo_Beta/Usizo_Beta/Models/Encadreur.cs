using System;

namespace Usizo_Beta.Models
{
    public class Encadreur
    {
        public string UID { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public DateTime Naissance { get; set; }
        public string Adresse { get; set; }
        public string Photo { get; set; }
        public string Mdp { get; set; }
        public int Role { get; set; }
    }
}