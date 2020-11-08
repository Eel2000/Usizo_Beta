using System;
using System.Collections.Generic;
using System.Text;
using Usizo_Beta.Models;
using Xamarin.Forms;

namespace Usizo_Beta.ViewModels
{
    public class ActiviteViewModel 
    {
        public string UID { get; set; }
        public string Nom { get; set; }
        public DateTime Date { get; set; }
        public string Lieu { get; set; }
        public Encadreur Encadreur { get; set; }

        private List<Activite> _listActivities;
        public List<Activite> ListActivities
        {
            get => _listActivities;
            set => _listActivities = value;
        }

        public ActiviteViewModel()
        {
            _listActivities = new List<Activite>();
        }

        public async void GetActivitiesList()
        {
            var result =
        }
    }
}
