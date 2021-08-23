using System;

class MainClass {
  public static void Main (string[] args) {
    double raio, area;
    
    Console.WriteLine ("Vamos calcular a área de uma circunferência?"+"\n");
    
    Console.WriteLine ("Então, me diga a o raio dessa circunferência que imaginou: ");
    raio = double.Parse (Console.ReadLine ());
    

    area = 3.14*(raio*raio);
    
    Console.WriteLine ("AHÁ! DESCOBRI! A área da circunferência é: "+area);
    
    
    Console.ReadKey ();
    
  }
}