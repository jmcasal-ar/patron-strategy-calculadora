using System;

namespace calculadora_strategy_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion =0 ;
            double numero1;
            double numero2;
            double resultado;

            Console.WriteLine("Hello World!");
            IOperacion operacion = new CSumar();


            while(opcion != 5)
            {
                Console.WriteLine("Ingrese alguna de las siguientes opciones: 1-Suma, 2-Resta, 3-Multiplicar, 4-Divir, 5-Salir");
                opcion = Convert.ToInt16(Console.ReadLine());

                if(opcion == 5)
                {
                    break;
                }

                Console.WriteLine("Ingrese el primer numero");
                numero1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ingrese el segundo numero");
                numero2 = Convert.ToDouble(Console.ReadLine());

                if (opcion == 1)
                {
                    operacion = new CSumar();
                }
                if (opcion == 2)
                {
                    operacion = new CRestar();
                }
                if (opcion == 3)
                {
                    operacion = new CMultiplicar();
                }

                if (opcion == 4)
                {
                    operacion = new CDividir();
                }

                resultado = operacion.Calcular(numero1, numero2);
                Console.WriteLine("El resultado de la operaciones {0}", resultado);
            }
        }
    }
}
