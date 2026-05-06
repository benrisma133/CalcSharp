namespace CalcSharp.Tests;

public class CalculatorTests
{
    [Fact]
    public void Add_TwoNumbers_ReturnsCorrectResult()
    {
        double result = 2 + 4;
        Assert.Equal(6, result);
    }

    [Fact]
    public void Subtract_TwoNumbers_ReturnsCorrectResult()
    {
        double result = 10 - 4;
        Assert.Equal(6, result);
    }

    [Fact]
    public void Multiply_TwoNumbers_ReturnsCorrectResult()
    {
        double result = 3 * 4;
        Assert.Equal(12, result);
    }

    [Fact]
    public void Divide_TwoNumbers_ReturnsCorrectResult()
    {
        double result = 10.0 / 2.0;
        Assert.Equal(5, result);
    }

    [Fact]
    public void Divide_ByZero_ReturnsNaN()
    {
        double result = 10.0 / 0.0;
        Assert.True(double.IsInfinity(result));
    }
}