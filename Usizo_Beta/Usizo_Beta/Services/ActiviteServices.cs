using Firebase.Database;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Usizo_Beta.Models;

namespace Usizo_Beta.Services
{
    public class ActiviteServices :IActiviteServices
    {
        FirebaseClient Firebase;

        public ActiviteServices()
        {
            Firebase = new FirebaseClient("https://suivi-encadrement.firebaseio.com/");
        }

        public async Task<IEnumerable<Activite>> Activites()
        {
            var activites = (await Firebase
              .Child("activite")
              .OnceAsync<Activite>()).Select(item => new Activite
              {
                  UID = item.Object.UID,
                  Nom = item.Object.Nom,
                  Date = item.Object.Date,
                  Lieu = item.Object.Lieu,
                  Encadreur = item.Object.Encadreur
              }).ToList();

            Debug.WriteLine(activites.Count());

            if (activites != null)
            {
                return activites;
            }
            else
            {
                return null;
            }
        }

        public ObservableCollection<Activite> ListActivites()
        {
            throw new NotImplementedException();
        }
    }
}
