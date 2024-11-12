using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_doblemente_enlazada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejemplo de Lista Doble Enlazada:");

            // Crear la lista doblemente enlazada
            ListaDobleEnlazada listaDoble = new ListaDobleEnlazada();

            // Agregar elementos a la lista
            Console.WriteLine("Agregando elementos...");
            listaDoble.Agregar(5);
            listaDoble.Agregar(10);
            listaDoble.Agregar(15);
            listaDoble.Agregar(20);

            // Imprimir lista hacia adelante
            Console.WriteLine("Lista hacia adelante después de agregar elementos:");
            listaDoble.ImprimirHaciaAdelante(); // Salida esperada: 5 10 15 20

            // Imprimir lista hacia atrás
            Console.WriteLine("Lista hacia atrás después de agregar elementos:");
            listaDoble.ImprimirHaciaAtras(); // Salida esperada: 20 15 10 5

            // Buscar un elemento
            Console.WriteLine("Buscando el elemento 15 en la lista...");
            bool encontrado = listaDoble.Buscar(15);
            Console.WriteLine(encontrado ? "Elemento 15 encontrado" : "Elemento 15 no encontrado"); 

            // Modificar un elemento
            Console.WriteLine("Modificando el elemento 10 a 12...");
            listaDoble.Modificar(10, 12);

            // Imprimir lista después de modificación
            Console.WriteLine("Lista hacia adelante después de modificación:");
            listaDoble.ImprimirHaciaAdelante(); 

            // Eliminar un elemento
            Console.WriteLine("Eliminando el elemento 15...");
            listaDoble.Eliminar(15);

            // Imprimir lista hacia adelante después de eliminación
            Console.WriteLine("Lista hacia adelante después de eliminación:");
            listaDoble.ImprimirHaciaAdelante(); 

            // Imprimir lista hacia atrás después de eliminación
            Console.WriteLine("Lista hacia atrás después de eliminación:");
            listaDoble.ImprimirHaciaAtras(); 

            Console.ReadKey();
        }
    }
}
