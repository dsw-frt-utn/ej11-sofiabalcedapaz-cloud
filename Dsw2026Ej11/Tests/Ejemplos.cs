namespace Dsw2026Ej11.Tests;
using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        var caso = new CasoList();
        var a1 = new Alumno(1, "Carlos Lopez", 8.5);
        var a2 = new Alumno(2, "Maria Perez", 9.0);
        var a3 = new Alumno(3, "Joaquin Garcia Fernandez", 7.5);

        caso.AgregarAlumno(a1);
        caso.AgregarAlumno(a2);
        caso.AgregarAlumno(a3);

        Console.WriteLine("\t\t\tLista de alumnos");
        caso.GetLista().ForEach(Console.WriteLine);

        Console.WriteLine("\nBuscar 'Joaquin Garcia Fernandez'");
        var encontrado = caso.BuscarAlumnoPorNombre("Joaquin García Fernandez");
        Console.WriteLine(encontrado != null ? encontrado.ToString() : "No existe");

        Console.WriteLine("\nBuscar 'Juan'");
        var noEncontrado = caso.BuscarAlumnoPorNombre("Juan");
        Console.WriteLine(noEncontrado != null ? noEncontrado.ToString() : "No existe");

        Console.WriteLine("\nEliminar Maria Perez");
        caso.EliminarAlumno(a2);
        caso.GetLista().ForEach(Console.WriteLine);

        Console.WriteLine("\nEliminar el primer elemento de la lista");
        caso.EliminarAlumnoPorPosicion(0);
        caso.GetLista().ForEach(Console.WriteLine);
    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        var caso = new CasoDictionary();
        caso.AgregarAlumno(1, new Alumno(1, "Carlos Lopez", 8.5));
        caso.AgregarAlumno(2, new Alumno(2, "Maria Perez", 9.0));
        caso.AgregarAlumno(3, new Alumno(3, "Joaquin Garcia Fernandez", 7.5));

        Console.WriteLine("\t\t\tDiccionario de alumnos");
        foreach (var par in caso.GetDiccionario())
            Console.WriteLine($"Legajo {par.Key}: {par.Value}");

        Console.WriteLine("\nBuscar por legajo 3");
        var encontrado = caso.BuscarAlumnoPorLegajo(3);
        Console.WriteLine(encontrado != null ? encontrado.ToString() : "No existe");

        Console.WriteLine("\nBuscar por legajo 999");
        var noEncontrado = caso.BuscarAlumnoPorLegajo(999);
        Console.WriteLine(noEncontrado != null ? noEncontrado.ToString() : "No existe");

        Console.WriteLine("\nEliminar legajo 1");
        caso.EliminarAlumnoPorLegajo(1);
        foreach (var par in caso.GetDiccionario())
            Console.WriteLine($"Legajo {par.Key}: {par.Value}");
    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
        var caso = new CasoLinq();

        Console.WriteLine($"Primero: {caso.GetPrimero()}");
        Console.WriteLine($"Ultimo: {caso.GetUltimo()}");
        Console.WriteLine($"Total Precios: {caso.GetTotalPrecios():C}");
        Console.WriteLine($"Promedio Precios: {caso.GetPromedioPrecios():C}");

        Console.WriteLine("\nLibros con id mayor a 15");
        caso.GetListById().ForEach(l => Console.WriteLine(l.Titulo));

        Console.WriteLine("\nTítulos y precios");
        caso.GetLibros().ForEach(Console.WriteLine);

        Console.WriteLine($"\nMayor precio: {caso.GetMayorPrecio()}");
        Console.WriteLine($"\nMenor precio: {caso.GetMenorPrecio()}");

        Console.WriteLine("\nLibros con precio mayor al promedio");
        caso.GetMayorPromedio().ForEach(l => Console.WriteLine(l.Titulo));

        Console.WriteLine("\nLibros ordenados por título descendente");
        caso.GetOrdenadosPorTituloDescendente().ForEach(l => Console.WriteLine(l.Titulo));
    }
}
