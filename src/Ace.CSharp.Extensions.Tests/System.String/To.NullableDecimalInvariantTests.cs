namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToNullableDecimalInvariantTests
{
    [Fact]
    internal void GivenToNullableDecimalInvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = decimal.MaxValue.ToString(CultureInfo.CurrentCulture);
        decimal expected = decimal.MaxValue;

        // Act
        decimal? actual = @this.ToNullableDecimalInvariant();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToNullableDecimalInvariantWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        string @this = "foo";

        // Act
        decimal? actual = @this.ToNullableDecimalInvariant();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToNullableDecimalInvariantWhenInputOverflownThenResultIsNull()
    {
        // Arrange
        string @this = $"{decimal.MaxValue}{decimal.MaxValue}";

        // Act
        decimal? actual = @this.ToNullableDecimalInvariant();

        // Assert
        actual.Should().BeNull();
    }
}
