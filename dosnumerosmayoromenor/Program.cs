using System;

namespace dosnumerosmayoromenor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float num;
            float num2;
            Console.WriteLine("Introdusca el primer numero: ");
            num = float.Parse(Console.ReadLine());
            Console.WriteLine("Introdusca el primer numero: ");
            num2 = float.Parse(Console.ReadLine());
            if (num > num2)
            {
                Console.WriteLine("El numero mayor es: " + num);
            }
            else if (num == num2)
            {
                Console.WriteLine("Estos numeros son iguales");
            }
            else
            {
                Console.WriteLine("El numero mayor es: " + num2);
            }
            {

            }
        }
    }
}
