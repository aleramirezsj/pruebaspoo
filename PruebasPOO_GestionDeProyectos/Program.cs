using System;

public class Program
{
	public static void Main()
	{
		Console.WriteLine("Hello World");
		var alumnoMauri = new Alumno(1, "Mauri");
		Console.WriteLine("El alumno iniciado es " + alumnoMauri.MostrarNombre());
		Console.WriteLine("La información del alumno ingresado es= " + alumnoMauri.MostrarInformación());
	}
}

public class Alumno
{
	private int _id { get; set; }
	private string _nombre { get; set; }

	public Alumno(int id, string nombre)
	{
		_id = id;
		_nombre = nombre;
	}
	public string MostrarNombre()
	{
		return _nombre;
	}
	public string MostrarInformación()
	{
		string info = $"id:{this._id} nombre{this._nombre}";
		return info;
	}
}
