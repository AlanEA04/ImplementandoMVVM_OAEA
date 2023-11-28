using System;
using System.Collections.Generic;
using System.Text;
using Firebase.Database;
namespace ImplementandoMVVM_OAEA.Conexion
{
    public class Conexionn
    {
        public static FirebaseClient firebase = new FirebaseClient("https://mvvmoaea-default-rtdb.firebaseio.com/ ");
    }
}
 