using System;

namespace ALEXIS_ALE__TP6___EJERCICIO3
{
    class Program
    {
        static void Main(string[] args)
        {
            float numero;
            int num1, num2;
            Console.WriteLine("POR FAVOR, INGRESE UN NUMERO");
            numero = Convert.ToSingle (Console.ReadLine());

            Console.WriteLine("el valor absoluto del numero es: " + Math.Abs(numero));
            Console.WriteLine("el cuadrado del numero es: " + Math.Pow(numero, 2));
            Console.WriteLine("la raiz del numero es: " + Math.Sqrt(numero));
            Console.WriteLine("el seno del numero es: " + Math.Sin(numero));
            Console.WriteLine("el coseno del numero es: " + Math.Cos(numero));
            Console.WriteLine("la parte entera del numero es: " + Math.Round(numero));
            Console.WriteLine("la parte entera del numero tambien es: " + (int)numero);

            Console.WriteLine("\nPOR FAVOR, INGRESE UN NUMERO");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("POR FAVOR, INGRESE OTRO NUMERO");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("EL MAYOR ES: " + Math.Max(num1, num2));
            Console.WriteLine("EL MENOR ES: " + Math.Min(num1, num2));
        }
    }
}
/*
 Ejercicio 3. Mejorando la Calculadora. Solicite al usuario un número y muestre por
pantalla:
● El valor absoluto de un número
● El cuadrado
● La raíz cuadrada
● El seno
● El Coseno
● La parte entera de un tipo float.
Luego de esto, solicite dos números al usuario y determine:
● El Máximo entre los dos números
● El Mínimo entre los dos números
 */
