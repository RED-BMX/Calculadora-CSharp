public class Calculadora
{
    public double Sumar(double num1, double num2)
    {
        return num1 + num2;
    }

    public double Restar(double num1, double num2)
    {
        return num1 - num2;
    }

    public double Multiplicar(double num1, double num2)
    {
        return num1 * num2;
    }

    public double Dividir(double num1, double num2)
    {
        if (num2 == 0)
        {
            throw new ArgumentException("No se puede dividir entre cero.");
        }

        return num1 / num2;
    }
}