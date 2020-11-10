using System;
using System.Collections.Generic;
using System.Text;
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

        public DetailPageViewModel(string activite)
        {
            GetDetails(activite);
        }

        public async void GetDetails(string id)
        {
            var result = await ActiviteServices.ActiviteService.ActiviteDetails(id);
            Nom = result.Nom;
            UID = result.UID;

            Title = Nom;
        }
    }
}
