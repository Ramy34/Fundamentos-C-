using FundamentosEj5.Modelos;

namespace FundamentosEj5
{
    internal static class Utility
    {
        static List<string> nombresCervezas = new List<String>() {
            "Corona", "Budweiser","Heineken", "Stella Artois", "Bud Light", "Snow",
            "Skol", "Guinness", "Brahma", "Amstel", "Modelo",
        };
        static Random numeroAzar = new Random();
        
        /// <summary>
        /// LLena una lista con cervezas aleatorias del tamaño ingresado
        /// </summary>
        /// <param name="cervezas"></param>
        /// <param name="tamanoLista"></param>
        /// <returns>Una lista de cervezas</returns>
        public static List<Cerveza> LlenarCervezas(this List<Cerveza> cervezas, int tamanoLista)
        {
            for (int i = 0; i < tamanoLista; i++)
            {
                cervezas.Add(new Cerveza(nombresCervezas[numeroAzar.Next(11)], numeroAzar.Next(2), numeroAzar.NextDouble()*100));
            }
            return cervezas;
        }
        /// <summary>
        /// Muestra las cervezas en consola
        /// </summary>
        /// <param name="cervezas"></param>
        public static void MostrarCerveza(this List<Cerveza> cervezas)
        {
            foreach (Cerveza cerveza in cervezas) {
                cerveza.MostrarCerveza();
            }
        }
        /// <summary>
        /// Filtra la lista de cervezas dependiendo del tipo ingresado
        /// </summary>
        /// <param name="cervezas"></param>
        /// <param name="tipo"></param>
        /// <returns>Una lista filtrada por tipo</returns>
        public static List<Cerveza> FiltarTipo(this List<Cerveza> cervezas, int tipo)
        {
            var cervezasFiltradas = cervezas.Where(c => c.Tipo == tipo).ToList();
            return cervezasFiltradas;
        }
        /// <summary>
        /// Filtra la lista de cervezas si el grado de alcohol es menor o igual al ingresado
        /// </summary>
        /// <param name="cervezas"></param>
        /// <param name="gradoAlcohol"></param>
        /// <returns>Lista filtrada por grado de alcohol</returns>
        public static List<Cerveza> FiltarGradoAlcohol(this List<Cerveza> cervezas, double gradoAlcohol)
        {
            var cervezasFiltradas = cervezas.Where(c => c.GradosAlcohol <= gradoAlcohol).ToList();
            return cervezasFiltradas;
        }

    }
}
