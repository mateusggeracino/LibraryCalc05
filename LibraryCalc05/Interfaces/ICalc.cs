using LibraryCalc05.Models;

namespace LibraryCalc05.Interfaces
{
    /// <summary>
    /// Interface responsável por garantir a implementação dos métodos de calculo
    /// </summary>
    public interface ICalc
    {
        double Adicao(Valores valores);
        double Adicao(Valores valores, int valorAleatorio);
        double Subtracao(Valores valores);
        double Subtracao(Valores valores, int valorAleatorio);
        double Multiplicacao(Valores valores);
        double Divisao(Valores valores);
    }
}
