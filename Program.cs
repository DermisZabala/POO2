using System;
using System.Threading.Channels;

namespace POO2_encapsulacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Mensaje inicial
            Console.WriteLine("Convertir dólar a peso\n");
            
            // Crear objeto para convertir
            Convertir obj = new Convertir();

            // Solicitar al usuario la cantidad de dólares a convertir
            Console.WriteLine("Ingrese la cantidad de dólar que desea convertir a peso");
            //Leer el valor que el usuario ingreso
            double cantidad = double.Parse(Console.ReadLine());

            //Realizar la conversion e imprimir el resultado
            Console.WriteLine($"{cantidad} dólares son: {obj.ConvertirPeso(cantidad)} pesos dominicano\n 29/02/2024");

            
        }

        //clase para convertir la conversion de dolares a pesos
        class Convertir
        {
            //valor de dolar constante
            private const double valorDolar = 58.76;

            //metodos para convertir dolares a pesos
            public double ConvertirPeso (double valorPeso)
            {
                //Calcular el resultado de la conversion
                double resultado = valorDolar * valorPeso;

                //devuelve el resultado de la conversion
                return resultado;
            }
                      
        }

    }
}
