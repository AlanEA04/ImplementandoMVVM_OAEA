﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ImplementandoMVVM_OAEA.VistaModelo
{
    internal class VMPokemonCrud : BaseViewModel
    {

        #region VARIABLES
        string _Texto;
        #endregion
        #region CONTRUCTOR
        public VMPokemonCrud(INavigation navigation)
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

        public async Task ProcesoAsyncrono()
        {

        }

        public void ProcesoSimple()
        {


        }
        #endregion
        #region COMANDOS
        public ICommand ProcesoAsyncommand => new Command(async () => await ProcesoAsyncrono());

        public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        #endregion
    }
}