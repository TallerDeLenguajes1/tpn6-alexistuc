using System;
using System.Collections.Generic;
using System.Text;

namespace ALEXIS_ALE___TP6___EJERCICIO_4
{
    class CalculadoraRustica
    {
		
		//metodo para sumar dos numeros
		public void sumador(int a, int b)
		{
            Console.WriteLine("el resultado de la suma es: "+ (a + b));
		}
		//metodo para restar dos numeros
		public void restador(int a, int b)
		{
			Console.WriteLine("el resultado de la resta es: " + (a - b));
		}
		//metodo para multiplicar dos numeros
		public void multiplicador(int a, int b)
		{
			Console.WriteLine("el resultado del producto es: " + (a * b));
		}
		//metodo para dividir dos numeros
		public void divisor(int a, int b)
		{
			if (b == 0)
			{
				Console.WriteLine("ERROR, LA DIVISION EN 0 NO ESTA DEFINIDA");
			}
			else
			{
				Console.WriteLine("el resultado de la division es: " + (a / b));
			}
		}
	}
}
