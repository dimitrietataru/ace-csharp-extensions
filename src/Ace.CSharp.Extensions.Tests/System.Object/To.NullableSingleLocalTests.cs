namespace Ace.CSharp.Extensions.Tests.ObjectExtensions;

public sealed class ToNullableSingleLocalTests
{
    [Fact]
    internal void GivenToNullableSingleLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object? @this = float.MaxValue;
        float expected = float.MaxValue;

        // Act
        float? actual = @this.ToNullableSingleLocal();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToNullableSingleLocalWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        object @this = "foo";

        // Act
        float? actual = @this.ToNullableSingleLocal();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToNullableSingleLocalWhenInputOverflownThenResultIsNull()
    {
        // Arrange
        object @this = $"{float.MaxValue}{float.MaxValue}";

        // Act
        float? actual = @this.ToNullableSingleLocal();

        // Assert
        actual.Should().BeNull();
    }
}
