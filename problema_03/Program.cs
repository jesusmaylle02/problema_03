using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declarar datos
            Console.WriteLine("Ingresar la edad del ganador: ");
            int edad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de adivinanzas correctas:");
            int adivinanzasAcertadas = Convert.ToInt32(Console.ReadLine());

            // Calcular el monto inicial según los datos
            double montoInicial = 0;
            if (edad >= 18)
            {
                if (adivinanzasAcertadas < 3)
                {
                    montoInicial = 30.00;
                }
                else if (adivinanzasAcertadas >= 3)
                {
                    montoInicial = 50.00;
                }
            }
            else if (edad < 18)
            {
                if (adivinanzasAcertadas < 3)
                {
                    montoInicial = 50.00;
                }
                else if (adivinanzasAcertadas >= 3)
                {
                    montoInicial = 80.00;
                }
            }

            // Calcular el monto extra según la edad y la cantidad de adivinanzas acertadas
            double montoExtra = (5.00 * edad) + (2.00 * adivinanzasAcertadas);
            // Calcular el monto final 
            double montoFinal = montoInicial + montoExtra;
            Console.WriteLine("El monto de dinero que recibira el ganador es de : " + montoFinal.ToString("C"));
            Console.ReadKey();
        }
    }
}
