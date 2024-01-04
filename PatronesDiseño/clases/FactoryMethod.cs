using System;

namespace PatronesDiseño.clases
{
    // Esta clase parece ser solo un contenedor, sin funcionalidad específica en el ejemplo.
    public class FactoryMethod
    {
    }

    // Clase abstracta que define la interfaz común para todos los productos creados por el Factory Method.
    public abstract class Producto
    {
        // Método abstracto que debe ser implementado por las clases concretas de productos.
        public abstract void Mostrar();
    }

    // Implementación concreta de Producto para el tipo específico "Producto Concreto A".
    public class ProductoConcretoA : Producto
    {
        // Implementación del método Mostrar para imprimir un mensaje específico.
        public override void Mostrar()
        {
            Console.WriteLine("Producto Concreto A");
        }
    }

    // Implementación concreta de Producto para el tipo específico "Producto Concreto B".
    public class ProductoConcretoB : Producto
    {
        // Implementación del método Mostrar para imprimir un mensaje específico.
        public override void Mostrar()
        {
            Console.WriteLine("Producto Concreto B");
        }
    }

    // Clase abstracta que declara el Factory Method para la creación de productos.
    public abstract class Creador
    {
        // Método abstracto Factory Method que debe ser implementado por las subclases concretas.
        public abstract Producto FactoryMethod();
    }

    // Implementación concreta de Creador que crea instancias de ProductoConcretoA.
    public class CreadorConcretoA : Creador
    {
        // Implementación del Factory Method para crear y devolver ProductoConcretoA.
        public override Producto FactoryMethod()
        {
            return new ProductoConcretoA();
        }
    }

    // Implementación concreta de Creador que crea instancias de ProductoConcretoB.
    public class CreadorConcretoB : Creador
    {
        // Implementación del Factory Method para crear y devolver ProductoConcretoB.
        public override Producto FactoryMethod()
        {
            return new ProductoConcretoB();
        }
    }
}
