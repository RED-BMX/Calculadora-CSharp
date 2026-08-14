namespace Calculadora_CSharp.Tests;

public class UnitTest1
{
    [Theory]
    [InlineData(5, 3, 8)]
    [InlineData(10, 20, 30)]
    [InlineData(-5, 3, -2)]
    [InlineData(0, 10, 10)]
    public void Sumar_DosNumeros_DebeRetornarLaSuma(
        double numero1,
        double numero2,
        double esperado)
    {
        var calculadora = new Calculadora();

        double resultado = calculadora.Sumar(numero1, numero2);

        Assert.Equal(esperado, resultado);
    }

    [Theory]
    [InlineData(10, 4, 6)]
    [InlineData(20, 5, 15)]
    [InlineData(5, 10, -5)]
    [InlineData(0, 8, -8)]
    public void Restar_DosNumeros_DebeRetornarLaResta(
        double numero1,
        double numero2,
        double esperado)
    {
        var calculadora = new Calculadora();

        double resultado = calculadora.Restar(numero1, numero2);

        Assert.Equal(esperado, resultado);
    }

    [Theory]
    [InlineData(5, 4, 20)]
    [InlineData(10, 3, 30)]
    [InlineData(0, 100, 0)]
    [InlineData(-5, 4, -20)]
    public void Multiplicar_DosNumeros_DebeRetornarElProducto(
        double numero1,
        double numero2,
        double esperado)
    {
        var calculadora = new Calculadora();

        double resultado = calculadora.Multiplicar(numero1, numero2);

        Assert.Equal(esperado, resultado);
    }

    [Theory]
    [InlineData(10, 2, 5)]
    [InlineData(20, 4, 5)]
    [InlineData(9, 3, 3)]
    [InlineData(-10, 2, -5)]
    public void Dividir_DosNumeros_DebeRetornarElResultado(
        double numero1,
        double numero2,
        double esperado)
    {
        var calculadora = new Calculadora();

        double resultado = calculadora.Dividir(numero1, numero2);

        Assert.Equal(esperado, resultado);
    }

    [Fact]
    public void Dividir_EntreCero_DebeLanzarExcepcion()
    {
        Calculadora calculadora = new Calculadora();

        Assert.Throws<ArgumentException>(() => calculadora.Dividir(10, 0));
    }
}