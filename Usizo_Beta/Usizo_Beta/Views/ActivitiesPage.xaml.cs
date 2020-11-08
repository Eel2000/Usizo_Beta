using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using Usizo_Beta.Services;
using Usizo_Beta.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Usizo_Beta.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Activities : ContentPage
    {
        public Activities()
        {
            InitializeComponent();
            BindingContext = new ActiviteViewModel(Navigation);
            GetList();
        }

        public async void GetList()
        {
            try
            {
                var result = await ActiviteServices.ActiviteService.Activites();
                listActivites.ItemsSource = result;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message, "Error");
            }
        }
    }
}