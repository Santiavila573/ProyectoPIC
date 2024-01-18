using System;

// Clase abstracta para funciones lineales
abstract class FuncionLineal
{
    protected double Pendiente { get; set; }
    protected double OrdenadaOrigen { get; set; }

    public FuncionLineal(double pendiente, double ordenadaOrigen)
    {
        Pendiente = pendiente;
        OrdenadaOrigen = ordenadaOrigen;
    }

    public abstract double CalcularY(double x);
}

// Clase derivada para funciones lineales particulares
class FuncionLinealGeneral : FuncionLineal
{
    public FuncionLinealGeneral(double pendiente, double ordenadaOrigen) : base(pendiente, ordenadaOrigen) { }

    public override double CalcularY(double x)
    {
        return Pendiente * x + OrdenadaOrigen;
    }
}



