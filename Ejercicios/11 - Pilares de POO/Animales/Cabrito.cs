using System;

public class Cabrito : Mamiferos
{
    public string Pelo { get; set; }

    public bool Domestico { get; set; }
    public void Chozpar ()
    {
        Console.WriteLine(Nombre + " Esta Chozpando");
    }

    public override void Comer()
    {
        Console.WriteLine(Nombre + " Esta comiendo");
    }

    public Cabrito()  // Polimorfismo
   {
       Domestico = true;
   }
   public Cabrito (bool domestico)
   {
       Domestico = domestico;
   }
}