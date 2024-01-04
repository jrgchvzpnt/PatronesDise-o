using PatronesDiseño.clases;
using System;

namespace PatronesDiseño
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region "Singleton: Garantiza que una clase tenga una única instancia y proporciona un punto de acceso global a ella."

            // Creación de dos instancias de la clase Singleton utilizando el método estático Instance.
            Singleton instance1 = Singleton.Instance;
            Singleton instance2 = Singleton.Instance;

            // Verificación de si las instancias son iguales (debido al patrón Singleton).
            Console.WriteLine("¿Las instancias son iguales? " + (instance1 == instance2));

            // Llamada al método PrintMessage de la instancia 1.
            instance1.PrintMessage();

            // Llamada al método PrintMessage de la instancia 2.
            instance2.PrintMessage();

            #endregion

            #region Factory Method

            // Creación de un CreadorConcretoA que implementa el Factory Method para crear ProductoA.
            Creador creadorA = new CreadorConcretoA();
            Producto productoA = creadorA.FactoryMethod();
            productoA.Mostrar();

            // Creación de un CreadorConcretoB que implementa el Factory Method para crear ProductoB.
            Creador creadorB = new CreadorConcretoB();
            Producto productoB = creadorB.FactoryMethod();
            productoB.Mostrar();

            #endregion

            #region Abstract Factory:

            // Creación de una fábrica concreta que implementa la Abstract Factory para crear productos A1 y B1.
            FabricaAbstracta fabrica1 = new FabricaConcreta1();
            ProductoA productoA1 = fabrica1.CrearProductoA();
            ProductoB productoB1 = fabrica1.CrearProductoB();

            // Mostrar los productos A1 y B1.
            productoA1.Mostrar();
            productoB1.Mostrar();

            // Creación de otra fábrica concreta que implementa la Abstract Factory para crear productos A2 y B2.
            FabricaAbstracta fabrica2 = new FabricaConcreta2();
            ProductoA productoA2 = fabrica2.CrearProductoA();
            ProductoB productoB2 = fabrica2.CrearProductoB();

            // Mostrar los productos A2 y B2.
            productoA2.Mostrar();
            productoB2.Mostrar();

            // Esperar la entrada del usuario antes de cerrar la aplicación.
            Console.ReadLine();

            #endregion
        }
    }
}
