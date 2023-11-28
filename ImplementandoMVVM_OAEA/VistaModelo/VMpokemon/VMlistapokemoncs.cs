using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using ImplementandoMVVM_OAEA.Vista.Pokemon;


namespace ImplementandoMVVM_OAEA.VistaModelo.VMpokemon
{
    public class VMlistapokemoncs : BaseViewModel
    {
       
            #region VARIABLES
            string _Texto;
            #endregion
            #region CONTRUCTOR
            public VMlistapokemoncs(INavigation navigation)
            {
                Navigation = navigation;
            }

            #endregion
            #region OBJETOS
            public string Texto
            {
                get { return _Texto; }
                set { SetValue(ref _Texto, value); }
            }
            #endregion
            #region PROCESOS

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
