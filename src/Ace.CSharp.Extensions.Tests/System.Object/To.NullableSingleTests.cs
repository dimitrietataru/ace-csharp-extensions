namespace Ace.CSharp.Extensions.Tests.ObjectExtensions;

public sealed class ToNullableSingleTests
{
    [Fact]
    internal void GivenToNullableSingleWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object? @this = float.MaxValue;
        float expected = float.MaxValue;

        // Act
        float? actual = @this.ToNullableSingle(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToNullableSingleWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        object @this = "foo";

        // Act
        float? actual = @this.ToNullableSingle(provider: default);

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToNullableSingleWhenInputOverflownThenResultIsNull()
    {
        // Arrange
        object @this = $"{float.MaxValue}{float.MaxValue}";

        // Act
        float? actual = @this.ToNullableSingle(provider: default);

        // Assert
        actual.Should().BeNull();
    }
}
