namespace Ace.CSharp.Extensions.Tests.ObjectExtensions;

public sealed class ToNullableDecimalInvariantTests
{
    [Fact]
    internal void GivenToNullableDecimalInvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object? @this = decimal.MaxValue;
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
        object @this = "foo";

        // Act
        decimal? actual = @this.ToNullableDecimalInvariant();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToNullableDecimalInvariantWhenInputOverflownThenResultIsNull()
    {
        // Arrange
        object @this = $"{decimal.MaxValue}{decimal.MaxValue}";

        // Act
        decimal? actual = @this.ToNullableDecimalInvariant();

        // Assert
        actual.Should().BeNull();
    }
}
