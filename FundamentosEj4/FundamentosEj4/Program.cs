using FundamentosEj4;

string numeroIngresado = "";
numeroIngresado = numeroIngresado.MensajePedirNumero();
Console.WriteLine($"¿El valor {numeroIngresado.ConvertirStringNumero()} es par? {numeroIngresado.ConvertirStringNumero().EsPar()}");
Console.WriteLine("Hola Mundo! este es un conteo de espacio, el resultado debería ser de: 13".ContarCaracter());
Console.WriteLine($"Palabra con vocales: Murcielago, palabra sin vocales: {"Murcielago".RemoverVocales()}");