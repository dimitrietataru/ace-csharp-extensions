namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToNullableDecimalTests
{
    [Fact]
    internal void GivenToNullableDecimalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = decimal.MaxValue.ToString(CultureInfo.CurrentCulture);
        decimal expected = decimal.MaxValue;

        // Act
        decimal? actual = @this.ToNullableDecimal(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToNullableDecimalWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        string @this = "foo";

        // Act
        decimal? actual = @this.ToNullableDecimal(provider: default);

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToNullableDecimalWhenInputOverflownThenResultIsNull()
    {
        // Arrange
        string @this = $"{decimal.MaxValue}{decimal.MaxValue}";

        // Act
        decimal? actual = @this.ToNullableDecimal(provider: default);

        // Assert
        actual.Should().BeNull();
    }

    [Theory]
    [InlineData(null, null)]
    [InlineData("", null)]
    [InlineData(" ", null)]
    internal void GivenToNullableDecimalWhenInputIsNullOrWhiteSpaceThenResultIsExpected(string input, decimal? expected)
    {
        // Act
        decimal? actual = input.ToNullableDecimal(null);

        // Assert
        actual.Should().Be(expected);
    }
}
