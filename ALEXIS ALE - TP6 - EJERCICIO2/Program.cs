using System;

namespace ALEXIS_ALE___TP6___EJERCICIO2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BIENVENIDO A LA CALCULADORA RUSTICA DE ALE\n");
            int opcion = -1, numa = 0, numb= 0;
            CalculadoraRustica resultado = new CalculadoraRustica(numa, numb);
            Console.WriteLine("POR FAVOR INGRESE EL PRIMER NUMERO DE LA OPERACION");
            numa = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("POR FAVOR INGRESE EL SEGUNDO NUMERO DE LA OPERACION");
            numb = Convert.ToInt32(Console.ReadLine());

            do
            {
                do
                {
                    
                    Console.WriteLine("\nPOR FAVOR SELECCIONE UNA OPCION:\n1 -> SUMA\n2 -> RESTA\n3 -> PRODUCTO\n4 -> DIVISION\n0 -> SALIR\n");
                    opcion = Convert.ToInt32(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1:
                            resultado.sumador(numa, numb);
                            opcion = 6;//le asigno 6 a opcion para que vuelva a pedir el menu
                            break;
                        case 2:
                            resultado.restador(numa, numb);
                            opcion = 6;//le asigno 6 a opcion para que vuelva a pedir el menu
                            break;
                        case 3:
                            resultado.multiplicador(numa, numb);
                            opcion = 6;//le asigno 6 a opcion para que vuelva a pedir el menu
                            break;
                        case 4:
                            resultado.divisor(numa, numb);
                            opcion = 6;//le asigno 6 a opcion para que vuelva a pedir el menu
                            break;
                        default: 
                            break;
                    }
                } while (opcion > 5);
            } while (opcion != 0);
        }
    }
}
