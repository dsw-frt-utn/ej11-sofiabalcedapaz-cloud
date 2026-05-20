namespace Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

//Crear un campo que represente una lista de alumnos (List<>)
//Incluir un método para agregar alumnos a la lista
//Incluir un método para retornar la lista
//Incluir un método para buscar un alumno por nombre
//Incluir un método para eliminar un alumno (debe recibir un alumno)
//Incluir un método para eliminar un alumno en una determinada posición de la lista
public class CasoList
{
    private List<Alumno> _alumno = new List<Alumno>();

    public void AgregarAlumno(Alumno alumno)
    {
        _alumno.Add(alumno);
    }

    public List<Alumno> GetLista()
    {
        return _alumno;
    }

    public Alumno? BuscarAlumnoPorNombre(string nombre)
    {
        return _alumno.FirstOrDefault(a => a.Nombre == nombre);
    }

    public void EliminarAlumno(Alumno alumno)
    {
        _alumno.Remove(alumno);
    }

    public void EliminarAlumnoPorPosicion(int posicion)
    {
        if (posicion >= 0 && posicion < _alumno.Count)
        {
            _alumno.RemoveAt(posicion);
        }
    }
}
