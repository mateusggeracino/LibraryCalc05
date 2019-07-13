using LibraryCalc05.Interfaces;
using LibraryCalc05.Models;

namespace LibraryCalc05.Business
{
    /// <summary>
    /// Classe responsável por implementar o corpo dos métodos de calculo
    /// </summary>
    public class Calc : ICalc
    {
        /// <summary>
        /// Responsavel por somar valores
        /// </summary>
        /// <param name="valores">Entidade que contém propriedades com valores</param>
        /// <returns></returns>
        public double Adicao(Valores valores) => valores.ValorA + valores.ValorB;

        public double Adicao(Valores valores, int valorAleatorio) => valores.ValorA + valores.ValorB + valorAleatorio;

        /// <summary>
        /// Responsavel por dividir o valor A por valor B.
        /// Ao tentar dividir por zero, será retornado 0.
        /// </summary>
        /// <param name="valores">Entidade que contém propriedades com valores</param>
        /// <returns></returns>
        public double Divisao(Valores valores)
        {
            if (valores.ValorA == 0 || valores.ValorB == 0) return 0;

            return valores.ValorA / valores.ValorB;
        }

        /// <summary>
        /// Responsável por multiplicar valor A com valor B
        /// </summary>
        /// <param name="valores">Entidade que contém propriedades com valores</param>
        /// <returns></returns>
        public double Multiplicacao(Valores valores) => valores.ValorA * valores.ValorB;

        /// <summary>
        /// Responsavel por subtrair o valor B do valor A
        /// </summary>
        /// <param name="valores">Entidade que contém propriedades com valores</param>
        /// <returns></returns>
        public double Subtracao(Valores valores) => valores.ValorA - valores.ValorB;
    }
}
