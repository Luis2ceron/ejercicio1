namespace Ejemplos
{
    public class ejercicio2_10
    {
        public static void Main()
        {
            Console.WriteLine("Inserte la cantidad de metros que necesita");
            double metros_Necesarios = (Convert.ToInt32(Console.ReadLine()));

            double pulgadas_Necesarias =Math.Truncate( metros_Necesarios / 0.0254);
            Console.WriteLine("la cantidad de pulgadas que debe pedir son " + pulgadas_Necesarias );
        }


    }
}