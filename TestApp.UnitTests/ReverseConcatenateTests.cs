using NUnit.Framework;

using System;
using System.Linq;

namespace TestApp.UnitTests;

public class ReverseConcatenateTests
{
    // TODO: finish the test
    [Test]
    public void Test_ReverseAndConcatenateStrings_EmptyInput_ReturnsEmptyString()
    {
        string[] input = Array.Empty<string>();

        
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        Assert.That(result, Is.Empty);
    }

    // TODO: finish the test
    [Test]
    public void Test_ReverseAndConcatenateStrings_SingleString_ReturnsSameString()
    {
        string[] input = new[] {"blabla"};


        string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        Assert.That(result, Is.EqualTo("blabla"));
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_MultipleStrings_ReturnsReversedConcatenatedString()
    {
        string[] input = new[] { "blabla","alabala","lol" };


        string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        Assert.That(result, Is.EqualTo("lolalabalablabla"));
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_NullInput_ReturnsEmptyString()
    {
        string[] input = null;


        string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        Assert.That(result, Is.Empty);

    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_WhitespaceInput_ReturnsConcatenatedString()
    {
        string[] input = new[] { "   ", "  ", " " };


        string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        Assert.That(result, Is.EqualTo("      "));
    }
    [Test]
    public void Test_ReverseAndConcatenateStrings_LargeInput_ReturnsReversedConcatenatedString()
    {
        string[] input = new[] { "blabla", "alabala", "lol" , "alabala", "lol" , "alabala", "lol" };


        string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        Assert.That(result, Is.EqualTo("lolalabalalolalabalalolalabalablabla"));
    }
}
