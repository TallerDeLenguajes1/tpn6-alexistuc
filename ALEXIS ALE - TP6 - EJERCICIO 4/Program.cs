using System;

namespace ALEXIS_ALE___TP6___EJERCICIO_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena = "CHAPARRON BONAPARTE ";
            string cadena2 = "U.N.T.";
            string[] cadena3 = cadena.Split('+');
            string cadena4 = "una cadena toda en minusculas";
            string cadena5 = "CHAPARRON BONAPARTE ";
            int largo = 0, NUM1, NUM2;
            CalculadoraRustica RES = new CalculadoraRustica();

            Console.WriteLine("algunas letras de la cadena: " + cadena[0] + " " + cadena[1] + " " + cadena[4] + " " + cadena[5]);
            largo = cadena.Length;
            Console.WriteLine("la cadena tiene: " + largo + " caracteres");
            cadena2 = cadena + " " + cadena2;
            Console.WriteLine("la cadena concatenada es: " + cadena2);
            Console.WriteLine("subcadena: " + cadena2.Substring(0, 9));

            Console.WriteLine("CALCULADORA: ");
            Console.WriteLine("POR FAVOR INGRESE UN NUMERO: ");
            NUM1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("POR FAVOR INGRESE OTRO NUMERO: ");
            NUM2 = Convert.ToInt32(Console.ReadLine());
            RES.sumador(NUM1, NUM2);
            RES.restador(NUM1, NUM2);
            RES.multiplicador(NUM1, NUM2);
            RES.divisor(NUM1, NUM2);

            foreach (string cad in cadena3)
            {
                Console.WriteLine(cad);
            }

            Console.WriteLine("LA CADENA CONTIENE LA FRASE U.N.T.?: " + cadena2.Contains("U.N.T."));
            Console.WriteLine("CADENA CONVERTIDA A MAYUSCULAS: " + cadena4.ToUpper());
            Console.WriteLine("cadena convertida a minusculas: " + cadena.ToLower());

            //comparo cadenas:
            if (string.Equals(cadena, cadena5)) Console.WriteLine("las cadenas son iguales!!!");
            else Console.WriteLine("las cadenas son distintas");
            if (string.Equals(cadena, cadena2)) Console.WriteLine("las cadenas son iguales!!!");
            else Console.WriteLine("las cadenas son distintas");
        }
    }
}
/*
 Realizar los siguientes ejercicios
Dada una cadena de texto ingresada por el usuario, realice las siguientes tarea:
● Obtener algunas letras que forman parte de una cadena
● Obtener la longitud de la cadena y muestre por pantalla
● Concatenar (Unir) dos cadenas distintas
● Extraer una subcadena
● Utilizando la calculadora creada anteriormente realizar las operaciones de dos
números y mostrar por pantalla y mostrar en texto el resultado. Por ejemplo para
la suma sería:
“la suma de “ num1 “ y de” num2 “ es igual a: ” resultado.
Donde num1, num2 y resultados son los sumandos y el resultado de la operación
respectivamente .
Nota: Busque el comportamiento del Método ToString();
● Recorrer la cadena de texto con un ciclo Foreach e ir mostrando elemento por
elemento en pantalla
● Buscar la ocurrencia de una palabra determinada en la cadena ingresada
● Convierta la cadena a Mayúsculas y luego minúsculas
● Ingrese una nueva cadena y luego compare los valores de ambas.
● Ingrese una cadena separada por caracteres que usted determine y muestre por
pantalla los resultados (Revisar el comportamiento de split())
● Siguiendo con el ejemplo de la calculadora (ejercicio 2) ingrese una ecuación
simple como cadena de caracteres y que el sistema lo resuelva. Por ej. ingrese
por pantalla “582+2” y que le devuelva la suma de 582 con 2

 */
