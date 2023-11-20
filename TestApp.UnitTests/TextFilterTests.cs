using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class TextFilterTests
{
    // TODO: finish the test
    [Test]
    public void Test_Filter_WhenNoBannedWords_ShouldReturnOriginalText()
    {
        string text = "The quick brown fox jumps over the lazy dog";
        string[] banned = new string[] {"bear"};

        string result = TextFilter.Filter(banned, text);

        // Assert
        Assert.That(result, Is.EqualTo(text));
    }

    [Test]
    public void Test_Filter_WhenBannedWordExists_ShouldReplaceBannedWordWithAsterisks()
    {
        string text = "The quick brown fox jumps over the lazy dog";
        string[] banned = new string[] { "fox"};
        string expected = "The quick brown *** jumps over the lazy dog";

        string result = TextFilter.Filter(banned, text);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Filter_WhenBannedWordsAreEmpty_ShouldReturnOriginalText()
    {
        string text = "The quick brown fox jumps over the lazy dog";
        string[] banned = Array.Empty<string>();

        string result = TextFilter.Filter(banned, text);

        // Assert
        Assert.That(result, Is.EqualTo(text));
    }

    [Test]
    public void Test_Filter_WhenBannedWordsContainWhitespace_ShouldReplaceBannedWord()
    {
        string text = "The quick brown fox jumps over the lazy dog";
        string[] banned = new string[] { "brown fox","dog" };
        string expected = "The quick ********* jumps over the lazy ***";

        string result = TextFilter.Filter(banned, text);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
