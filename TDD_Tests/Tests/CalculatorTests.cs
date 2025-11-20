using Xunit.Sdk;
public class CalculatorTests
{
    Calculator calculator = new Calculator(5, 10);

    [Fact]
    public void Calculator_FieldAShouldBeCorrect()
    {
        Assert.Equal(5, calculator.A);
        Assert.Equal(10, calculator.B);
        Assert.NotEqual(50, calculator.A);
        Assert.NotEqual(-50, calculator.B);
    }

    [Fact]
    public void Calculator_AddShouldReturnFieldAPlusB()
    {
        Assert.Equal(15, calculator.Add());
    }

    [Fact]
    public void Calculator_SubtractShouldNotReturnFieldAMinusB()
    {
        Assert.NotEqual(5, calculator.Subtract(10, 8));
    }

    [Fact]
    public void Calculator_MultiplyShouldMultiply()
    {
        var sum = 8 * 2;
        Assert.Equal(sum, calculator.Multiply(8, 2));
    }

    [Fact]
    public void Calculator_DivideShouldThrowErrorWhenDividendIsZero()
    {
        Assert.Throws<DivideByZeroException>(() => calculator.Divide(5, 0));
    }

    [Fact]
    public void Calculator_DivideShouldReturnCorrectSum()
    {
        var sum = 8 / 2;
        Assert.Equal(sum, calculator.Divide(8, 2));
    }
}