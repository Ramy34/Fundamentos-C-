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

        public static List<Cerveza> LlenarCervezas(this List<Cerveza> cervezas, int tamanoLista)
        {
            for (int i = 0; i < tamanoLista; i++)
            {
                cervezas.Add(new Cerveza(nombresCervezas[numeroAzar.Next(11)], numeroAzar.Next(2), numeroAzar.NextDouble()*100));
            }
            return cervezas;
        }

        public static void MostrarCerveza(this List<Cerveza> cervezas)
        {
            foreach (Cerveza cerveza in cervezas) {
                cerveza.MostrarCerveza();
            }
        }

        public static List<Cerveza> FiltarTipo(this List<Cerveza> cervezas, int tipo)
        {
            var cervezasFiltradas = cervezas.Where(c => c.Tipo == tipo).ToList();
            return cervezasFiltradas;
        }

        public static List<Cerveza> FiltarGradoAlcohol(this List<Cerveza> cervezas, double gradoAlcohol)
        {
            var cervezasFiltradas = cervezas.Where(c => c.GradosAlcohol <= gradoAlcohol).ToList();
            return cervezasFiltradas;
        }

    }
}
