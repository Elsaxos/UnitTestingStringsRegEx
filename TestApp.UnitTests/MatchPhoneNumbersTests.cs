using NUnit.Framework;
using System;

namespace TestApp.UnitTests
{
    [TestFixture]
    public class MatchPhoneNumbersTests
    {
        // TODO: finish the test
        [Test]
        public void Test_Match_ValidPhoneNumbers_ReturnsMatchedNumbers()
        {
            // Arrange
            string phoneNumbers = "+359-2-124-5678, +359 2 986 5432, +359-2-555-5555";

            string expected = "+359-2-124-5678, +359 2 986 5432, +359-2-555-5555";
            string result = MatchPhoneNumbers.Match(phoneNumbers);

            // Print the actual result for debugging
            Console.WriteLine("Actual Result: " + result);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }


        [Test]
        public void Test_Match_NoValidPhoneNumbers_ReturnsEmptyString()
        {
            // Arrange
            string phoneNumbers = "359-2-124-5678, +359  986 5432, +359-2-5-5555";

            string expected = "";
            string result = MatchPhoneNumbers.Match(phoneNumbers);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test_Match_EmptyInput_ReturnsEmptyString()
        {
            // Arrange
            string phoneNumbers = "";

            string expected = "";
            string result = MatchPhoneNumbers.Match(phoneNumbers);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test_Match_MixedValidAndInvalidNumbers_ReturnsOnlyValidNumbers()
        {
            // Arrange
            string phoneNumbers = "+359-2-124-5678, +359 2 986 5432, +359-2-555-55";

            string expected = "+359-2-124-5678, +359 2 986 5432";
            string result = MatchPhoneNumbers.Match(phoneNumbers);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
