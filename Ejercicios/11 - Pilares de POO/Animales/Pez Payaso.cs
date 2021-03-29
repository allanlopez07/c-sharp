using System;

public class PezG :Peces
{    public string Familia { get; set; }

    public void Inflarse ()
    {
        Console.WriteLine(Nombre + " Esta Inflado");
        Console.WriteLine(Nombre + "  ");
        Console.WriteLine(Nombre + " Es Venenoso");
    }
    
     public  override void Comer()
    {
        Console.WriteLine(Nombre + " Esta comiendo");
    }

}