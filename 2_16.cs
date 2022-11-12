public class Ejercicio2_16
{

    public static void Main()
    {
        double contador;
        double suma_consecutiva;

        contador = 1;
        suma_consecutiva = 0;
        while (contador <= 10)
        {
            suma_consecutiva = suma_consecutiva + contador;
            contador = contador + 1;
        }
        Console.WriteLine("La suma de los números enteros del uno al 10 es " + suma_consecutiva);
        Console.WriteLine("");
    }
}