using NUnit.Framework;
using System;

namespace TestApp.Tests;

public class CharacterRangeTests
{
    [Test]
    public void Test_GetRange_WithAAndBInOrder_ReturnsEmptyString()
    {
        // Arrange
        char chOne = 'A';
        char chTwo = 'B';

        string expected = "";

        // Act
        string output = CharacterRange.GetRange(chOne, chTwo);

        // Assert
        Assert.That(output, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetRange_WithBAndAInOrder_ReturnsEmptyString()
    {
        // Arrange
        char chOne = 'B';
        char chTwo = 'A';

        string expected = "";

        // Act
        string output = CharacterRange.GetRange(chOne, chTwo);

        // Assert
        Assert.That(output, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetRange_WithAAndCInOrder_ReturnsB()
    {
        // Arrange
        char chOne = 'A';
        char chTwo = 'C';

        string expected = "B";

        // Act
        string output = CharacterRange.GetRange(chOne, chTwo);

        // Assert
        Assert.That(output, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetRange_WithDAndGInOrder_Returns_E_F()
    {
        // Arrange
        char chOne = 'D';
        char chTwo = 'G';

        string expected = "E F";

        // Act
        string output = CharacterRange.GetRange(chOne, chTwo);

        // Assert
        Assert.That(output, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetRange_WithXAndZInOrder_Returns_Y()
    {
        // Arrange
        char chOne = 'X';
        char chTwo = 'Z';

        string expected = "Y";

        // Act
        string output = CharacterRange.GetRange(chOne, chTwo);

        // Assert
        Assert.That(output, Is.EqualTo(expected));
    }
}
