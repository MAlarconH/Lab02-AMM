using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicoCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hola mundo");
            ////Declaració variablaes

            //int edad = 34;            
            //string nombre = "hugo";
            //decimal sueldo = 10000;
            //bool esNuevo = true;

            //int edad2 ;
            //string nombre2 ;
            //decimal sueldo2;
            //bool esNuevo2;

            //edad2 = 34;
            //nombre2 = "hugo2";
            //sueldo2 = 5000;


            ////Sentencias
            //if (edad>18)
            //{
            //    Console.WriteLine("Es Mayor Edad");
            //}
            //if (sueldo>2000)
            //{
            //    Console.WriteLine("Millonario");
            //}
            //else
            //{
            //    Console.WriteLine("Pobre");
            //}
            //switch (edad2)
            //{
            //    case 20:
            //        Console.WriteLine("Es Joven");
            //        break;
            //    case 30:
            //        Console.WriteLine("Es Adulto");
            //        break;
            //    default:
            //        break;
            //}

            //for (int i = 0; i < 20; i++)
            //{
            //    Console.WriteLine(nombre);
            //}

            ////Clases

            //Persona persona = new Persona();

            //persona.Nombres = "Miguel Augusto";
            //persona.Apellidos = "Alarcon Huaymacari";
            //persona.Edad = 25;

            //// Otra forma de declarar objeto

            //Persona persona1 = new Persona
            //{
            //    Nombres = "Nataly Carla",
            //    Apellidos = "Osorio Ramirez",
            //    Edad = 24
            //};

            //Console.WriteLine("Propiedades:");
            //Console.WriteLine("------------------------------------------------------");
            ////Propiedades:
            //Console.WriteLine(persona.Nombres);
            //Console.WriteLine(persona.Apellidos);
            //Console.WriteLine(persona.Edad);
            //Console.WriteLine("------------------------------------------------------");

            //Console.WriteLine("Funcion:");
            //Console.WriteLine("------------------------------------------------------");
            ////Funcion:
            //Console.WriteLine(persona.GetNombresCompletos());
            //Console.WriteLine("------------------------------------------------------");


            //Console.WriteLine("Procedimiento:");
            //Console.WriteLine("------------------------------------------------------");
            ////Procedimiento
            //persona.AsignarNombresCompletos();
            //string names = persona.NombresCompletos;
            //Console.WriteLine(names);
            //Console.WriteLine("------------------------------------------------------");

            //// La otra forma de declarar objetos
            //Console.WriteLine(persona1.Nombres);
            //Console.WriteLine(persona1.Apellidos);
            //Console.WriteLine(persona1.Edad);
            //Console.WriteLine(persona1.GetNombresCompletos());

            Console.WriteLine("------Hallar Area y Perimetro de un Rectangulo mendiante sus Vertices------");

            Rectangulo rectangulo = new Rectangulo();

            int x1 , y1, x2, y2, x3, y3, x4, y4;

            Console.WriteLine("Ingrese el par ordenado del primer vertice: ");
            Console.Write("x: ");
            x1 = int.Parse(Console.ReadLine());
            Console.Write("y: ");
            y1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el par ordenado del segundo vertice: ");
            Console.Write("x: ");
            x2 = int.Parse(Console.ReadLine());
            Console.Write("y: ");
            y2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el par ordenado del tercer vertice: ");
            Console.Write("x: ");
            x3 = int.Parse(Console.ReadLine());
            Console.Write("y: ");
            y3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el par ordenado del cuarto vertice: ");
            Console.Write("x: ");
            x4 = int.Parse(Console.ReadLine());
            Console.Write("y: ");
            y4 = int.Parse(Console.ReadLine());

            rectangulo.v1 = new Vertice { x = x1, y = y2};
            rectangulo.v2 = new Vertice { x = x2, y = y2 };
            rectangulo.v3 = new Vertice { x = x3, y = y3 };
            rectangulo.v4 = new Vertice { x = x4, y = y4 };

            Console.WriteLine("Calculando...");

            Console.Write("Area: ");
            Console.WriteLine(rectangulo.GetArea());
            Console.Write("Perimetro: ");
            Console.WriteLine(rectangulo.GetPerimetro());


            Console.Read();

        }
    }
}
