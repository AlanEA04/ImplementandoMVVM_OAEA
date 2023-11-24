using ImplementandoMVVM_OAEA.Vista;
using ImplementandoMVVM_OAEA.Vista.Pokemon;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ImplementandoMVVM_OAEA
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Registarpokemon());

            
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
