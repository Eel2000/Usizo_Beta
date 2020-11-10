using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Usizo_Beta.Models;
using Usizo_Beta.Services;
using Xamarin.Forms;

namespace Usizo_Beta.ViewModels
{
    public class DetailPageViewModel : Activite
    {
        private readonly INavigation _navigation;

        public string Title { get; set; }
        public string ActiviteID { get; set; }

        public DetailPageViewModel(INavigation navigation)
        {
            _navigation = navigation;
        }

        public DetailPageViewModel(Activite activite)
        {
            //GetDetails(activite.UID);
            Nom = activite.Nom;
            UID = activite.UID;
            Lieu = activite.Lieu;
            Encadreur = activite.Encadreur;
            Date = activite.Date;
            Enfants = activite.Enfants;

        }

        //public async void GetDetails(string id)
        //{
        //    var result = await ActiviteServices.ActiviteService.ActiviteDetails(id);
        //    Nom = result.Nom;
        //    UID = result.UID;

        //    Title = Nom;
        //}

        //private async Task<Activite> GetActivite(string id)
        //{
        //    var result = await ActiviteServices.ActiviteService.ActiviteDetails(id);
        //    return result;
        //}
    }
}
