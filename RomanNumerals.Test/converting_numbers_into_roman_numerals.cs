using System;
using Xunit;

// namespace RomanNumerals.Test
namespace BadSuperbowlNamer.Test
{
    public class converting_numbers_into_roman_numerals
    {
        [Fact]
        public void one_should_translate_to_I()
        {
            // Arrange - giving context - given
            var converter = new TranslateEngine();
            var input = "1";
            var exceptedResult = "I";
            // Act - Do the Thing - When
            var actualResult = converter.DoWork(input);
            // Assert
            Assert.Equal(actualResult, exceptedResult);
        }

        [Fact]
        public void five_should_translate_to_V()
        {
            // Arrange 
            // Act 
            // Assert

        }
    }
}
