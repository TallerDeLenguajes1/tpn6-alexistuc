using System;
using System.Collections.Generic;
using System.Text;

namespace ALEXIS_ALE___TP6___EJERCICIO2
{
    class CalculadoraRustica
    {
		//int numero1 = 0, numero2 = 0;
		//constructor de la clase
		int numero1, numero2;
		public CalculadoraRustica(int num1, int num2)
        {
			numero1 = num1;
			numero2 = num2;
        }

		public CalculadoraRustica()
		{
			int numero1 = 0, numero2 = 0;
			ingresarNumeros(numero1, numero2);
		}

		//este metodo se encarga de pedir los numeros para realizar las operaciones
		public void ingresarNumeros(int numero1, int numero2)
		{
			Console.WriteLine("POR FAVOR INGRESE UN VALOR PARA EL PRIMER NUMERO: ");
			numero1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("POR FAVOR INGRESE UN VALOR PARA EL SEGUNDO NUMERO: ");
			numero2 = Convert.ToInt32(Console.ReadLine());
		}

		
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
