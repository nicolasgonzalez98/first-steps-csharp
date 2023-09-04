using System;

namespace POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Persona[] personas = new Persona[5];

            for (int i = 0; i < personas.Length; i++)
            {
                personas[i] = new Persona();

                Console.WriteLine("Inserte nombre: ");
                personas[i].nombre = Console.ReadLine();

                Console.WriteLine("Inserte apellido: ");
                personas[i].apellido = Console.ReadLine();

                Console.WriteLine("Inserte edad: ");
                personas[i].edad = int.Parse(Console.ReadLine());

                Console.Write("Teléfono: ");
                personas[i].telefono = Console.ReadLine();

            }
            */

            /*
                Implementar en C# un programa que maneje un array de clases para almacenar las
                fechas de cumplea˜nos de n cantidad de amigos. Los datos a almacenar sobre cada amigo
                son nombre, d´ıa, mes y a˜no. El programa debe indicarnos cu´antos de nuestros amigos
                cumplen a˜nos en un mes determinado introducidos por teclado.

             */

            Console.WriteLine("Inserte cantidad de amigos: ");
            int cant_amigos = int.Parse(Console.ReadLine());
            string nombre, apellido;
            int dia, mes, anio;

            Amigo[] amigos = new Amigo[cant_amigos];

            for (int i = 0; i < amigos.Length; i++)
            {
                Console.WriteLine("Inserte nombre de amigo: ");
                nombre = Console.ReadLine();

                Console.WriteLine("Inserte apellido de amigo: ");
                apellido = Console.ReadLine();

                Console.WriteLine("Inserte dia de nacimiento de amigo: ");
                dia = int.Parse(Console.ReadLine());

                Console.WriteLine("Inserte mes de nacimiento de amigo: ");
                mes = int.Parse(Console.ReadLine());


                Console.WriteLine("Inserte año de nacimiento de amigo: ");
                anio = int.Parse(Console.ReadLine());

                amigos[i] = new Amigo(nombre, apellido, dia, mes, anio);
            }

            Console.WriteLine("Ingrese mes de cumpleaños a buscar: ");
            int mes_a_buscar = int.Parse(Console.ReadLine());
            int cantAmigos = 0;

            foreach (var amigo in amigos)
            {
                if (amigo.mes == mes_a_buscar)
                {
                    cantAmigos++;
                }
            }

            Console.WriteLine("Hay {0} que cumplen el mes {1}", cantAmigos, mes_a_buscar);

        }
    }
}
