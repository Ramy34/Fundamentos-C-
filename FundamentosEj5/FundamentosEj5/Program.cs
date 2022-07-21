using FundamentosEj5;
using FundamentosEj5.Modelos;

int tamanoLista = 10;
int tipoFiltrar = 1;
double gradoAlcoholFiltrar = 50;

List<Cerveza> cervezas = new List<Cerveza>() { };
cervezas = cervezas.LlenarCervezas(tamanoLista);
cervezas.MostrarCerveza();
Console.WriteLine("///////////////////////////////////////////////");
cervezas.FiltarTipo(tipoFiltrar).MostrarCerveza();
Console.WriteLine("///////////////////////////////////////////////");
cervezas.FiltarGradoAlcohol(gradoAlcoholFiltrar).MostrarCerveza();
Console.WriteLine("///////////////////////////////////////////////");