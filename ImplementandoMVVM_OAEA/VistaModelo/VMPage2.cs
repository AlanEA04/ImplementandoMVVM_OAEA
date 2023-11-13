using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using ImplementandoMVVM_OAEA.VistaModelo;

namespace ImplementandoMVVM_OAEA.VistaModelo
{
    class VMPage2 : BaseViewModel
    {
        #region VARIABLES
        string _Texto;

        public List<Musuarios> listausuarios { get; set; }
       

        public void Mostrausruario()
        {
            listausuarios = new List<Musuarios>
            {
                new Musuarios
                {
                    Nombre="Alan",
                    Imagen="https://i.ibb.co/QcykXKc/carro-deportivo.png"
                },
                   new Musuarios
                {
                    Nombre="Omar",
                    Imagen="https://i.ibb.co/KWxFW7k/pizza.png"
                },
                   new Musuarios
                {
                    Nombre="JOHNNY BRAVO",
                    Imagen="https://i.ibb.co/vxtTvnJ/ejercicio.png"
                },

            };
        }

        #endregion
        #region CONTRUCTOR
        public VMPage2(INavigation navigation)
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

        public async Task Alerta(Musuarios parametros)
        {
            await DisplayAlert("Titulo", parametros.Nombre, "Ok");
        }
        #endregion
        #region COMANDOS

      public ICommand Volvercommand => new Command(async () => await Volver());

       //public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);


        public ICommand Alertacommand => new Command<Musuarios>(async (p) => await Alerta(p));
        #endregion
    }
}
