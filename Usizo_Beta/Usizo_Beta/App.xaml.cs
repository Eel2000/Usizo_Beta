using System;
using Usizo_Beta.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Usizo_Beta
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Activities());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
