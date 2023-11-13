using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImplementandoMVVM_OAEA.VistaModelo;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ImplementandoMVVM_OAEA.Vista
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CrudPokemon : ContentPage
    {
		public CrudPokemon ()
		{
			InitializeComponent ();
          //  BindingContext = new VMPokemonCrud(Navigation);
           
        }


		/*public async Task Navegar(MenuPrincipal parametros)
		{

			string pagina;
			pagina = parametros.Pagina;
			if (pagina.Contains("Entry, datepicker")) ;
			{
				await Navigation.PushAsync(new Pagina1());
			}
			if (pagina.Contains("CollectionView sin enlace")) ;
			{
				await Navigation.PushAsync(new Page2());
			}
			if(pagina.Contains("Crud pokemon") )
			{
				await Navigation.PushAsync(new CrudPokemon());

			}
		}*/

    }
}