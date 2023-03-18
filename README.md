## Proyecto IMDB

De acuerdo a los ejemplos vistos en clase, implementa en c# la clase *Pelicula*  con los siguientes campos **publicos**:


### Pelicula
| campo                | tipo           |
| ---------------------|----------------|
| titulo               | String         |
| año                  | Int16          |
| país                 | String         |
| director             | String         |


1. Como primer paso crea solo la clase con los campos públicos e inicializalos en **Program.Main()** directamente.
2. Crea dos objetos película que representen a dos peliculas ganadoras de un Oscar. 
3. Imprime en la consola el título y año de las películas. 
Sube la primera versión a GitHub. Este código todavía no pasará ningúna prueba.
4. Ahora cambia los campos a **private**. Agrega los métodos necesarios para crear los objetos de la siguiente manera:

```csharp
class Program 
{
static void Main(){

    Pelicula p1 = new Pelicula();
    p1.SetTitulo("La La Land");
    p1.SetAño(2016);
    Console.WriteLine("{0}({1})", p1.GetTitulo(), p1.GetAño());

}
} 
```
Haz "push" de esta versión a GitHub. 
Se probará que funcionen los métodos de Set* y Get*.

5. Agrega dos constructores: *Pelicula()* y *Pelicula(string titulo, Int16 año )* y el método Imprime(). No modifiques el código de *Console.Writline()* incluido.

Actualiza la versión a GitHub.

## Lista de Películas 

Utilizando la bibliteca *System.Collections.Generic* crea una lista de 5 películas. Utilizando la lista genérica **List<Pelicula>**.
1. Crea la lista en *Main()* y agrega directamente las películas a la lista, por ejemplo para la clase **Persona** sería de esta manera (fragmento):

```csharp
List<Persona> personas = new List<Persona>();

persona.Add(new Persona ("pam"));
persona.Add(new Persona ("tom"));
persona.Add(new Persona ("jim"));

```
2. Utiliza un ciclo **foreach** para iterar por la lista e imprimir las películas. Este código es opcional, no se va a probar.

## Actores 
Agrega a tu clase **Pelicula** un campo privado **actores** de tipo **List<Actor>**. 
La clase Actor debe tener las siguientes propiedades: 
    
| Propiedad             | tipo           |
| ---------------------|----------------|
| Nombre               | String         |
| Año                  | Int16          |

Tus clases **Pelicula** y **Actor** deben permitir el siguiente funcionamiento:

```csharp
class Program 
{
static void Main(){

    Pelicula p1 = new Pelicula("La La Land", 2016);
    p1.AgregaActor(new Actor("Ryan Gosling", 1980));
    p1.AgregaActor(new Actor("Emma Stone", 1988));

    p1.ImprimeActores();

}
} 
```
Debes agregar propiedades (get y set) a la clase **Actor** así como su constructor.

Tu código debe pasar las pruebas incluidas en el proyecto **PeliculaTest**.
