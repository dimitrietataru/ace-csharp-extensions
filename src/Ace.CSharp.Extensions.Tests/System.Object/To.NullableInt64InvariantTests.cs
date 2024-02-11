namespace Ace.CSharp.Extensions.Tests.ObjectExtensions;

public sealed class ToNullableInt64InvariantTests
{
    [Fact]
    internal void GivenToNullableInt64InvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object? @this = long.MaxValue;
        long expected = long.MaxValue;

        // Act
        long? actual = @this.ToNullableInt64Invariant();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToNullableInt64InvariantWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        object @this = "foo";

        // Act
        long? actual = @this.ToNullableInt64Invariant();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToNullableInt64InvariantWhenInputOverflownThenResultIsNull()
    {
        // Arrange
        object @this = $"{long.MaxValue}{long.MaxValue}";

        // Act
        long? actual = @this.ToNullableInt64Invariant();

        // Assert
        actual.Should().BeNull();
    }
}
