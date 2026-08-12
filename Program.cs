using System;

string menu = "\nMenú:\n1. Sumar\n2. Restar\n3. Multiplicar\n4. Dividir\n5. Salir";

Calculadora calculadora = new Calculadora();

while (true)
{
    Console.WriteLine(menu);
    Console.Write("Elige una opción: ");
    int opcion = ObtenerOpcion();

    switch (opcion)
    {
        case 1:
            Console.Write("Ingresa el primer número: ");
            double numero1 = ObtenerNumero();

            Console.Write("Ingresa el segundo número: ");
            double numero2 = ObtenerNumero();

            double resultadoSuma = calculadora.Sumar(numero1, numero2);

            Console.WriteLine($"El resultado de la suma es: {resultadoSuma}");
            break;

        case 2:
            Console.Write("Ingresa el primer número: ");
            numero1 = ObtenerNumero();

            Console.Write("Ingresa el segundo número: ");
            numero2 = ObtenerNumero();

            double resultadoResta = calculadora.Restar(numero1, numero2);

            Console.WriteLine($"El resultado de la resta es: {resultadoResta}");
            break;

        case 3:
            Console.Write("Ingresa el primer número: ");
            numero1 = ObtenerNumero();

            Console.Write("Ingresa el segundo número: ");
            numero2 = ObtenerNumero();

            double resultadoMultiplicacion = calculadora.Multiplicar(numero1, numero2);

            Console.WriteLine($"El resultado de la multiplicación es: {resultadoMultiplicacion}");
            break;

        case 4:
            Console.Write("Ingresa el primer número: ");
            numero1 = ObtenerNumero();

            Console.Write("Ingresa el segundo número: ");
            numero2 = ObtenerNumero();

            try
            {
                double resultadoDivision = calculadora.Dividir(numero1, numero2);

                Console.WriteLine($"El resultado de la división es: {resultadoDivision}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

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