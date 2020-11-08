using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Usizo_Beta.Models;
using Usizo_Beta.Services;
using Usizo_Beta.Views;
using Xamarin.Forms;

namespace Usizo_Beta.ViewModels
{
    public class ActiviteViewModel 
    {
        private readonly INavigation _navigation;

        public string UID { get; set; }
        public string Nom { get; set; }
        public DateTime Date { get; set; }
        public string Lieu { get; set; }
        public Encadreur Encadreur { get; set; }

        public string Title { get; set; }

        //private List<Activite> _listActivities;
        //public List<Activite> ListActivities
        //{
        //    get => _listActivities;
        //    set => _listActivities = value;
        //}

        public ICommand GoToDetails { get; set; }

        public ActiviteViewModel(INavigation navigation)
        {
            Title = "Activités";
            _navigation = navigation;
            //_listActivities = new List<Activite>();
            GoToDetails = new Command<string>(async (id) => await NavigateToDetails(id));
            //GetActivitiesList();
        }

        public ActiviteViewModel()
        {
            GoToDetails = new Command<string>(async (id) => await NavigateToDetails(id));
            Title = "Activités";
        }

        //public async void GetActivitiesList()
        //{
        //    var result = await ActiviteServices.ActiviteService.Activites();
        //    _listActivities = result.ToList();
        //}

        public async Task NavigateToDetails(string id)
        {
            //await Task.Delay(5000);
            var result = ActiviteServices.ActiviteService.Activites();

            try
            {
                await _navigation.PushModalAsync(new DetailPage(id));
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                throw;
            }
        }
    }
}
