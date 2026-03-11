namespace Calculadora;

public class OperacionesMatematicas
{
    public double Sumar(double a, double b) => a + b;

    public double Restar(double a, double b) => a - b;

    public double Multiplicar(double a, double b) => a * b;

    public double Dividir(double a, double b)
    {
        if (b == 0)
            throw new DivideByZeroException("No se puede dividir por cero.");

        return a / b;
    }

    public bool EsPar(int numero) => numero % 2 == 0;
    public bool EsImpar(int numero) => numero % 2 != 0;

    public double Potencia(double baseNum, double exponente) => Math.Pow(baseNum, exponente);
}
