﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImplementandoMVVM_OAEA.VistaModelo.VMpokemon;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ImplementandoMVVM_OAEA.Vista.Pokemon
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registarpokemon : ContentPage
    {
        public Registarpokemon()
        {
            InitializeComponent();
            BindingContext =  new VMresgistropokemon(Navigation);
        }
    }
}