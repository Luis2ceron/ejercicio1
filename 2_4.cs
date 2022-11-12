public class Ejercicio2_4
{

    public static void Main()
    {
        double var1;
        double var2;
        double var3;
        double var4;
        double media;
        double multiplicacion;
        double suma;
        Console.WriteLine("Ingrese cuatro variables ");
        var1 = Convert.ToDouble(Console.ReadLine());
        var2 = Convert.ToDouble(Console.ReadLine());
        var3 = Convert.ToDouble(Console.ReadLine());
        var4 = Convert.ToDouble(Console.ReadLine());
        suma = var1 + var2 + var3 + var4;
        multiplicacion = var1 * var2 * var3 * var4;
        media = suma / 4;
        Console.WriteLine("Suma de las variables:" + suma);
        Console.WriteLine("multiplicación de las variables:" + multiplicacion);
        Console.WriteLine("media aritmetica de las variables:" + media);
        Console.WriteLine("");

    }
}