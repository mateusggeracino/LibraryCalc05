using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryCalc05.Models
{
    /// <summary>
    /// Entidade que contém propriedades dos valores
    /// </summary>
    public class Valores
    {
        public double ValorA { get; private set; }
        public double ValorB { get; private set; }

        public void AdicionarValorA(double valorA) => ValorA = valorA;
        public void AdicionarValorB(double valorB) => ValorB = valorB;
    }
}
