using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPIC
{
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
}
