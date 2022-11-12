public class Ejercicio3_5
{

    public static void Main()
    {
        double precio_Articulo;
        int cantidad;
        double precio_Bruto;
        double precio_Total;
        double descuento;

        Console.WriteLine("Ingrese el precio del articulo");
        precio_Articulo = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el precio del articulo");
        cantidad = Convert.ToInt32(Console.ReadLine());

        precio_Bruto = (precio_Articulo * cantidad);
        precio_Total= precio_Bruto + (precio_Bruto * 0.16);
        Console.WriteLine("El precio total es de " + precio_Total);

        if (precio_Total > 50000)
        {
            descuento = precio_Total - (precio_Total * 0.05);
            Console.WriteLine("El precio total es de " + descuento);

        }
    }
}