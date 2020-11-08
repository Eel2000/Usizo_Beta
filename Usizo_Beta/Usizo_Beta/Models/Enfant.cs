using System;

namespace Usizo_Beta.Models
{
    public class Enfant
    {
        public string UID { get; set; }
        public string Nom { get; set; }
        public string Postnom { get; set; }
        public string Prenom { get; set; }
        public string Pere { get; set; }
        public string Mere { get; set; }
        public DateTime Naissance { get; set; }
        public string Photo { get; set; }
        public Bracelet Bracelet { get; set; }
    }
}