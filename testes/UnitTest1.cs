using calculadora;

namespace testes;

public class UnitTest1
{
    private Calculadora _calc;
    private int num1;
    private int num2;

    public UnitTest1()
    {
        _calc = new Calculadora();
    }

    [Theory]
    [InlineData(1, 2, 3)]
    public void Somar_InserindoNum1Num2_DeveRetornarSomaDeNum1ComNum2(int num1, int num2, int resultadoEsperado)
    {
        // Arrange
        // num1 = 1;
        // num2 = 2;

        // Act
       int resultadoAtual = _calc.Somar(num1,num2);

       // Assert
       Assert.Equal(resultadoEsperado, resultadoAtual);

    }
}