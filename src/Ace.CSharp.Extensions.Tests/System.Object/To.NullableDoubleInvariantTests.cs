namespace Ace.CSharp.Extensions.Tests.ObjectExtensions;

public sealed class ToNullableDoubleInvariantTests
{
    [Fact]
    internal void GivenToNullableDoubleInvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object? @this = double.MaxValue;
        double expected = double.MaxValue;

        // Act
        double? actual = @this.ToNullableDoubleInvariant();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToNullableDoubleInvariantWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        object @this = "foo";

        // Act
        double? actual = @this.ToNullableDoubleInvariant();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToNullableDoubleInvariantWhenInputOverflownThenResultIsNull()
    {
        // Arrange
        object @this = $"{double.MaxValue}{double.MaxValue}";

        // Act
        double? actual = @this.ToNullableDoubleInvariant();

        // Assert
        actual.Should().BeNull();
    }
}
