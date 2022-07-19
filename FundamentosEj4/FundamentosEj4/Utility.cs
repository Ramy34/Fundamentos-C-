using System.Text.RegularExpressions;

namespace FundamentosEj4
{
    public static class Utility
    {
        /// <summary>
        /// Nos dice si el valor es par
        /// </summary>
        /// <param name="valor"></param>
        /// <returns>Un bool</returns>
        public static bool EsPar(this int valor) {
            return valor % 2 == 0;
        }
        /// <summary>
        /// Valida si la cadena es un número
        /// </summary>
        /// <param name="numeroIngresado"></param>
        /// <returns>Un bool</returns>
        public static bool ValidacionNumero(this string numeroIngresado) {
            Match resultMatch = Regex.Match(numeroIngresado, @"^\d+$");
            return resultMatch.Success;
        }
        /// <summary>
        /// Convierte una cadena en un entero
        /// </summary>
        /// <param name="numeroIngresado"></param>
        /// <returns>Un int</returns>
        public static int ConvertirStringNumero(this string numeroIngresado) {
            return int.Parse(numeroIngresado);
        }
        /// <summary>
        /// Cuenta los espacios en una cadena
        /// </summary>
        /// <param name="cadena"></param>
        /// <returns>Un int con el conteo</returns>
        public static int ContarEspacios(this string cadena) {
            int cuenta = 0;
            foreach(char letra in cadena){
                if (Char.IsWhiteSpace(letra)) {
                    cuenta += 1;
                }
            }
            return cuenta;
        }
        /// <summary>
        /// Remueve las vocales de uan cadena
        /// </summary>
        /// <param name="cadena"></param>
        /// <returns>Una cadena sin vocales</returns>
        public static string RemoverVocales(this string cadena) {
            return Regex.Replace(cadena, "[aeiouAEIOU]", "");
        }
        /// <summary>
        /// Controla el flujo de pedir un número al usuario
        /// </summary>
        /// <param name="cadena"></param>
        /// <returns>Un string válido</returns>
        public static string MensajePedirNumero(this string cadena) {
            while (true)
            {
                Console.Write("Ingresa un número: ");
                cadena = Console.ReadLine();

                if (!cadena.ValidacionNumero())
                    Console.WriteLine("Debe de ser un número válido.");
                else
                    break;
            }
            return cadena;
        }
        /// <summary>
        /// Se encarga de pedir una palabra o frase al usuario
        /// </summary>
        /// <param name="cadena"></param>
        /// <returns>La cadena ingresada por el usuario</returns>
        public static string MensajePedirFrase(this string cadena) {
            Console.Write("Ingresa una palabra o frase: ");
            return Console.ReadLine();
        }

    }
}
