using System;

namespace PatronesDiseño.clases
{
    // Clase que parece ser solo un contenedor, sin funcionalidad específica en el ejemplo.
    public class AbstractFactory
    {
    }

    // Clase abstracta que define la interfaz común para todos los productos A creados por la Abstract Factory.
    public abstract class ProductoA
    {
        // Método abstracto que debe ser implementado por las clases concretas de productos A.
        public abstract void Mostrar();
    }

    // Implementación concreta de ProductoA para el tipo específico "Producto A1".
    public class ProductoA1 : ProductoA
    {
        // Implementación del método Mostrar para imprimir un mensaje específico.
        public override void Mostrar()
        {
            Console.WriteLine("Producto A1");
        }
    }

    // Implementación concreta de ProductoA para el tipo específico "Producto A2".
    public class ProductoA2 : ProductoA
    {
        // Implementación del método Mostrar para imprimir un mensaje específico.
        public override void Mostrar()
        {
            Console.WriteLine("Producto A2");
        }
    }

    // Clase abstracta que define la interfaz común para todos los productos B creados por la Abstract Factory.
    public abstract class ProductoB
    {
        // Método abstracto que debe ser implementado por las clases concretas de productos B.
        public abstract void Mostrar();
    }

    // Implementación concreta de ProductoB para el tipo específico "Producto B1".
    public class ProductoB1 : ProductoB
    {
        // Implementación del método Mostrar para imprimir un mensaje específico.
        public override void Mostrar()
        {
            Console.WriteLine("Producto B1");
        }
    }

    // Implementación concreta de ProductoB para el tipo específico "Producto B2".
    public class ProductoB2 : ProductoB
    {
        // Implementación del método Mostrar para imprimir un mensaje específico.
        public override void Mostrar()
        {
            Console.WriteLine("Producto B2");
        }
    }

    // Clase abstracta que declara el método abstracto para la creación de productos A y B.
    public abstract class FabricaAbstracta
    {
        public abstract ProductoA CrearProductoA();
        public abstract ProductoB CrearProductoB();
    }

    // Implementación concreta de la Abstract Factory que crea productos A1 y B1.
    public class FabricaConcreta1 : FabricaAbstracta
    {
        // Implementación del método para crear y devolver ProductoA1.
        public override ProductoA CrearProductoA()
        {
            return new ProductoA1();
        }

        // Implementación del método para crear y devolver ProductoB1.
        public override ProductoB CrearProductoB()
        {
            return new ProductoB1();
        }
    }

    // Implementación concreta de la Abstract Factory que crea productos A2 y B2.
    public class FabricaConcreta2 : FabricaAbstracta
    {
        // Implementación del método para crear y devolver ProductoA2.
        public override ProductoA CrearProductoA()
        {
            return new ProductoA2();
        }

        // Implementación del método para crear y devolver ProductoB2.
        public override ProductoB CrearProductoB()
        {
            return new ProductoB2();
        }
    }
}
