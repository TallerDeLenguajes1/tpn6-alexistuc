using System;

namespace ALEXIS_ALE___TRABAJO_PRACTICO_6___TALLER_DE_LENGUAJES
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int num2 = 0;
            //Console.WriteLine("POR FAVOR INGRESE UN NUMERO MAYOR QUE CERO: ");
            //num = Convert.ToInt32(Console.ReadLine());
            ejercicio1 numero = new ejercicio1();
            ejercicio1 numero2 = new ejercicio1();
            num = numero.comprobarNumero(num);
            Console.WriteLine("el numero ingresado es: " + num);
            
            num = numero.inversor(num);
            Console.WriteLine("el numero invertido es: " + num);
            
        }
    }
}