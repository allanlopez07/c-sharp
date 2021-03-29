using System;

public  class Aguila : Aves
{

    public void VolarAlto ()
    {
        Console.WriteLine(Nombreave + " Esta Gritando"); 
        Console.WriteLine(Nombre + " Es cazadora");
        Console.WriteLine(Nombre + " Es Majestuosa");
    }

    public  override void Comer()
    {
        Console.WriteLine(Nombre + " Esta comiendo");
        
    }
}