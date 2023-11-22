using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ImplementandoMVVM_OAEA.VistaModelo;

namespace ImplementandoMVVM_OAEA.Vista
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menuprincipal : ContentPage
    {
        public Menuprincipal()
        {
            InitializeComponent();
            BindingContext = new VMmenuprincipal(Navigation);
        }
    }
}