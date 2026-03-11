using Calculadora;

namespace Calculadora.Tests;

public class OperacionesMatematicasTests
{
    private readonly OperacionesMatematicas _operaciones = new();

    [Fact]
    public void Sumar_DosPositivos_RetornaSuma()
    {
        double resultado = _operaciones.Sumar(3, 5);
        Assert.Equal(8, resultado);
    }

    [Fact]
    public void Sumar_PosYNeg_RetornaSuma()
    {
        double resultado = _operaciones.Sumar(3, -4);
        Assert.Equal(-1, resultado);
    }

    [Fact]
    public void Sumar_DosNegativos_RetornaSuma()
    {
        double resultado = _operaciones.Sumar(-3, -5);
        Assert.Equal(-8, resultado);
    }

    [Fact]
    public void Sumar_Cero_RetornaSuma()
    {
        double resultado = _operaciones.Sumar(3, 0);
        Assert.Equal(3, resultado);
    }

    [Fact]
    public void Sumar_CeroYNegativo_RetornaSuma()
    {
        double resultado = _operaciones.Sumar(0, -4);
        Assert.Equal(-4, resultado);
    }

    [Fact]
    public void Sumar_CeroYPositivo_RetornaSuma()
    {
        double resultado = _operaciones.Sumar(0, 5);
        Assert.Equal(5, resultado);
    }

    [Fact]
    public void Sumar_CeroYCero_RetornaSuma()
    {
        double resultado = _operaciones.Sumar(0, 0);
        Assert.Equal(0, resultado);
    }
}
