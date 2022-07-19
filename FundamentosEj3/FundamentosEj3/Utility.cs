using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosEj3
{
    public static class Utility
    {
        /// <summary>
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        public static string SayHi(this string valor)
        {
            return $"Hola {valor}";
        
        }


    }
}
