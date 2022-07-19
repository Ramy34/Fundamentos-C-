using FundamentosEj4;

string numeroIngresado = "";
numeroIngresado = numeroIngresado.MensajePedirNumero();
Console.WriteLine($"¿El valor {numeroIngresado.ConvertirStringNumero()} es par? {numeroIngresado.ConvertirStringNumero().EsPar()}");
string frase = "";
frase = frase.MensajePedirFrase();
Console.WriteLine(frase.ContarEspacios());
Console.WriteLine($"Palabra con vocales: {frase}, palabra sin vocales: {frase.RemoverVocales()}");