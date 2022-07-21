namespace FundamentosEj5.Modelos
{
    class Cerveza
    {
        public string Nombre { get; set; }
        public int Tipo { get; set; }
        public double GradosAlcohol { get; set; }

        public Cerveza(string nombre, int tipo, double gradosAlcohol)
        {
            Nombre = nombre;
            Tipo = tipo;
            GradosAlcohol = Math.Round(gradosAlcohol,2);
        }

        public Cerveza()
        {
        }

        public void MostrarCerveza()
        {
            Console.WriteLine($"Nombre: {Nombre} Tipo: {Tipo} Grados Alcohol: {GradosAlcohol}%");
        }

        
    }
}
