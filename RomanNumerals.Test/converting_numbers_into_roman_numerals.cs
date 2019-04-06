using System;
using Xunit;

// namespace RomanNumerals.Test
namespace BadSuperbowlNamer.Test
{
    public class converting_numbers_into_roman_numerals
    {
        [Fact]
        public void Translate_1_to_I()
        {
            // Arrange - giving context - given
            var converter = new TranslateEngine();
            int input = 1;
            var exceptedResult = "I";
            // Act - Do the Thing - When
            var actualResult = converter.DoWork(input);
            // Assert
            Assert.Equal(actualResult, exceptedResult);
        }

        [Fact]
        public void Translate_5_to_V()
        {
            // Arrange - giving context - given
            var converter = new TranslateEngine();
            int input = 5;
            var exceptedResult = "V";
            // Act - Do the Thing - When
            var actualResult = converter.DoWork(input);
            // Assert
            Assert.Equal(actualResult, exceptedResult);
        }

        [Fact]
        public void Translate_9_to_IX()
        {
            // Arrange - giving context - given
            var converter = new TranslateEngine();
            int input = 9;
            var exceptedResult = "IX";
            // Act - Do the Thing - When
            var actualResult = converter.DoWork(input);
            // Assert
            Assert.Equal(actualResult, exceptedResult);
        }

        [Fact]
        public void Translate_12_to_XII()
        {
            // Arrange - giving context - given
            var converter = new TranslateEngine();
            int input = 12;
            var exceptedResult = "XII";
            // Act - Do the Thing - When
            var actualResult = converter.DoWork(input);
            // Assert
            Assert.Equal(actualResult, exceptedResult);
        }

        [Fact]
        public void Translate_16_to_XVI()
        {
            // Arrange - giving context - given
            var converter = new TranslateEngine();
            int input = 16;
            var exceptedResult = "XVI";
            // Act - Do the Thing - When
            var actualResult = converter.DoWork(input);
            // Assert
            Assert.Equal(actualResult, exceptedResult);
        }

        [Fact]
        public void Translate_29_to_XXIX()
        {
            // Arrange - giving context - given
            var converter = new TranslateEngine();
            int input = 29;
            var exceptedResult = "XXIX";
            // Act - Do the Thing - When
            var actualResult = converter.DoWork(input);
            // Assert
            Assert.Equal(actualResult, exceptedResult);
        }

        [Fact]
        public void Translate_44_to_XLIV()
        {
            // Arrange - giving context - given
            var converter = new TranslateEngine();
            int input = 44;
            var exceptedResult = "XLIV";
            // Act - Do the Thing - When
            var actualResult = converter.DoWork(input);
            // Assert
            Assert.Equal(actualResult, exceptedResult);
        }

        [Fact]
        public void Translate_45_to_XLV()
        {
            // Arrange - giving context - given
            var converter = new TranslateEngine();
            int input = 45;
            var exceptedResult = "XLV";
            // Act - Do the Thing - When
            var actualResult = converter.DoWork(input);
            // Assert
            Assert.Equal(actualResult, exceptedResult);
        }

        [Fact]
        public void Translate_68_to_LXVIII()
        {
            // Arrange - giving context - given
            var converter = new TranslateEngine();
            int input = 68;
            var exceptedResult = "LXVIII";
            // Act - Do the Thing - When
            var actualResult = converter.DoWork(input);
            // Assert
            Assert.Equal(actualResult, exceptedResult);
        }

        [Fact]
        public void Translate_83_to_LXXXIII()
        {
            // Arrange - giving context - given
            var converter = new TranslateEngine();
            int input = 83;
            var exceptedResult = "LXXXIII";
            // Act - Do the Thing - When
            var actualResult = converter.DoWork(input);
            // Assert
            Assert.Equal(actualResult, exceptedResult);
        }

        [Fact]
        public void Translate_97_to_XCVII()
        {
            // Arrange - giving context - given
            var converter = new TranslateEngine();
            int input = 97;
            var exceptedResult = "XCVII";
            // Act - Do the Thing - When
            var actualResult = converter.DoWork(input);
            // Assert
            Assert.Equal(actualResult, exceptedResult);
        }

