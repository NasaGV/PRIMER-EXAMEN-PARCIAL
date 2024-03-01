/*  
                 OPERACIONES CON CADENAS

while (true)
{
    Console.WriteLine("\nMenu Operaciones con cadenas:");
    Console.WriteLine("1. comparacion de cadenas");
    Console.WriteLine("2. Concatenacion de cadenas");
    Console.WriteLine("3. Buscar patron en la cadena de texto");
    Console.WriteLine("4. Formatear una cadena");
    Console.WriteLine("0. Salir");

    Console.Write("Ingrese su opción: ");
    int opcion;
    if (int.TryParse(Console.ReadLine(), out opcion))
    {
        switch (opcion)
        {
            case 1:
                string cadena1, cadena2;
                do
                {
                    Console.WriteLine("\nIngrese su cadena de texto: ");
                    cadena1 = Console.ReadLine();

                    Console.WriteLine("\nIngrese una segunda cadena para conparar");
                    cadena2 = Console.ReadLine();

                    if (cadena1 != cadena2)
                    {
                        Console.WriteLine("\nLas cadenas no son iguales, vuelve a intentarlo");
                    }
                } while (cadena1 != cadena2);

                Console.WriteLine("\nLas cadenas son iguales :D ");
                break;
           
            case 2:
                Console.WriteLine("\nIngrese la primera cadena: ");
                string texto1 = Console.ReadLine();

                Console.WriteLine("\nIngrese la segunda cadena para concatenar: ");
                string texto2 = Console.ReadLine();

                string concatenacion = texto1 + texto2;
                Console.WriteLine("\nLa concatenacion de las dos cadenas es: " + concatenacion);
                break;
            
            case 3:
                Console.WriteLine("\nIngrese la cadena de texto: ");
                string texto = Console.ReadLine();

                Console.WriteLine("\nIngrese el patron a buscar:");
                string patron = Console.ReadLine();

                int contador = 0;
                int buscar = texto.IndexOf(patron);

                while (buscar != -1)
                {
                    contador++;
                    buscar = texto.IndexOf(patron, buscar + 1);
                }

                if (contador > 0)
                {
                    Console.WriteLine($"El patron '{patron}' se encontro {contador} veces en el texto.");
                }
                else
                {
                    Console.WriteLine($"El patron '{patron}' no se encontro en el texto.");
                }
                break;
            
            case 4:
                Console.WriteLine("\nIngrese tu nombre:");
                string nombre = Console.ReadLine();

                Console.WriteLine("\nIngrese tu edad:");
                int edad = Convert.ToInt32(Console.ReadLine());

                string mensaje = string.Format("\nMi nombre es {0} y tengo {1} años.", nombre, edad);
                Console.WriteLine(mensaje);
                break;
           
            case 0:
                // Salir del programa
                Console.WriteLine("Gracias por usar nuestro programa nos vemos :D ");
                return;
            default:
                Console.WriteLine("Por favor seleccione una opcion valida entre 1-4:");
                break;
        }
    }
    else
    {
        Console.WriteLine("Por favor ingresar solo numeros: ");
    }
} 

 
*/


/*                    MENU DE OPCIONES CON OPERACIONES MATEMATICAS
while (true)
{
    Console.Write("Ingrese un numero entero positivo: ");
    string input = Console.ReadLine();

    int numero;
    if (!int.TryParse(input, out numero) || numero < 0)
    {
        Console.WriteLine("Por favor ingresar solo numeros que sean positivos: ");
        continue;
    }

    if (numero == 0)
    {
        Console.WriteLine("No se puede realizar ninguna operación con 0, Por favor ingrese otro numero mayor a este: ");
        continue;
    }

    Console.WriteLine("Menu de operaciones (seleccionar opcion usando los digitos del 1-3):");
    Console.WriteLine("1. calcular el factorial.");
    Console.WriteLine("2. Calcula la raiz cuadrada, ");
    Console.WriteLine("3. Salir del programa.");
    Console.Write("Seleccione una opción: ");

    string opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":
            Console.WriteLine($"El factorial de {numero} es: {Factorial(numero)}");
            break;
        case "2":
            Console.WriteLine($"La raiz cuadrada de {numero} es: {Math.Sqrt(numero)}");
            break;
        case "3":
            Console.WriteLine("Saliendo del programa...");
            return;
        default:
            Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
            break;
    }
}
    

    static int Factorial(int n)
{
    if (n == 0)
        return 1;
    return n * Factorial(n - 1);

}

*/



/*
                 EJERCICIO 2 OPERADORES MATEMATICOS

int num1, num2;
char operador;

Console.Write("Ingresa tu primer digito de tipo entero ");
num1 = int.Parse(Console.ReadLine());

Console.Write("Ingrese el segundo digito de tipo entero ");
num2 = int.Parse(Console.ReadLine());

Console.Write("Ingrese un operador matematico (+, -, *, /): ");
operador = char.Parse(Console.ReadLine());

double resultado = 0;

switch (operador)
{
    case '+':
        resultado = num1 + num2;
        break;
    case '-':
        resultado = num1 - num2;
        break;
    case '*':
        resultado = num1 * num2;
        break;
    case '/':
        if (num2 != 0)
        {
            resultado = (double)num1 / num2;
        }
        else
        {
            Console.WriteLine("Error: No se puede dividir por cero.");
            return;
        }
        break;
    default:
        Console.WriteLine("Ingresa un operador valido");
        return;
}

Console.WriteLine($"El resultado de {num1} {operador} {num2} es: {resultado}");

 */






/*
   EJERCICIO 3 TAMBLAS DE MULTIPLICAR 

Console.Write("Ingresa el numero de la tabla de multiplicar que deseas generar: ");
int numero = int.Parse(Console.ReadLine());

Console.WriteLine($"La tabla de multiplicar del {numero} es:");
for (int i = 1; i <= 10; i++)
{
    int tabla = numero * i;
    Console.WriteLine($"{numero} x {i} = {tabla}");
}
*/




/*
       EJERCICIO 4 ADIVINA EL NUMERO 

Random random = new Random();
int secreto = random.Next(1, 101);
int intentos = 0;
int num;

Console.WriteLine("\n!Hora de probar tu suerte adivinando el numero secreo¡ ");
Console.WriteLine("El numero secreto se encuentra entre el 1 y el 100, adivina cual es el correcto");

while (true)
{
    Console.Write("\nIngresa el numero que crees que es el correcto: ");
    if (!int.TryParse(Console.ReadLine(), out num))
    {
        Console.WriteLine("Por favor Ingresa solo numeros: ");
        continue;
    }

    intentos++;

    if (num < secreto)
    {
        Console.WriteLine("El numero es mayor.");
    }
    else if (num > secreto)
    {
        Console.WriteLine("El numero es menor.");
    }
    else
    {
        Console.WriteLine($"\n¡Buen trabajo el numero secreto es '{secreto}'  lo has logrado en '{intentos}' intentos.");
        break;
    }
}

 */


