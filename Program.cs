using System;
public class Program
{
    public static void Main(String[] args)
    {
        var generadorAleatorio = new Random();
        int numeroParaAdivinar = generadorAleatorio.Next(0, 16);
        int numeroUsuario = 0;
        int contador = 0;

        const string falloNumero = "El número introducido es incorrecto";
        const string numeroMayor = "El numero que tienes que adivinar es mayor que el elegido, pruebe a escribir un nuevo número";
        const string numeroMenor = "El numero que tienes que adivinar es menor que el elegido, pruebe a escribir un nuevo número";

        Console.Title = "ADIVINADOR DE NÚMEROS";
        Console.WriteLine("Hola! Bienvenido al adivinador de números, los primero que tendrá que hacer es escribir un número entre el 0 y el 16." +
            "\nSe recuerda que solamente tendrá TRES intentos para adivinarlo");
        numeroUsuario = Int32.Parse(Console.ReadLine());

        while (contador < 2)
        {
            if (numeroParaAdivinar < numeroUsuario)
            {
                Console.WriteLine(numeroMenor);
                numeroUsuario = Int32.Parse(Console.ReadLine());
                contador++;
            }
            else if (numeroParaAdivinar > numeroUsuario)
            {
                Console.WriteLine(numeroMayor);
                numeroUsuario = Int32.Parse(Console.ReadLine());
                contador++;
            }
            else if (numeroParaAdivinar == numeroUsuario)
            {
                Console.WriteLine($"WIINNNER WINNER, CHICKEN DIINNNER!! ENHORABUUENA! EL NÚMERO {numeroUsuario} es el CORRECTOO!!!");
                contador = 2;
                Environment.Exit(0);
            }
        }
        Console.WriteLine($"Ohhh... que lástima... Te has quedado sin intentos y el juego ha terminado. El numero a adivinar era {numeroParaAdivinar}");

    }
}
