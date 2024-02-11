namespace Ace.CSharp.Extensions.Tests.ObjectExtensions;

public sealed class ToNullableDecimalLocalTests
{
    [Fact]
    internal void GivenToNullableDecimalLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object? @this = decimal.MaxValue;
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
        object @this = "foo";

        // Act
        decimal? actual = @this.ToNullableDecimalLocal();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToNullableDecimalLocalWhenInputOverflownThenResultIsNull()
    {
        // Arrange
        object @this = $"{decimal.MaxValue}{decimal.MaxValue}";

        // Act
        decimal? actual = @this.ToNullableDecimalLocal();

        // Assert
        actual.Should().BeNull();
    }
}
