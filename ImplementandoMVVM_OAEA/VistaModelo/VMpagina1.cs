using ImplementandoMVVM_OAEA.Vista;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ImplementandoMVVM_OAEA.VistaModelo
{
    public class VMpagina1 : BaseViewModel
    {

        #region VARIABLES
        string _N1;
        string _N2;
        string _R;
        string _TipoÚsuario;
        //string _Mensaje;
        #endregion
        #region CONTRUCTOR
        public VMpagina1(INavigation navigation)
        {
            Navigation = navigation;
        }

        #endregion
        #region OBJETOS
        public string TipoUsuario
        {
            get { return _TipoÚsuario; }
            set { SetValue(ref _TipoÚsuario,value); }
        }
        public string SeleccionarTipoUsuario
        {
            get { return _TipoÚsuario; }
            set { SetProperty (ref _TipoÚsuario, value);
                TipoUsuario = _TipoÚsuario; 
            }
        }




        public string N1
        {

            get { return _N1; }
            set { SetValue(ref _N1, value); }
        }
        public string N2
        {

            get { return _N1; }
            set { SetValue(ref _N2, value); }
        }
        public string R
        {
            get { return _R; }
            set { SetValue(ref _R, value);}
        }




      /*  public string Mensaje
        {
            get { return _Mensaje; }
            set { SetValue(ref _Mensaje, value); }
        }*/
        #endregion
        #region PROCESOS
        public async Task Navegarpagina2()
        {
            await Navigation.PushAsync(new Page2());
        }

        public void  Sumar()
        {
            double n1 = 0;
            double n2 = 0;
            double r = 0;


            n1 = Convert.ToDouble(N1);
            n2= Convert.ToDouble(N2);
            r = Convert.ToDouble(R);

            r = n1 + n2;
            R= r.ToString();

            //await DisplayAlert("Titulo", Mensaje, "Ok");

        }

      
        #endregion
        #region COMANDOS
        public ICommand PNavegarpagina2command => new Command(async () => await Navegarpagina2());

        public ICommand Suynarcommand => new Command(Sumar);
        #endregion
    }
}
