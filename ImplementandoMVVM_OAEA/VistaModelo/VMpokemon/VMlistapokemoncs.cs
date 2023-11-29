using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using ImplementandoMVVM_OAEA.Vista.Pokemon;
using ImplementandoMVVM_OAEA.Datos;
using ImplementandoMVVM_OAEA.Modelo;
using System.Collections.ObjectModel;

namespace ImplementandoMVVM_OAEA.VistaModelo.VMpokemon
{
    public class VMlistapokemoncs : BaseViewModel
    {
       
            #region VARIABLES
           // string _Texto;
             ObservableCollection<Mpokemon> _ListaPokemon;
            #endregion
            #region CONTRUCTOR
            public VMlistapokemoncs(INavigation navigation)
            {
                Navigation = navigation;
                Mostrarpokemon();
            }

            #endregion
            #region OBJETOS
            public ObservableCollection<Mpokemon> ListaPokemon
            {
                get { return _ListaPokemon; }
                set { SetValue(ref _ListaPokemon, value);
                OnpropertyChanged();
            }
            }
            #endregion
            #region PROCESOS
            
            public async Task Mostrarpokemon()
            {
            var funcion = new Dpokemon();
              ListaPokemon = await funcion.MostrarPokemon();
            
            }


            public async Task Iraregistro()
            {
                await Navigation.PushAsync(new Registarpokemon());

            }

             public void ProcesoSimple()
            {


            }
            #endregion
            #region COMANDOS
            public ICommand Iraregistrocommand => new Command(async () => await Iraregistro());

            public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
            #endregion
        
    }
}
