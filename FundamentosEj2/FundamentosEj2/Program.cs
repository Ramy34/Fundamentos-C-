//Importamos la librería de las expresiones regulares
using System.Text.RegularExpressions;
//Definimos las variables
int valorInicial, valorFinal, divisor;
//Mientras no se cumpla la condición debemos de seguir pidiendo el mensaje
while (true){
    //Pedimos el valor inicial
    Console.Write("Ingresa un valor inicial: ");
    //Guardamos el valor que nos dan
    string valorInicialString = Console.ReadLine();
    //Corroboramos que sea un número
    Match resultMatchInicial = Regex.Match(valorInicialString, @"^\d+$");
    //Si en la cadena contiene número salimos del while
    if (resultMatchInicial.Success)
    {
        valorInicial = int.Parse(valorInicialString);
        break;
    }
    else {
        Console.WriteLine("Debes de ingresar un número");
    }
}
//Iniciamos el flujo del valor final
while (true) {
    //Pedimos el valor inicial
    Console.Write("Ingresa un valor final: ");
    //Guardamos el valor que nos dan
    string valorFinalString = Console.ReadLine();
    //Corroboramos que sea un número
    Match resultMatchFinal = Regex.Match(valorFinalString, @"^\d+$");
    //Si en la cadena contiene número salimos del while
    if (resultMatchFinal.Success)
    {
        valorFinal = int.Parse(valorFinalString);
        if (valorFinal > valorInicial) {
            break;
        }
        else
        {
            Console.WriteLine("Debes de ingresar un valor mayor a {0}", valorInicial);
        }
    }
    else
    {
        Console.WriteLine("Debes de ingresar un número");
    }
}

//Iniciamos el flujo del divisor
while (true)
{
    //Pedimos el valor inicial
    Console.Write("Ingresa un valor del divisor: ");
    //Guardamos el valor que nos dan
    string divisorString = Console.ReadLine();
    //Corroboramos que sea un número
    Match resultMatchFinal = Regex.Match(divisorString, @"^\d+$");
    //Si en la cadena contiene número salimos del while
    if (resultMatchFinal.Success)
    {
        divisor = int.Parse(divisorString);
        if (divisor < valorFinal)
        {
            if (divisor > valorInicial)
            {
                break;
            }
            else {
                Console.WriteLine("El divisor debe de ser mayor que el valor inicial ({0})", valorInicial);
            }

        }
        else {
            Console.WriteLine("El divisor debe de ser menor que el valor final ({0})", valorFinal);
        }
    }
    else
    {
        Console.WriteLine("Debes de ingresar un número");
    }
}
//Obtendremos los números divisibles en el rango dado
for (int i = valorInicial; i <= valorFinal; i++)
{
    if (i % divisor == 0)
    {
        Console.WriteLine(i);
    }
}