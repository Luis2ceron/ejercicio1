namespace dias
{
    public class program
    {
        public static void Main()
        {
            int dia = 0;
            int mes = 0;
            int anyo = 0;
            Console.WriteLine("ingrese el año");
            anyo = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("ingrese el mes");
            mes = Convert.ToInt32(Console.ReadLine());


            //Se establece el limite de la variable mes
            if (mes > 12)
            {
                while (mes > 12)
                {
                    Console.WriteLine(("el numero excede la cantidad de meses en el año,favor ingresar un numero valido"));
                    mes = Convert.ToInt32(Console.ReadLine());
                }
            }


            Console.WriteLine("ingrese el dia");
            dia = Convert.ToInt32(Console.ReadLine());

            int bisiesto = anyo % 4;

            //Se establece el limite de febrero en año bisiesto
            if (bisiesto == 0 && mes == 2 && dia > 29)
            {
                while (dia > 29)
                {
                    Console.WriteLine(("el numero excede la cantidad de dias del mes,inserte un numero valido"));
                    dia = Convert.ToInt32(Console.ReadLine());
                }
            }


            //Se establece el limite de febrero en año no bisiesto
            if (bisiesto != 0 && mes == 2 && dia > 28)
            {
                while (dia > 28)
                {
                    Console.WriteLine(("el numero excede la cantidad de dias del mes,inserte un numero valido"));
                    dia = Convert.ToInt32(Console.ReadLine());
                }
            }



            //Se establece el limite de la variable mes en los meses con 30 dias
            if (mes == 4 || mes == 6 || mes == 9 || mes == 11 && dia > 30)
            {
                while (dia > 30)
                {
                    Console.WriteLine(("el numero excede la cantidad de dias del mes,inserte un numero valido"));
                    dia = Convert.ToInt32(Console.ReadLine());
                }
            }


            //Se establece el limite de la variable mes en los meses con 31 dias
            if (mes == 1 && mes == 3 || mes == 5 || mes == 7 && mes == 8 || mes == 10 || mes == 12 && dia > 31)
            {
                while (dia > 31)
                {
                    Console.WriteLine(("el numero excede la cantidad de dias del mes,inserte un numero valido"));
                    dia = Convert.ToInt32(Console.ReadLine());
                }
            }



            DateTime mifecha = new DateTime(anyo, mes, dia);
            mifecha = mifecha.AddDays(1);

            Console.WriteLine(mifecha);


        }
    }
}