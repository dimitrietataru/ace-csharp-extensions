namespace Ace.CSharp.Extensions.Tests.ObjectExtensions;

public sealed class ToNullableInt64LocalTests
{
    [Fact]
    internal void GivenToNullableInt64LocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object? @this = long.MaxValue;
        long expected = long.MaxValue;

        // Act
        long? actual = @this.ToNullableInt64Local();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToNullableInt64LocalWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        object @this = "foo";

        // Act
        long? actual = @this.ToNullableInt64Local();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToNullableInt64LocalWhenInputOverflownThenResultIsNull()
    {
        // Arrange
        object @this = $"{long.MaxValue}{long.MaxValue}";

        // Act
        long? actual = @this.ToNullableInt64Local();

        // Assert
        actual.Should().BeNull();
    }
}
