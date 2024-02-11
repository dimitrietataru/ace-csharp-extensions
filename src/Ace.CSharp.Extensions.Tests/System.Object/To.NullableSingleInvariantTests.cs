namespace Ace.CSharp.Extensions.Tests.ObjectExtensions;

public sealed class ToNullableSingleInvariantTests
{
    [Fact]
    internal void GivenToNullableSingleInvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object? @this = float.MaxValue;
        float expected = float.MaxValue;

        // Act
        float? actual = @this.ToNullableSingleInvariant();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToNullableSingleInvariantWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        object @this = "foo";

        // Act
        float? actual = @this.ToNullableSingleInvariant();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToNullableSingleInvariantWhenInputOverflownThenResultIsNull()
    {
        // Arrange
        object @this = $"{float.MaxValue}{float.MaxValue}";

        // Act
        float? actual = @this.ToNullableSingleInvariant();

        // Assert
        actual.Should().BeNull();
    }
}
