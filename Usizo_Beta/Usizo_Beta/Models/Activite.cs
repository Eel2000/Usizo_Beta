using System;
using System.Collections.Generic;
using System.Text;

namespace Usizo_Beta.Models
{
    class Activite
    {
        public string UID { get; set; }
        public string Nom { get; set; }
        public DateTime Date { get; set; }
        public string Lieu { get; set; }
        public Encadreur Encadreur { get; set; }
        public IEnumerable<Enfant> Enfants { get; set; }
    }
}
