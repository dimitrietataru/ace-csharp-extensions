namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToNullableDecimalLocalTests
{
    [Fact]
    internal void GivenToNullableDecimalLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = decimal.MaxValue.ToString(CultureInfo.CurrentCulture);
        decimal expected = decimal.MaxValue;

        // Act
        decimal? actual = @this.ToNullableDecimalLocal();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToNullableDecimalLocalWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        string @this = "foo";

        // Act
        decimal? actual = @this.ToNullableDecimalLocal();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToNullableDecimalLocalWhenInputOverflownThenResultIsNull()
    {
        // Arrange
        string @this = $"{decimal.MaxValue}{decimal.MaxValue}";

        // Act
        decimal? actual = @this.ToNullableDecimalLocal();

        // Assert
        actual.Should().BeNull();
    }
}
