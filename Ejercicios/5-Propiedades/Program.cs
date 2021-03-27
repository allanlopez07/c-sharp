using System;

namespace Propiedades
{
    class Program
    {
        static void Main(string[] args)
        {

            Alumno a = new Alumno();
            a.PrimerNombre = "Juan";
            a.SegundoNombre = "Perez";

            Alumno b = new Alumno();
            a.Id = 2;
            a.PrimerNombre = "Maria";
            a.SegundoNombre = "Martinez";
            
            Alumno c = new Alumno(3);
            a.PrimerNombre = "Pedro";

            Alumno d = new Alumno("Juan", "Jimenez");
            
            Console.WriteLine(a.Id);
            Console.WriteLine(b.Id);
            Console.WriteLine(c.Id);
            Console.WriteLine(d.PrimerNombre + " " + d.SegundoNombre);

            
        }
    }
}
