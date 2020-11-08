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
    public class ActiviteServices : IActiviteServices
    {
        FirebaseClient Firebase;

        private static ActiviteServices _activiteServices;
        public static ActiviteServices ActiviteService
        {
            get
            {
                if (_activiteServices == null)
                    return _activiteServices = new ActiviteServices();
                return _activiteServices;
            }
        }

        public ActiviteServices()
        {
            Firebase = new FirebaseClient("https://suivi-encadrement.firebaseio.com/");
        }

        public async Task<List<Activite>> Activites()
        {
            try
            {
                var activites = (await Firebase
              .Child("activite")
              .OnceAsync<Activite>())
              .Select(item => new Activite
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
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }

            
        }

        public ObservableCollection<Activite> ListActivites()
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Activite>> IActiviteServices.Activites()
        {
            throw new NotImplementedException();
        }

        public async Task<Activite> ActiviteDetails(string UID)
        {
            try
            {
                var activite = (await Firebase
                .Child("activite")
                .OnceAsync<Activite>())
                .Where(a => a.Object.UID == UID)
                .Select(item => new Activite()
                {
                    Nom = item.Object.Nom,
                    Date = item.Object.Date,
                    Encadreur = item.Object.Encadreur,
                    Enfants = item.Object.Enfants,
                    Lieu = item.Object.Lieu
                }).FirstOrDefault();

                var it = new Activite()
                {
                    Nom = activite.Nom,
                    Date = activite.Date,
                    Encadreur = activite.Encadreur,
                    Enfants = activite.Enfants,
                    Lieu = activite.Lieu
                };

                return it;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }
    }
}
