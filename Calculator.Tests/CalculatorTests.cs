namespace Calculator.Tests;

public class CalculatorTests
{
    [Fact]
    public void TestAdd()
    {
        Assert.Equal(6L, Add.Eval(1L, 5L));
    }
    [Fact]
    public void TestSubtract()
    {
        Assert.Equal(10L, Subtract.Eval(15L, 5L));
    }
    [Fact]
    public void TestMult()
    {
        Assert.Equal(6L, Multiply.Eval(2L, 3L));
    }
    [Fact]
    public void TestDivide()
    {
        Assert.Equal(4L, Divide.Eval(12L, 3L));
    }
    [Fact]
    public void TestModulo()
    {
        Assert.Equal(1L, Modulo.Eval(10L, 3L));
    }

    [Fact]
    public void TestPower()
    {
        Assert.Equal(25L, Power.Eval(5L, 2L));
    }
    [Fact]
    public void TestAdd2()
    {
        Assert.Equal(22L, Add.Eval(16L, 6L));
    }
    [Fact]
    public void TestSubtract2()
    {
        Assert.Equal(15L, Subtract.Eval(23L, 8L));
    }
    [Fact]
    public void TestMult2()
    {
        Assert.Equal(20L, Multiply.Eval(4L, 5L));
    }
    [Fact]
    public void TestDivide2()
    {
        Assert.Equal(5L, Divide.Eval(40L, 8L));
    }
    [Fact]
    public void TestAdd3()
    {
        Assert.Equal(12L, Add.Eval(3L, 9L));
    }
    [Fact]
    public void TestSubtract3()
    {
        Assert.Equal(12L, Subtract.Eval(18L, 6L));
    }
    [Fact]
    public void TestMult3()
    {
        Assert.Equal(28L, Multiply.Eval(7L, 4L));
    }
    [Fact]
    public void TestDivide3()
    {
        Assert.Equal(5L, Divide.Eval(35L, 7L));
    }
    [Fact]
    public void TestAddOperation()
    {
        Assert.Equal(8, Evaluator.Eval("+", 6, 2));
    }
    [Fact]
    public void TestSubtractOperation()
    {
        Assert.Equal(4, Evaluator.Eval("-", 16, 12));
    }
    [Fact]
    public void TestMultiplyOperation()
    {
        Assert.Equal(12, Evaluator.Eval("*", 6, 2));
    }
    [Fact]
    public void TestDivideOperation()
    {
        Assert.Equal(4, Evaluator.Eval("/", 8, 2));
    }
    [Fact]
    public void TestModuloOperation()
    {
        Assert.Equal(2, Evaluator.Eval("%", 18, 4));
    }
    [Fact]
    public void TestPowerOperation()
    {
        Assert.Equal(27, Evaluator.Eval("^", 3, 3));
    }
    //[Fact]
    //public void TestInvalidOperation()
    //{
    //  Assert.Throws<Exception>(() => Evaluator.Eval("%", 9, 9));
    // }

    [Fact]
    public void TestContinueOperations()
    {
        // This test simulates continuous operations
        float result1 = Evaluator.Eval("+", 5, 10);
        Assert.Equal(15, result1);
        float result2 = Evaluator.Eval("-", result1, 5);
        Assert.Equal(10, result2);
        float result3 = Evaluator.Eval("*", result2, 2);
        Assert.Equal(20, result3);
        float result4 = Evaluator.Eval("/", result3, 4);
        Assert.Equal(5, result4);
        float result5 = Evaluator.Eval("%", result4, 2);
        Assert.Equal(1, result5);
        float result6 = Evaluator.Eval("^", result5, 2);
        Assert.Equal(1, result6);
    }

}