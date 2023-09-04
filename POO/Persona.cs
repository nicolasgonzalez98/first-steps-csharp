using System;

class Persona
{
    public string nombre { get; set; }
    public string apellido { get; set; }
    public int edad { get; set; }
    public string telefono { get; set; }
    

    public Persona(string nombre, string apellido, int edad, string telefono)
    {
        this.nombre = nombre;
        this.apellido = apellido;
        this.edad = edad;
        this.telefono = telefono;
    }


}

class Amigo
{
    public string nombre { get ; set; }
    public string apellido { get; set;}

    public int dia { get; set;}
    
    public int mes { get ; set;}

    public int anio { get; set;}

    public Amigo(string nombre, string apellido, int dia, int mes, int anio)
    {
        this.nombre = nombre;
        this.apellido = apellido;
        this.dia = dia;
        this.mes = mes;
        this.anio = anio;
    }


}