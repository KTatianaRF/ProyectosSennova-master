using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectosSennova
{
    public class Proyecto
    {
        #region Atributos

        #endregion
        #region Propiedades
        public string Nombre { get; set; }
        public double Codigo { get; set; }
        public string Area { get; set; }
        public int Duracion { get; set; }

        public List<Proyecto> proyectos = new List<Proyecto>();
        #endregion

        #region Constructores
        //ctor+tab+tab
        public Proyecto(string nombre, double codigo, string area, int duracion)
        {
            Nombre = nombre;
            Codigo = codigo;
            Area = area;
            Duracion = duracion;
        }
        public Proyecto()
        {
                
        }
        public Proyecto(string area, int duracion)
        {
            Area = area;
            Duracion = duracion;
        }

        #endregion

        #region Métodos
        public void IngresarProyecto()
        {

            var res = "y";
            while (res == "y")
            {
                Proyecto myProyecto = new Proyecto();

                Console.WriteLine("Ingrese el Nombre del proyecto");
                myProyecto.Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese el código");
                myProyecto.Codigo = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el Area del proyecto");
                myProyecto.Area = Console.ReadLine();
                Console.WriteLine("Ingrese la duración del proyecto");
                var dura = Console.ReadLine();
                myProyecto.Duracion = int.Parse(dura);

                proyectos.Add(myProyecto);

                Console.WriteLine("Desea ingresar otro proyecto?  y/n");

                res = Console.ReadLine();
            }
           
           
        }
        public void ImprimirProyecto()
        {
            foreach (var item in proyectos)
            {
                Console.WriteLine($"El nombre del proyecto es: {item.Nombre}");
                Console.WriteLine($"El codigo del proyecto es: {item.Codigo}");
                Console.WriteLine($"El área es: {item.Area}");
                Console.WriteLine($"La duración es:{item.Duracion}");
            }

            

        }


        #endregion



    }


}
