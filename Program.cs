using System;

string menu = "\nMenú:\n1. Suma\n2. Resta\n3. Multiplicación\n4. División\n5. Salir";

while (true)
{
    Console.WriteLine(menu);
    Console.Write("Elige una opción: ");
    int opcion = ObtenerOpcion();

    switch (opcion)
    {
        case 1:
            RealizarSuma();
            break;
        case 2:
            RealizarResta();
            break;
        case 3:
            RealizarMultiplicacion();
            break;
        case 4:
            RealizarDivision();
            break;
        case 5:
            Console.WriteLine("Gracias por usar la Calculadora C#");
            return;
        default:
            Console.WriteLine("Opción inválida. Por favor, elige una opción válida.");
            break;
    }
}

static int ObtenerOpcion()
{
    while (true)
    {
        if (!int.TryParse(Console.ReadLine(), out int opcion))
        {
            Console.WriteLine("Entrada inválida. Por favor, ingresa un número válido.");
        }
        else
        {
            return opcion;
        }
    }
}

static void RealizarSuma()
{
    Console.Write("Ingresa el primer número: ");
    double num1 = ObtenerNumero();
    Console.Write("Ingresa el segundo número: ");
    double num2 = ObtenerNumero();
    double resultado = num1 + num2;
    Console.WriteLine($"El resultado de la suma es: {resultado}");
}

static void RealizarResta()
{
    Console.Write("Ingresa el primer número: ");
    double num1 = ObtenerNumero();
    Console.Write("Ingresa el segundo número: ");
    double num2 = ObtenerNumero();
    double resultado = num1 - num2;
    Console.WriteLine($"El resultado de la resta es: {resultado}");
}

static void RealizarMultiplicacion()
{
    Console.Write("Ingresa el primer número: ");
    double num1 = ObtenerNumero();
    Console.Write("Ingresa el segundo número: ");
    double num2 = ObtenerNumero();
    double resultado = num1 * num2;
    Console.WriteLine($"El resultado de la multiplicación es: {resultado}");
}

static void RealizarDivision()
{
    Console.Write("Ingresa el primer número: ");
    double num1 = ObtenerNumero();
    Console.Write("Ingresa el segundo número: ");
    double num2 = ObtenerNumero();

    if (num2 == 0)
    {
        Console.WriteLine("Error: No se puede dividir entre cero.");
    }
    else
    {
        double resultado = num1 / num2;
        Console.WriteLine($"El resultado de la división es: {resultado}");
    }
}

static double ObtenerNumero()
{
    while (true)
    {
        if (!double.TryParse(Console.ReadLine(), out double numero))
        {
            Console.WriteLine("Entrada inválida. Por favor, ingresa un número válido.");
        }
        else
        {
            return numero;
        }
    }
}