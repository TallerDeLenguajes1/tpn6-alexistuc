using System;

namespace ALEXIS_ALE___TRABAJO_PRACTICO_6___TALLER_DE_LENGUAJES
{
    class Program
    {
        static void Main(string[] args)
        {
            //ejercicio 1
            int num = 0;
            ejercicio1 numero = new ejercicio1();
            ejercicio1 numero2 = new ejercicio1();
            num = numero.comprobarNumero(num);
            Console.WriteLine("el numero ingresado es: " + num);
            
            num = numero.inversor(num);
            Console.WriteLine("el numero invertido es: " + num);
            
            //FINAL DEL PROGRAMA
            Console.WriteLine("\nFIN DEL PROGRAMA\n");
            
        }
    }
}