using NUnit.Framework;

namespace TestApp.UnitTests;

public class CalculateTests
{
    [Test]
    public void Test_Addition_WhenParametersArePositive()
    {
        // Arrange
        Calculate calculator = new();


        // Act
        int actual = calculator.Addition(5, 2);

        // Assert
        Assert.AreEqual(7, actual, "Addition did not work properly.");
    }

    [Test]
    public void Test_Addition_WhenParametersAreNegative()
    {
        // Arrange
        Calculate calculator = new();

        //Act
        int actual = calculator.Addition(-5, -2);

        //Assert
        Assert.AreEqual(-7, actual);
    }

    [Test]
    public void Test_Subtraction()
    {
        // TODO: Write your test here...
        // Arrange
        Calculate calculator = new();

        //Act
        int actual = calculator.Subtraction(5, 2);

        //Assert
        Assert.AreEqual(3, actual);

    }
}
