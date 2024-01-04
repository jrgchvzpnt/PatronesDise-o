# Patrones de Diseño en C# - Ejemplos Prácticos

Este repositorio contiene ejemplos prácticos de implementaciones en C# de tres patrones de diseño comunes: Singleton, Factory Method y Abstract Factory. Cada patrón se presenta en una aplicación de consola separada dentro del proyecto.

## Contenido

1. [**Singleton**](#singleton)
    - Garantiza que una clase tenga una única instancia y proporciona un punto de acceso global a ella.

2. [**Factory Method**](#factory-method)
    - Define una interfaz para crear un objeto, pero permite que las subclases alteren el tipo de objetos que se crearán.

3. [**Abstract Factory**](#abstract-factory)
    - Proporciona una interfaz para crear familias de objetos relacionados o dependientes sin especificar sus clases concretas.

## Singleton

La implementación del Singleton asegura que solo haya una instancia de la clase `Singleton` y proporciona un acceso global a esa instancia. Esto se logra a través del uso de un método estático `Instance`.

```csharp
Singleton instance1 = Singleton.Instance;
Singleton instance2 = Singleton.Instance;

// Verificar si las instancias son iguales (debido al patrón Singleton).
Console.WriteLine("¿Las instancias son iguales? " + (instance1 == instance2));

// Llamada a métodos de la instancia 1 y 2.
instance1.PrintMessage();
instance2.PrintMessage();




## Factory Method

El patrón Factory Method es un patrón de diseño creacional que define una interfaz para crear un objeto en una superclase, pero permite a las subclases alterar el tipo de objetos que se crearán. Este patrón proporciona una interfaz para crear una instancia de una clase, pero deja la elección del tipo de clase a las subclases, creando así una familia de clases.

### Ejemplo en C#

```csharp
// Creación de un CreadorConcretoA que implementa el Factory Method para crear ProductoA.
Creador creadorA = new CreadorConcretoA();
Producto productoA = creadorA.FactoryMethod();
productoA.Mostrar();

// Creación de un CreadorConcretoB que implementa el Factory Method para crear ProductoB.
Creador creadorB = new CreadorConcretoB();
Producto productoB = creadorB.FactoryMethod();
productoB.Mostrar();


## Abstract Factory

FabricaAbstracta fabrica1 = new FabricaConcreta1();
ProductoA productoA1 = fabrica1.CrearProductoA();
ProductoB productoB1 = fabrica1.CrearProductoB();

productoA1.Mostrar();
productoB1.Mostrar();

FabricaAbstracta fabrica2 = new FabricaConcreta2();
ProductoA productoA2 = fabrica2.CrearProductoA();
ProductoB productoB2 = fabrica2.CrearProductoB();

productoA2.Mostrar();
productoB2.Mostrar();


Ejecución
git clone https://github.com/jrgchvzpnt/PatronesDise-o.git

