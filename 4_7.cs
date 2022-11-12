namespace ejercicios
{
    public class ejercicio4_7
    {
        public static void Main()
        {
            Console.WriteLine(" por favor digite el dividendo");
            double dividendo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(" por favor digite el divisor");
            double divisor = Convert.ToDouble(Console.ReadLine());

            Convert.ToInt32(dividendo);
            Convert.ToInt32(divisor);


            double divisible = dividendo % divisor;

            if (divisible == 0)
            {
                Console.WriteLine("es divisor del número");
            }
            else if (divisible != 0)
            {
                Console.WriteLine(" NO es divisor del número");
            }
            return;

        }

    }
}
