namespace Ace.CSharp.Extensions.Tests.ObjectExtensions;

public sealed class ToNullableDecimalTests
{
    [Fact]
    internal void GivenToNullableDecimalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object? @this = decimal.MaxValue;
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
        object @this = "foo";

        // Act
        decimal? actual = @this.ToNullableDecimal(provider: default);

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToNullableDecimalWhenInputOverflownThenResultIsNull()
    {
        // Arrange
        object @this = $"{decimal.MaxValue}{decimal.MaxValue}";

        // Act
        decimal? actual = @this.ToNullableDecimal(provider: default);

        // Assert
        actual.Should().BeNull();
    }
}
