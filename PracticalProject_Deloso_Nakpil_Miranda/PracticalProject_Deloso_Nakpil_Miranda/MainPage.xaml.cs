using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PracticalProject_Deloso_Nakpil_Miranda
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void AnimalPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new View.ShowAnimalPage());

        }
    }
}
