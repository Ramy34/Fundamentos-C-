# Fundamentos de C#

Repositorio de ejercicios de C# realizados con .net 6

## Ejercicios

- Ejercicio 1: Identificación nombre de día
	Solicitar un texto al usuario e indicar lo siguiente
	Si la cadena de entrada es: weekday
	Si la cadena de entrada es: weekend
	Si la cadena de entrada es: invalid text
		
- Ejercicio 2:	Rangos
	Solicitar al usuario 3 valores numéricos
	- Valor inicial
	- Valor final
	- Divisor
	Reglas: Indicar dentro del rango establecido por el usuario cuantos números son divisibles por el valor “divisor” ingresado
	Validaciones:
		- Si no es un número entero regresar una advertencia y solicitar de nuevo el valor
		- El valor final no debe ser menor o igual al valor inicial, de lo contrario mostrar una advertencia al usuario y solicitar de nuevo el valor
		- El divisor debe ser menor al valor final y mayor al valor inicial, si no se cumple la validación regresar una advertencia y solicitar de nuevo el valor
	Resultado: mostrar al usuario la cantidad de números que son divisibles ante el valor ingresado dentro del rango solicitado
	
- Ejercicio 3: Investigación de los métodos de extensión

- Ejercicio 4: Validación con métodos de extensión
    1) Generar un método de extensión para un tipo Int
		- Que nos indique si el número de entrada es un numero para o no, la respuesta debe ser de un tipo bool
		- Validar que la cadena de entrada que indique el usuario sea un entero de lo contrario regresar una advertencia y solicitar el valor de nuevo
    2)	Generar un método de extensión para un tipo string
		- Un método que nos indique cuantos espacios en blanco tiene la cadena que estamos validando, respuesta en tipo Int
		- Un método de extensión que remueva las vocales de una cadena de entrada, respuesta en tipo string


- Ejercicio 5: Método de extensión en un List

    1) Generar un objeto de nombre “Cerveza”, con las siguientes propiedades 
        - Nombre: string
        - Tipo: int (1 clara, 2 obscura)
        - GradosAlcohol: double
    2) Llenar una lista dummy del objeto Cerveza (List<Cerveza>) con al menos 10 registros
    3) Generar un método de extensión a la Lista de Cervezas el cual nos permita filtrar por dos valores Tipo y Grados de alcohol.
	4) Resultado esperado será solo retornar el listado con las coincidencias
	5) Los grados de alcohol tendrán la validación que será el máximo el indicado en el filtro, es decir que nos traerá todas las cervezas que tengan un grado igual o menor al ingresado