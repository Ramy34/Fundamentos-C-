while (true)
{
    //Escibimos el mensaje para el usuario
    Console.Write("Escribe un día de la semana: ");
    //Definimos la variable que almacenará el día de la semana escrito por el usuario
    string diaSemana = Console.ReadLine();
    //Realizamos la validación del día de la semana
    if (diaSemana == "Lunes" || diaSemana == "Martes" || diaSemana == "Miercoles" || diaSemana == "Jueves" || diaSemana == "Viernes")
    {
        Console.WriteLine("Día de la semana");
    }
    else if (diaSemana == "Sabado" || diaSemana == "Domingo")
    {
        Console.WriteLine("Fin de semana");
    }
    else
    {
        Console.WriteLine("Entrada inválida");
    }
}