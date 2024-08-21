using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
     public interface IColleccion
     {
        public bool Estavacia();
        object Extraer();

        object Primero();

        bool Añadir(object obj);

     }

}
