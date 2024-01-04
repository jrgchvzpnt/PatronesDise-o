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

El patrón Singleton asegura que solo haya una instancia de la clase `Singleton` y proporciona un acceso global a esa instancia. Esto se logra a través del uso de un método estático `Instance`.

### Ejemplo de Aplicación

- **Aplicación de un Registro de Configuración Global:** Utilizando un patrón Singleton para mantener una única instancia del registro de configuración en toda la aplicación.

## Factory Method

El patrón Factory Method es un patrón de diseño creacional que define una interfaz para crear un objeto en una superclase, pero permite a las subclases alterar el tipo de objetos que se crearán.

### Ejemplo de Aplicación

- **Creación de Documentos en un Editor de Texto:** Permitiendo que las subclases del creador decidan el tipo específico de documento que se creará.

## Abstract Factory

El patrón Abstract Factory proporciona una interfaz para crear familias de objetos relacionados o dependientes sin especificar sus clases concretas.

### Ejemplo de Aplicación

- **Construcción de Interfaz de Usuario en Múltiples Plataformas:** Permitiendo la creación de elementos de interfaz de usuario específicos para diferentes sistemas operativos.

## Ejecución

Para ejecutar estos ejemplos, simplemente clona este repositorio y abre cada proyecto de consola C# en tu entorno de desarrollo favorito.

```bash
git clone https://github.com/jrgchvzpnt/PatronesDise-o.git
