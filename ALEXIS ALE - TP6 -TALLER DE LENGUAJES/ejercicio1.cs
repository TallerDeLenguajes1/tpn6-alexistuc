/*
 Ejercicio 1. Construir un programa que permita invertir Número de N cifras. Si el
número es menor o igual a cero evitar esta conversión
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace ALEXIS_ALE___TRABAJO_PRACTICO_6___TALLER_DE_LENGUAJES
{
    class ejercicio1
    {
        //este metodo se encarga de comprobar que el numero sea positivo
        public int comprobarNumero(int numero)
        {
            do
            {
                Console.WriteLine("POR FAVOR INGRESE UN NUMERO MAYOR QUE CERO: ");
                numero = Convert.ToInt32(Console.ReadLine());
            } while (numero < 0);
            return numero;
        }
        //este metodo se encarga de invertir las cifras del numero,retorna el numero con las cifras invertidas
        public int inversor(int num)
        {
            int aux, inverso = 0;
            
            while (num > 0)
            {
                aux = num % 10;
                inverso = inverso * 10 + aux;
                num = num / 10;
            }
            return inverso;

        }

    }
}
