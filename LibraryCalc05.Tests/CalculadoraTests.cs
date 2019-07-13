using LibraryCalc05.Business;
using LibraryCalc05.Models;
using Xunit;

namespace LibraryCalc05.Tests
{
    public class CalculadoraTests
    {
        [Fact]
        public void SomarSucesso()
        {
            //Arrange
            var valores = new Valores();
            valores.AdicionarValorA(10);
            valores.AdicionarValorB(10);
            var calc = new Calc();

            //Act
            var resultado = calc.Adicao(valores);

            //Assert
            Assert.True(valores.ValorA + valores.ValorB == resultado);
        }

        [Theory]
        [InlineData(10)]
        [InlineData(5)]
        [InlineData(1)]
        public void SomarAleatorioSucesso(int valorAleatorio)
        {
            //Arrange
            var valores = new Valores();
            valores.AdicionarValorA(10);
            valores.AdicionarValorB(10);
            var calc = new Calc();

            //Act
            var resultado = calc.Adicao(valores, valorAleatorio);

            //Assert
            Assert.True(valores.ValorA + valores.ValorB+valorAleatorio == resultado);
        }

        [Fact]
        public void SubtrairSucesso()
        {
            //Arrange
            var valores = new Valores();
            valores.AdicionarValorA(10);
            valores.AdicionarValorB(10);
            var calc = new Calc();

            //Act
            var resultado = calc.Subtracao(valores);

            //Assert
            Assert.True(valores.ValorA - valores.ValorB == resultado);
        }

        [Theory]
        [InlineData(10)]
        [InlineData(5)]
        [InlineData(1)]
        public void SubtrairAleatorioSucesso(int valorAleatorio)
        {
            //Arrange
            var valores = new Valores();
            valores.AdicionarValorA(10);
            valores.AdicionarValorB(10);
            var calc = new Calc();

            //Act
            var resultado = calc.Subtracao(valores, valorAleatorio);

            //Assert
            Assert.True(valores.ValorA - valores.ValorB - valorAleatorio == resultado);
        }

        [Fact]
        public void MultiplicarSucesso()
        {
            //Arrange
            var valores = new Valores();
            valores.AdicionarValorA(10);
            valores.AdicionarValorB(10);
            var calc = new Calc();

            //Act
            var resultado = calc.Multiplicacao(valores);

            //Assert
            Assert.True(valores.ValorA * valores.ValorB == resultado);
        }

        [Fact]
        public void DivisaoSucesso()
        {
            //Arrange
            var valores = new Valores();
            valores.AdicionarValorA(10);
            valores.AdicionarValorB(10);
            var calc = new Calc();

            //Act
            var resultado = calc.Divisao(valores);

            //Assert
            Assert.True(valores.ValorA / valores.ValorB == resultado);
        }
                     

        [Fact]
        public void SomarFalha()
        {
            //Arrange
            var valores = new Valores();
            valores.AdicionarValorA(10);
            valores.AdicionarValorB(10);
            var calc = new Calc();

            //Act
            var resultado = calc.Adicao(valores);

            //Assert
            Assert.False(valores.ValorA + valores.ValorB != resultado);
        }

        [Fact]
        public void SubtrairFalha()
        {
            //Arrange
            var valores = new Valores();
            valores.AdicionarValorA(10);
            valores.AdicionarValorB(10);
            var calc = new Calc();

            //Act
            var resultado = calc.Subtracao(valores);

            //Assert
            Assert.False(valores.ValorA - valores.ValorB != resultado);
        }

        [Fact]
        public void MultiplicarFalha()
        {
            //Arrange
            var valores = new Valores();
            valores.AdicionarValorA(10);
            valores.AdicionarValorB(10);
            var calc = new Calc();

            //Act
            var resultado = calc.Multiplicacao(valores);

            //Assert
            Assert.False(valores.ValorA * valores.ValorB != resultado);
        }

        [Fact]
        public void DivisaoFalha()
        {
            //Arrange
            var valores = new Valores();
            valores.AdicionarValorA(10);
            valores.AdicionarValorB(10);
            var calc = new Calc();

            //Act
            var resultado = calc.Divisao(valores);

            //Assert
            Assert.False(valores.ValorA / valores.ValorB  != resultado);
        }

        [Theory]
        [InlineData(10)]
        [InlineData(5)]
        [InlineData(1)]
        public void SomarAleatorioFalha(int valorAleatorio)
        {
            //Arrange
            var valores = new Valores();
            valores.AdicionarValorA(10);
            valores.AdicionarValorB(10);
            var calc = new Calc();

            //Act
            var resultado = calc.Adicao(valores, valorAleatorio);

            //Assert
            Assert.False(valores.ValorA + valores.ValorB + valorAleatorio != resultado);
        }

        [Theory]
        [InlineData(10)]
        [InlineData(5)]
        [InlineData(1)]
        public void SubtrairAleatorioFalha(int valorAleatorio)
        {
            //Arrange
            var valores = new Valores();
            valores.AdicionarValorA(10);
            valores.AdicionarValorB(10);
            var calc = new Calc();

            //Act
            var resultado = calc.Subtracao(valores, valorAleatorio);

            //Assert
            Assert.False(valores.ValorA - valores.ValorB - valorAleatorio != resultado);
        }

    }
}
