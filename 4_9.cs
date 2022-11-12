namespace numero_elevado_a_un_numero
{
    public class ejercicio4_9
    {
        public static void Main()
        {
            double num1;
            double num2;
            Console.WriteLine("ingrese el primer numero");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite s para ver la suma y r para ver la resta (minusculas)");
            var Respuesta = Convert.ToString(Console.ReadLine());


            if (Respuesta == "s" || Respuesta == "S")
            {
                double solucion = num1 + num2;
                Console.WriteLine("");
                Console.WriteLine(solucion);

            }
            else if (Respuesta == "r" || Respuesta == "R")
            {
                double solucion = num1 - num2;
                Console.WriteLine("");
                Console.WriteLine(solucion);

            }

        }
    }
}
