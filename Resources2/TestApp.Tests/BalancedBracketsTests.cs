using System;
using System.Collections.Generic;
using NUnit.Framework;
using static NUnit.Framework.Constraints.Tolerance;

namespace TestApp.Tests;

public class BalancedBracketsTests
{
    [Test]
    public void Test_IsBalanced_EmptyInput_ShouldReturnTrue()
    {
        // Arrange
        string[] arr = Array.Empty<string>();

        bool expected = true;

        // Act
        bool output = BalancedBrackets.IsBalanced(arr);

        // Assert
        Assert.That(output, Is.EqualTo(expected));

    }

    [Test]
    public void Test_IsBalanced_BalancedBrackets_ShouldReturnTrue()
    {
        // Arrange
        string[] arr = new string[] { "(", ")", "(", ")" };


        bool expected = true;

        // Act
        bool output = BalancedBrackets.IsBalanced(arr);

        // Assert
        Assert.That(output, Is.EqualTo(expected));
    }

    [Test]
    public void Test_IsBalanced_UnbalancedBrackets_ShouldReturnFalse()
    {
        // Arrange
        string[] arr = new string[] { ")", "(", ")" };


        bool expected = false;

        // Act
        bool output = BalancedBrackets.IsBalanced(arr);

        // Assert
        Assert.That(output, Is.EqualTo(expected));
    }

    [Test]
    public void Test_IsBalanced_MoreClosingBrackets_ShouldReturnFalse()
    {
        // Arrange
        string[] arr = new string[] { "(", ")", "(", ")", ")" };


        bool expected = false;

        // Act
        bool output = BalancedBrackets.IsBalanced(arr);

        // Assert
        Assert.That(output, Is.EqualTo(expected));
    }

    [Test]
    public void Test_IsBalanced_NoClosingBrackets_ShouldReturnFalse()
    {
        // Arrange
        string[] arr = new string[] { "(", "(" };


        bool expected = false;

        // Act
        bool output = BalancedBrackets.IsBalanced(arr);

        // Assert
        Assert.That(output, Is.EqualTo(expected));
    }
}
