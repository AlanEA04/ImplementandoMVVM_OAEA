using System;
using System.Collections.Generic;
using System.Text;
using ImplementandoMVVM_OAEA.Modelo;
using ImplementandoMVVM_OAEA.Conexion;
using Firebase.Database.Query;
using System.Threading.Tasks;
using System.Linq;

namespace ImplementandoMVVM_OAEA.Datos
{
     public class Dpokemon
    {//Alopez3535
        public async Task Insertarpokemon(Mpokemon parametros)
        {
            await Conexionn.firebase
                  .Child("Pokemon")
                  .PostAsync(new Mpokemon()
                  {
                      ColorFondo= parametros.ColorFondo,
                      Colorpoder= parametros.Colorpoder,  
                      Icono= parametros.Icono,
                      Nombre= parametros.Nombre, 
                      NroOrden= parametros.NroOrden,
                      Poder= parametros.Poder,
                  }
                  );
        }
        public async Task<List<Mpokemon>> MostrarPokemon()
        {

            return(await Conexionn.firebase
                .Child("Pokemon")
                .OnceAsync<Mpokemon>())
                .Select(item => new Mpokemon
                { 
                    IdPokemon=item.Key,
                    Nombre=item.Object.Nombre,
                    ColorFondo=item.Object.ColorFondo,
                   Colorpoder=item.Object.Colorpoder,
                    Icono=item.Object.Icono,
                    NroOrden=item.Object.NroOrden,
                    Poder=item.Object.Poder,

                }).ToList();
        }
    }
}
