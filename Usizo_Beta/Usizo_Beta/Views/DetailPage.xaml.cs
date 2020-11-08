using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Usizo_Beta.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : ContentPage
    {
        public DetailPage(string activite)
        {
            InitializeComponent();
            BindingContext = new Usizo_Beta.ViewModels.DetailPageViewModel(activite);
        }
    }
}