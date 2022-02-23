using System;
public class Program
{
    public static void Main(String[] args)
    {
        var generadorAleatorio = new Random();
        int numeroParaAdivinar = generadorAleatorio.Next(0, 16);
        int numeroUsuario = 0;
        int contador = 0;
        const string falloNumero = "El número introducio es incorrecto";
        const string numeroMayor = "El numero que tienes que adivinar es mayor que el elegido, pruebe a escribir un nuevo número";
        const string numeroMenor = "El numero que tienes que adivinar es menor que el elegido, pruebe a escribir un nuevo número";

        Console.WriteLine("Hola! Bienvenido al adivinador de números, los primero que tendrá que hacer es escribir un número entre el 0 y el 16");
        numeroUsuario = Int32.Parse(Console.ReadLine());
        //poner que si es menor que 0 y mayor que 16 no lo recoja

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
                Console.WriteLine("GANAS");
                contador = 2;
            }
            
         }
    }
}
