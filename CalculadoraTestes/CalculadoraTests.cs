using Calculadora.Services;

namespace calculadoratestes;

public class CalculadoraTests
{
    private CalculadoraImp _calc;
    public CalculadoraTests()
    {
        _calc = new CalculadoraImp();
    }
    [Fact]  //xUnit usa fact
    public void DeveSomar5com10ERetornar15()
    {
        // Arrange
        int num1 = 5; 
        int num2 = 10;

        // Act
        int resultado = _calc.Somar(num1,num2);

        // Assert
        Assert.Equal(15 , resultado);        
    }

    [Fact]  //xUnit usa fact
    public void DeveVerificarSeONumeroEPar()
    {
        // Arrange
        int num = 4; 
        // Act
        bool resultado = _calc.ItsPair(num);
        // Assert
        Assert.True(resultado);
    }
}