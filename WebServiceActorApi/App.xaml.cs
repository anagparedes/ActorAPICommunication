using System;
using WebServiceActorApi.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WebServiceActorApi
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MenuTabPage();
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
