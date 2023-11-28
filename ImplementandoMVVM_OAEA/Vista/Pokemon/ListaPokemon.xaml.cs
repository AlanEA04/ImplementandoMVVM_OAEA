using ImplementandoMVVM_OAEA.VistaModelo.VMpokemon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ImplementandoMVVM_OAEA.Vista.Pokemon;

namespace ImplementandoMVVM_OAEA.Vista.Pokemon
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListaPokemon : ContentPage
    {
        public ListaPokemon()
        {
            InitializeComponent();

            BindingContext = new VMlistapokemoncs(Navigation);
        }
    }
}