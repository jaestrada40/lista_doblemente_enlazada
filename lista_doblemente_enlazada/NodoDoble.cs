using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_doblemente_enlazada
{
    public class NodoDoble
    {
        public int Valor;
        public NodoDoble Anterior;
        public NodoDoble Siguiente;

        public NodoDoble(int valor)
        {
            Valor = valor;
            Anterior = null;
            Siguiente = null;
        }
    }
}
