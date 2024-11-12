using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_doblemente_enlazada
{
    public class ListaDobleEnlazada
    {
        private NodoDoble cabeza;

        public ListaDobleEnlazada()
        {
            cabeza = null;
        }

        public void Agregar(int valor)
        {
            NodoDoble nuevo = new NodoDoble(valor);
            if (cabeza == null)
            {
                cabeza = nuevo;
            }
            else
            {
                NodoDoble actual = cabeza;
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }
                actual.Siguiente = nuevo;
                nuevo.Anterior = actual;
            }
        }

        public void Eliminar(int valor)
        {
            NodoDoble actual = cabeza;
            while (actual != null)
            {
                if (actual.Valor == valor)
                {
                    if (actual.Anterior != null)
                        actual.Anterior.Siguiente = actual.Siguiente;
                    else
                        cabeza = actual.Siguiente;

                    if (actual.Siguiente != null)
                        actual.Siguiente.Anterior = actual.Anterior;
                    break;
                }
                actual = actual.Siguiente;
            }
        }

        public bool Buscar(int valor)
        {
            NodoDoble actual = cabeza;
            while (actual != null)
            {
                if (actual.Valor == valor) return true;
                actual = actual.Siguiente;
            }
            return false;
        }

        public void Modificar(int valorAntiguo, int valorNuevo)
        {
            NodoDoble actual = cabeza;
            while (actual != null)
            {
                if (actual.Valor == valorAntiguo)
                {
                    actual.Valor = valorNuevo;
                    break;
                }
                actual = actual.Siguiente;
            }
        }

        public void ImprimirHaciaAdelante()
        {
            NodoDoble actual = cabeza;
            while (actual != null)
            {
                Console.Write(actual.Valor + " ");
                actual = actual.Siguiente;
            }
            Console.WriteLine();
        }

        public void ImprimirHaciaAtras()
        {
            NodoDoble actual = cabeza;
            while (actual?.Siguiente != null)
            {
                actual = actual.Siguiente;
            }
            while (actual != null)
            {
                Console.Write(actual.Valor + " ");
                actual = actual.Anterior;
            }
            Console.WriteLine();
        }

    }
}
