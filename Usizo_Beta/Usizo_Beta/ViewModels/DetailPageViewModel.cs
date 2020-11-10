using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
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
        public string NombreEnfant { get; set; }

        public ICommand AddChildrenCommand { get; set; }

        public DetailPageViewModel(INavigation navigation)
        {
            _navigation = navigation;
        }

        public DetailPageViewModel(Activite activite)
        {
            Nom = activite.Nom;
            UID = activite.UID;
            Lieu = activite.Lieu;
            Encadreur = activite.Encadreur;
            Date = activite.Date;
            Enfants = activite.Enfants;

            CountActivityChilds(Enfants);

            AddChildrenCommand = new Command(async () => await AddChildren());
        }

        public void CountActivityChilds(IEnumerable<Enfant> enfants)
        {

            if (enfants == null)
            {
                NombreEnfant = "0";
            }
            else
            {
                var nombre = enfants.ToList();
                NombreEnfant = nombre.Count.ToString();
            }
        }

        private async Task AddChildren()
        {
            await App.Current.MainPage.DisplayAlert("Information", "Vous avez ajouter un enfant a cet activité.", "ok");
        }

    }
}
