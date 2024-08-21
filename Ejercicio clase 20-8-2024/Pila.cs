using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejercicios
{
    public class Pila : IColleccion
    {
        private const int CapacidadInicial = 10;
        private object[] array;
        private int contador;

        public Pila()
        {
            array = new object[CapacidadInicial];
            contador = 0;
        }
        public bool Estavacia()
        {
            return contador == 0;
        }
        public object Extraer()
        {
            if (Estavacia())
            {
                throw new InvalidOperationException("No se puede extraer de una pila vacía");
            }
            object elemento = array[contador - 1];
            array[contador - 1] = null;
            contador--;
            return elemento;
        }
        public object Primero()
        {
            if (Estavacia())
            {
                throw new InvalidOperationException("La pila esta vacia");
            }
            return array[contador - 1];
        }

        public bool Añadir(object obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj), "No se puede añadir un objeto nulo a la pila");
            }
            if (contador == array.Length)
            {
                AumentarCapacidad();
            }
            array[contador] = obj;
            contador++;
            return true;    
        }
         private void AumentarCapacidad() 
         {
            int nuevaCapacidad = array.Length * 2;
            object[] nuevoArray = new object[nuevaCapacidad];
            System.Array.Copy(array, 0, nuevoArray, 0, array.Length);
            array = nuevoArray;
         }


    }
  
    
}
