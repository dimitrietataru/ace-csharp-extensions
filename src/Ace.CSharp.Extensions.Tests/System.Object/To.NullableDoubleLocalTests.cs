namespace Ace.CSharp.Extensions.Tests.ObjectExtensions;

public sealed class ToNullableDoubleLocalTests
{
    [Fact]
    internal void GivenToNullableDoubleLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object? @this = double.MaxValue;
        double expected = double.MaxValue;

        // Act
        double? actual = @this.ToNullableDoubleLocal();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToNullableDoubleLocalWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        object @this = "foo";

        // Act
        double? actual = @this.ToNullableDoubleLocal();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToNullableDoubleLocalWhenInputOverflownThenResultIsNull()
    {
        // Arrange
        object @this = $"{double.MaxValue}{double.MaxValue}";

        // Act
        double? actual = @this.ToNullableDoubleLocal();

        // Assert
        actual.Should().BeNull();
    }
}