        [Fact]
        public void Translate_99_to_XCIX()
        {
            // Arrange - giving context - given
            var converter = new TranslateEngine();
            int input = 99;
            var exceptedResult = "XCIX";
            // Act - Do the Thing - When
            var actualResult = converter.DoWork(input);
            // Assert
            Assert.Equal(actualResult, exceptedResult);
        }

        [Fact]
        public void Translate_500_to_D()
        {
            // Arrange - giving context - given
            var converter = new TranslateEngine();
            int input = 500;
            var exceptedResult = "D";
            // Act - Do the Thing - When
            var actualResult = converter.DoWork(input);
            // Assert
            Assert.Equal(actualResult, exceptedResult);
        }

        [Fact]
        public void Translate_501_to_DI()
        {
            // Arrange - giving context - given
            var converter = new TranslateEngine();
            int input = 501;
            var exceptedResult = "DI";
            // Act - Do the Thing - When
            var actualResult = converter.DoWork(input);
            // Assert
            Assert.Equal(actualResult, exceptedResult);
        }

        [Fact]
        public void Translate_649_to_DCXLIX()
        {
            // Arrange - giving context - given
            var converter = new TranslateEngine();
            int input = 649;
            var exceptedResult = "DCXLIX";
            // Act - Do the Thing - When
            var actualResult = converter.DoWork(input);
            // Assert
            Assert.Equal(actualResult, exceptedResult);
        }

        [Fact]
        public void Translate_798_to_DCCXCVIII()
        {
            // Arrange - giving context - given
            var converter = new TranslateEngine();
            int input = 798;
            var exceptedResult = "DCCXCVIII";
            // Act - Do the Thing - When
            var actualResult = converter.DoWork(input);
            // Assert
            Assert.Equal(actualResult, exceptedResult);
        }

        [Fact]
        public void Translate_891_to_DCCCXCI()
        {
            // Arrange - giving context - given
            var converter = new TranslateEngine();
            int input = 891;
            var exceptedResult = "DCCCXCI";
            // Act - Do the Thing - When
            var actualResult = converter.DoWork(input);
            // Assert
            Assert.Equal(actualResult, exceptedResult);
        }

        [Fact]
        public void Translate_1000_to_M()
        {
            // Arrange - giving context - given
            var converter = new TranslateEngine();
            int input = 1000;
            var exceptedResult = "M";
            // Act - Do the Thing - When
            var actualResult = converter.DoWork(input);
            // Assert
            Assert.Equal(actualResult, exceptedResult);
        }

        [Fact]
        public void Translate_1004_to_MIV()
        {
            // Arrange - giving context - given
            var converter = new TranslateEngine();
            int input = 1004;
            var exceptedResult = "MIV";
            // Act - Do the Thing - When
            var actualResult = converter.DoWork(input);
            // Assert
            Assert.Equal(actualResult, exceptedResult);
        }

        [Fact]
        public void Translate_1006_to_MVI()
        {
            // Arrange - giving context - given
            var converter = new TranslateEngine();
            int input = 1006;
            var exceptedResult = "MVI";
            // Act - Do the Thing - When
            var actualResult = converter.DoWork(input);
            // Assert
            Assert.Equal(actualResult, exceptedResult);
        }

        [Fact]
        public void Translate_1023_to_MXXIII()
        {
            // Arrange - giving context - given
            var converter = new TranslateEngine();
            int input = 1023;
            var exceptedResult = "MXXIII";
            // Act - Do the Thing - When
            var actualResult = converter.DoWork(input);
            // Assert
            Assert.Equal(actualResult, exceptedResult);
        }

        [Fact]
        public void Translate_2014_to_MMXIV()
        {
            // Arrange - giving context - given
            var converter = new TranslateEngine();
            int input = 2014;
            var exceptedResult = "MMXIV";
            // Act - Do the Thing - When
            var actualResult = converter.DoWork(input);
            // Assert
            Assert.Equal(actualResult, exceptedResult);
        }

        [Fact]
        public void Translate_3999_to_MMMCMXCIX()
        {
            // Arrange - giving context - given
            var converter = new TranslateEngine();
            int input = 3999;
            var exceptedResult = "MMMCMXCIX";
            // Act - Do the Thing - When
            var actualResult = converter.DoWork(input);
            // Assert
            Assert.Equal(actualResult, exceptedResult);
        }


    }
}
