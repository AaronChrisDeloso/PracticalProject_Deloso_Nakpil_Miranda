using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PracticalProject_Deloso_Nakpil_Miranda
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
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
