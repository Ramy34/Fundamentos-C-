using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace FundamentosEj4
{
    public static class Utility
    {
        public static bool EsPar(this int valor) {
            return valor % 2 == 0;
        }

        public static bool Validacion(this string numeroIngresado) {
            Match resultMatch = Regex.Match(numeroIngresado, @"^\d+$");
            return resultMatch.Success;
        }

        public static int ConvertirStringNumero(this string numeroIngresado) {
            int valor = int.Parse(numeroIngresado);
            return valor;
        }

        public static int ContarCaracter(this string cadena) {
            int cuenta = 0;
            foreach(char letra in cadena){
                if (Char.IsWhiteSpace(letra)) {
                    cuenta += 1;
                }
            }
            return cuenta;
        }

        public static string RemoverVocales(this string cadena) {
            string fraseCambiada = Regex.Replace(cadena, "[aeiou]", "");
            return fraseCambiada;
        }

        public static string MensajePedirNumero(this string cadena) {
            while (true)
            {
                Console.Write("Ingresa un número: ");
                cadena = Console.ReadLine();

                if (!cadena.Validacion())
                    Console.WriteLine("Debe de ser un número válido.");
                else
                    break;
            }
            return cadena;
        }



        

    }
}
