namespace ejemplo4_1
{
    class Program
    {
        public static void Main()
        {
            int cont = 0;
            int num;
            int sum = 0;
;
            while (cont < 10)
            {
                cont++;
                Console.WriteLine("Ingrese el numero:");
               num=Convert.ToInt32( Console.ReadLine());
                  sum = sum + num;
;
            }
            Console.WriteLine("La suma de los 10 numeros es " + sum);
        }
    }
}
