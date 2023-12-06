using ImplementandoMVVM_OAEA.Modelo;
using ImplementandoMVVM_OAEA.VistaModelo.VMpokemon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ImplementandoMVVM_OAEA.Vista.Pokemon
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Modificar : ContentPage
    {
        public Modificar(Mpokemon pokemon)
        {
            InitializeComponent();
            BindingContext = new VMdetallesPokemon(pokemon, Navigation);
        }
    }
}