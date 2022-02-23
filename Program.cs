using System;
public class adivinarNumero
{
    public static void Main(String[] args)
    {
        var generadorAleatorio = new Random();
        int numeroParaAdivinar = generadorAleatorio.Next(0, 16);
       
        
        Console.WriteLine("Bienvenido! El juego consiste en adivinar un número al azar entre 0 y 16. Cuentas con tres intentos.");
        Console.WriteLine("Introduzca un número entre 0 y 16:");
        int num = Int32.Parse(Console.ReadLine());
        int intentos = 3;
              
        while ((num != numeroParaAdivinar) && (intentos <= 4))
        {
            
            if (num < numeroParaAdivinar)
            {
                Console.WriteLine("Te quedaste por debajo del número aleatorio...");
                num = Int32.Parse(Console.ReadLine());
                
            }
            else if (num > numeroParaAdivinar)
            {
                Console.WriteLine("Te quedaste por encima del número aleatorio...");
                num = Int32.Parse(Console.ReadLine());
                
            }
            if (num == numeroParaAdivinar)
            {
                
                Console.WriteLine("Enhorabuena :D");
                num = Int32.Parse(Console.ReadLine());  
            }
         intentos++;

        }

        Console.WriteLine($"El numero a adivinar era {numeroParaAdivinar}");
    }
}