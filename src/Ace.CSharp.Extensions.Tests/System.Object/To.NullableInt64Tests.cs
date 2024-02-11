namespace Ace.CSharp.Extensions.Tests.ObjectExtensions;

public sealed class ToNullableInt64Tests
{
    [Fact]
    internal void GivenToNullableInt64WhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object? @this = long.MaxValue;
        long expected = long.MaxValue;

        // Act
        long? actual = @this.ToNullableInt64(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToNullableInt64WhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        object @this = "foo";

        // Act
        long? actual = @this.ToNullableInt64(provider: default);

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToNullableInt64WhenInputOverflownThenResultIsNull()
    {
        // Arrange
        object @this = $"{long.MaxValue}{long.MaxValue}";

        // Act
        long? actual = @this.ToNullableInt64(provider: default);

        // Assert
        actual.Should().BeNull();
    }
}
