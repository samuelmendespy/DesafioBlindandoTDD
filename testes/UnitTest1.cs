using System.ComponentModel;
using System.Runtime.InteropServices;
using calculadora;

namespace testes;

public class UnitTest1
{
    private Calculadora _calc;
    public UnitTest1()
    {
        _calc = new Calculadora();
    }

    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(4, 5, 9)]
    public void Somar_InserindoNum1Num2_DeveRetornarSomaDeNum1ComNum2(int num1, int num2, int resultadoEsperado)
    {
        // Act
       int resultadoAtual = _calc.Somar(num1,num2);

       // Assert
       Assert.Equal(resultadoEsperado, resultadoAtual);

    }

    [Theory]
    [InlineData(6, 2, 4)]
    [InlineData(5, 3, 2)]
    public void Subtrair_InserindoNum1Num2_DeveRetornarDiferencaDeNum1ENum2(int num1, int num2, int resultadoEsperado)
    {
        // Act
       int resultadoAtual = _calc.Subtrair(num1,num2);

       // Assert
       Assert.Equal(resultadoEsperado, resultadoAtual);

    }

    [Theory]
    [InlineData(1, 2, 2)]
    [InlineData(4, 5, 20)]
    public void Multiplicar_InserindoNum1Num2_DeveRetornarProdutoDeNum1ENum2(int num1, int num2, int resultadoEsperado)
    {
        // Act
       int resultadoAtual = _calc.Multiplicar(num1,num2);

       // Assert
       Assert.Equal(resultadoEsperado, resultadoAtual);

    }

    [Theory]
    [InlineData(6, 2, 3)]
    [InlineData(5, 5, 1)]
    public void Dividir_InserindoNum1Num2_DeveRetornarQuocienteDeNum1ENum2(int num1, int num2, int resultadoEsperado)
    {
        // Act
       double resultadoAtual = _calc.Dividir(num1,num2);

       // Assert
       Assert.Equal(resultadoEsperado, resultadoAtual);

    }


    [Fact]
    public void Dividir3Por0_DeveRetornarException()
    {
       // Assert
       Assert.Throws<DivideByZeroException>(() => _calc.Dividir(3,0));

    }

    [Fact]
    public void Historico_InserindoStrings_DeveRetornarUltimas3Strings()
    {
        // Act

        _calc.Somar(1, 2);
        _calc.Somar(3, 5);
        _calc.Somar(1, 6);
        _calc.Somar(2, 7);
        _calc.Somar(4, 7);
        List<string> resultadoAtual = _calc.Historico();


       // Assert
       Assert.NotEmpty(resultadoAtual);
       Assert.Equal(3, resultadoAtual.Count);

    }
}