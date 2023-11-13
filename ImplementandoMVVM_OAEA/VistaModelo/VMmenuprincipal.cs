using ImplementandoMVVM_OAEA.Vista;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ImplementandoMVVM_OAEA.VistaModelo
{
   
     internal class VMmenuprincipal : BaseViewModel
     {

        #region VARIABLES
        string _Texto;

        public List<MenuPrincipal> listausuarios { get; set; }


        public void Mostrausruario()
        {
            listausuarios = new List<MenuPrincipal>
            {
                new MenuPrincipal
                {
                    Pagina="Entry, datapickey, picker, label, navegacion ",
                    Icono="https://i.ibb.co/fFqRbY6/avatar.png"
                },
                   new MenuPrincipal
                {
                    Pagina="CollectionView sin enlace a base de datos",
                    Icono="https://i.ibb.co/1Qqm8NY/avatar-1.png"
                },
                   new MenuPrincipal
                {
                    Pagina="Crud Poekmon",
                    Icono="https://i.ibb.co/jzgyRCr/dratini.png"
                },

            };
        }
            
        #endregion
        #region CONTRUCTOR
        public VMmenuprincipal(INavigation navigation)
        {
            Navigation = navigation;
            Mostrausruario();
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

        public async Task Volver()
        {
            await Navigation.PopAsync();
        }

        public void ProcesoSimple()
        {

        }

        public async Task Navegar(MenuPrincipal parametros)
        {
            string pagina;
            pagina = parametros.Pagina;
            if (pagina.Contains("Entry, datepicker")) 
            {
                await Navigation.PushAsync(new Pagina1());
            }
            if (pagina.Contains("CollectionView sin enlace")) 
            {
                await Navigation.PushAsync(new Page2());
            }
            if (pagina.Contains("Crud pokemon"))
            {
                await Navigation.PushAsync(new CrudPokemon());

            }

        }
        #endregion
        #region COMANDOS

       // public ICommand Volvercommand => new Command(async () => await Volver());

        // public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);


        public ICommand Navegarcommand => new Command<MenuPrincipal>(async (p) => await Navegar(p));
        #endregion
     }
}

