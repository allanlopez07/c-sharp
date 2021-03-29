using System;

namespace Animales
{
    class Program
    {
        static void Main(string[] args)
        {
          Mapache p = new Mapache();
          
          Console.WriteLine("----------------------");
          Console.WriteLine("         MENU         ");
          Console.WriteLine("----------------------");
          Console.WriteLine("1.   Mamiferos");
          Console.WriteLine("2.   Aves y Peces  ");
          Console.WriteLine("0.   Salir  ");
          Console.WriteLine(" ");
          Console.WriteLine("Ingresar un Numero:   ");
          string Opcion = Console.ReadLine();
        
          
          while (true)
          {

          switch (Opcion)
          {
            case "1":
                Console.WriteLine(" ");
                Console.WriteLine("Mamiferos");
                Console.WriteLine(" ");
                Console.WriteLine("1. Mapaches ");
                Console.WriteLine("2. Cabritos");
                Console.WriteLine("3. Monos");
                Console.WriteLine(" ");
                Console.WriteLine("Ingrese un Numero:   ");
            string Op1 = Console.ReadLine();
            
            switch (Op1)
            {
                case "1":
            p.Nombre = "Mochi";
            p.Patas = 4;
            p.Domestico = false;
            p.Comer();
            p.Caminar();
            p.Chillar();
            p.Tamano();
                Console.WriteLine(" ");
                Console.WriteLine("El Nombre del Mapache es: " + p.Nombre);
                Console.WriteLine("Tiene : " + p.Patas + "Patas");
                Console.WriteLine("Es Domestico : " + p.Domestico);
              break;
                 

            case "2":
            Cabrito g = new Cabrito();
            g.Nombre = "Sabo";
            g.Patas = 4;
            g.Comer();
            g.Chozpar();
            g.Domestico = true; 

                Console.WriteLine(" ");  
                Console.WriteLine("El Nombre del Cabrito es: " + g.Nombre);
                Console.WriteLine("Tiene : " + g.Patas + "Patas");
                Console.WriteLine("Es Domestico : " + g.Domestico);
         
          
            break;

            case "3":
            Mono m = new Mono();
            m.Nombre = "Lucy";
            m.Extremidades = 4;
            m.Domestico = false;
            m.Comer();
                Console.WriteLine(" ");
                Console.WriteLine("El Nombre del Mono es: " + m.Nombre);
                Console.WriteLine("Tiene : " + m.Extremidades + "Extremidades");
                Console.WriteLine("Es Domestico : " + m.Domestico);
          
            break;

                default:
                Console.WriteLine("Ingrese una Opcion valida");
                break;
            }
            
        break;
        
//Aves y Peces----------------------------------------------------------------------------------------
           

        case "2":
            Console.WriteLine(" ");
            Console.WriteLine("*****Aves y Peces******");
            Console.WriteLine(" ");
            Console.WriteLine("1. Aves");
            Console.WriteLine("2. Peces");
            
        string Opc2 = Console.ReadLine();

            switch (Opc2)
            {
            case "1":
                Console.WriteLine("1. Aguila");
                Console.WriteLine("2. Loro");
                Console.WriteLine(" ");
                Console.WriteLine("Ingrese un numero:  ");
            
            string Opc3 =  Console.ReadLine();

            switch (Opc3)

            {
            case "1":
            Aguila a = new Aguila();
            a.Nombreave = "Águila Real";
            a.LongitudAlas = 2;
            a.Velocidad = 160;
            a.Domestico = false;
            a.Patas = 2;
            a.Pelaje = "si";

                Console.WriteLine(" ");
                Console.WriteLine("El Nombre del Aguila es: " + a.Nombreave);
                Console.WriteLine("Longitud de las alas : " + a.LongitudAlas  + " Metros");
                Console.WriteLine("Velocidad: " + a.Velocidad + " Km/h");
                Console.WriteLine("Tiene Pelaje: " + a.Pelaje);
                Console.WriteLine("Es Domestico : " + a.Domestico);
            
            a.VolarAlto();
            break;

            case "2":
            Loro l = new Loro();
            l.Nombreave = "Chimuelo";
            l.Domestico = true;
            l.Longitud = 33;
            l.Patas =2;
            l.Pelaje = "si";
            l.Interactua = "si";
                   
                Console.WriteLine(" ");       
                Console.WriteLine("El Nombre del Loro es: " + l.Nombreave);
                Console.WriteLine("Longitud de las alas : " + l.Longitud  + " Centimetros");
                Console.WriteLine("Tiene : " + l.Patas + " Patas");
                Console.WriteLine("Tiene Pelaje : " + l.Pelaje );
                Console.WriteLine("Es Domestico : " + l.Domestico);
                Console.WriteLine("Se rie : " + l.Interactua);
           
            break;

                default:
                Console.WriteLine("Ingrese un numero:   ");
                break;
            }
         break;



        case "2":

        // Peces

        PezG pg = new PezG();
        pg.Nombre = "Pez Globo";
        pg.Domestico = false;
        pg.Familia = "Tetraodontidae; Bonaparte";
        pg.Reino = "Animalia";
        pg.Clase = "Actinopterygii";
        pg.Orden= "Tetraodontiformes";

            Console.WriteLine(" ");
            Console.WriteLine("Nombre del Pez : " + pg.Nombre );
            Console.WriteLine("Familia : " + pg.Familia);
            Console.WriteLine("Reino : " + pg.Reino);
            Console.WriteLine("Clase : " + pg.Clase);
            Console.WriteLine("Orden: " + pg.Orden);
            Console.WriteLine("Domestico : " + pg.Domestico);
            
            break;
            default:
            Console.WriteLine(" ");
            Console.WriteLine("Ingrese un numero");
                
             break;
            }
        break;


            
//-------------------------------------FIN---------------------------------
          
         
          }
          if (Opcion == "0")
          {
          break;
          }    
        }
        } 
    }
}
