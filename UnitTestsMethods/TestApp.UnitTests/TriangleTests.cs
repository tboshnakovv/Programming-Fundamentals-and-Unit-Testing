using NUnit.Framework;

namespace TestApp.UnitTests;

public class TriangleTests
{
    [Test]
    public void Test_Triangle_OutputMatchesExpected_Size0()
    {
        // Arrange
        int input = 0;

        // Act
        string result = Triangle.PrintTriangle(input);

        // Assert
        Assert.AreEqual("", result);
    }

    [Test]
    public void Test_Triangle_OutputMatchesExpected_Size3()
    {
        //Arrange
        int input = 3;

        string expectedOutput = "1" +
            "\r\n" +
            "1 2\r\n" +
            "1 2 3\r\n" +
            "1 2\r\n" +
            "1";

        //Act
        string result = Triangle.PrintTriangle(input);

        //Assert
        Assert.AreEqual (expectedOutput, result);
    }

    [Test]
    public void Test_Triangle_OutputMatchesExpected_Size5()
    {
        // Arrange
        int input = 5;
        string expectedOutput = "1\r\n" +
            "1 2\r\n" +
            "1 2 3\r\n" +
            "1 2 3 4\r\n" +
            "1 2 3 4 5\r\n" +
            "1 2 3 4\r\n" +
            "1 2 3\r\n" +
            "1 2\r\n" +
            "1";


        // Act
        string result = Triangle.PrintTriangle(input);

        // Assert
        Assert.AreEqual(expectedOutput, result);
    }
}
