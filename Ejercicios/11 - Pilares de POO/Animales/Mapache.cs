using System;
public class Mapache : Mamiferos   // Herencia
{
    public int Codigo { get; set; }
    public bool Domestico { get; set; }
    public void Chillar ()   // Abstracion
    {
      Console.WriteLine(Nombre + " Esta Chillando");
    }
    public  override void Comer()
    {
        Console.WriteLine(Nombre + " Esta Comiendo");
    }
   public Mapache()  // Polimorfismo
   {
       Domestico = false;
   }
   public Mapache(bool domestico)
   {
       Domestico = domestico;
   }
    public void Tamano() // Encapsulamiento
    {
        EspecificarTamano();
    }

    private void EspecificarTamano()
    {
     string Tamano = "";
     Console.WriteLine("Escriba si es Adulto o bebe");
     Tamano =Console.ReadLine();
     if (Tamano == "Adulto")
     {
        Console.WriteLine("Retirese");
        
     } else if (Tamano == "Bebe")
     {
        Console.WriteLine("Sin Peligro");
       
     }
    }
}