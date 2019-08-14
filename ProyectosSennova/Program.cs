using System;

namespace ProyectosSennova
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;
            int puntaje = 0;
            Proyecto miProyecto = new Proyecto();
            Proyecto miProyecto2 = new Proyecto();
            Proyecto miProyecto3 = new Proyecto();
            //Proyecto miProyecto4 = new Proyecto("Realidad aumentada", 12540, "Sistemas", 10);
            Proyecto miProyecto5 = new Proyecto("Talento humano", 5);
            Proyecto miProyecto6 = new Proyecto();

            //miProyecto3.IngresarProyecto();
            //miProyecto3.ImprimirProyecto();
            //miProyecto4.ImprimirProyecto();
            miProyecto5.ImprimirProyecto();
            miProyecto6.IngresarProyecto();
            miProyecto6.ImprimirProyecto();

            //miProyecto.Area = "Sistemas";
            //miProyecto.Codigo = 12000;
            //miProyecto.Duracion = 13;
            //miProyecto.Nombre = "Desarrollo internet de las cosas IOT";
            //miProyecto2.Area = "Redes";
            //miProyecto2.Codigo = 13000;
            //miProyecto2.Duracion = 14;
            //miProyecto2.Nombre = "Desarrollo Arduino";
            //Console.WriteLine($" Area: {miProyecto.Area}");
            //Console.WriteLine($" Codigo: {miProyecto.Codigo}");
            //Console.WriteLine($" Duracion: {miProyecto.Duracion}");
            //Console.WriteLine($" Nombre: {miProyecto.Nombre}");
            //Console.WriteLine($" Area: {miProyecto2.Area}");
            //Console.WriteLine($" Codigo: {miProyecto2.Codigo}");
            //Console.WriteLine($" Duracion: {miProyecto2.Duracion}");
            //Console.WriteLine($" Nombre: {miProyecto2.Nombre}");
            Console.ReadLine();



        }
    }
}
