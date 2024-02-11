namespace Ace.CSharp.Extensions.Tests.ObjectExtensions;

public sealed class ToNullableDoubleTests
{
    [Fact]
    internal void GivenToNullableDoubleWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object? @this = double.MaxValue;
        double expected = double.MaxValue;

        // Act
        double? actual = @this.ToNullableDouble(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToNullableDoubleWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        object @this = "foo";

        // Act
        double? actual = @this.ToNullableDouble(provider: default);

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToNullableDoubleWhenInputOverflownThenResultIsNull()
    {
        // Arrange
        object @this = $"{double.MaxValue}{double.MaxValue}";

        // Act
        double? actual = @this.ToNullableDouble(provider: default);

        // Assert
        actual.Should().BeNull();
    }
}
