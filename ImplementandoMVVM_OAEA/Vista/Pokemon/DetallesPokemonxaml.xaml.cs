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
    public partial class DetallesPokemonxaml : ContentPage
    {
        public DetallesPokemonxaml(Mpokemon parametros)
        {
            InitializeComponent();
            BindingContext = new VMdetallesPokemon(Navigation, parametros);


        }
    }
}