namespace Calculadora_CSharp.Tests;

public class UnitTest1
{
    [Fact]
    public void Sumar_DosNumeros_DebeRetornarLaSuma()
    {
        Calculadora calculadora = new Calculadora();

        double resultado = calculadora.Sumar(5, 3);

        Assert.Equal(8, resultado);
    }

    [Fact]
    public void Restar_DosNumeros_DebeRetornarLaResta()
    {
        Calculadora calculadora = new Calculadora();

        double resultado = calculadora.Restar(10, 4);

        Assert.Equal(6, resultado);
    }

    [Fact]
    public void Multiplicar_DosNumeros_DebeRetornarElProducto()
    {
        Calculadora calculadora = new Calculadora();

        double resultado = calculadora.Multiplicar(5, 4);

        Assert.Equal(20, resultado);
    }

    [Fact]
    public void Dividir_DosNumeros_DebeRetornarElResultado()
    {
        Calculadora calculadora = new Calculadora();

        double resultado = calculadora.Dividir(10, 2);

        Assert.Equal(5, resultado);
    }

    [Fact]
    public void Dividir_EntreCero_DebeLanzarExcepcion()
    {
        Calculadora calculadora = new Calculadora();

        Assert.Throws<ArgumentException>(() => calculadora.Dividir(10, 0));
    }
}