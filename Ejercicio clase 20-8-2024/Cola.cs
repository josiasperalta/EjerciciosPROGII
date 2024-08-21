using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class Cola : IColleccion
    {

        private List<object> lista;
        public Cola()
        { 
            lista = new List<object>(); 

        }

        public bool Estavacia()
        {
            return lista.Count == 0;  
        }

        public object Extraer()
        {
            if (Estavacia())
            {
                throw new InvalidOperationException("No se puede extraer de una cola vacia");          
            }
            object elemento = lista[0];
            lista.RemoveAt(0);
            return elemento;

        }

        public object Primero()
        {
            if (Estavacia())
            {
                throw new InvalidOperationException("La cola esta vacia");
            }
            return lista[0];

        }

        public bool Añadir(object obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj), "No se puede añadir un objeto nulo a la cola");
            }
            lista.Add(obj);
            return true;    
        }

    }
}
