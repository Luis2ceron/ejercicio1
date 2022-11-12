using System;
public class Ejercicio2_3
{

    public static void Main()
    {
        double valor_doble;
        double valor_ingresado;

        Console.WriteLine("Ingrese un valor");
        valor_ingresado = Convert.ToDouble(Console.ReadLine());
        valor_doble = valor_ingresado * 2;
        Console.WriteLine("Numero doblado : " + valor_doble);
        Console.WriteLine("Numero doblado y multiplicado por 25 : " + valor_doble * 25);
        Console.WriteLine("");
    }
}