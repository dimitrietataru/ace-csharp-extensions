namespace Ace.CSharp.Extensions.Tests.ObjectExtensions;

public sealed class ToNullableInt16InvariantTests
{
    [Fact]
    internal void GivenToNullableInt16InvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object? @this = short.MaxValue;
        short expected = short.MaxValue;

        // Act
        short? actual = @this.ToNullableInt16Invariant();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToNullableInt16InvariantWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        object @this = "foo";

        // Act
        short? actual = @this.ToNullableInt16Invariant();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToNullableInt16InvariantWhenInputOverflownThenResultIsNull()
    {
        // Arrange
        object @this = $"{short.MaxValue}{short.MaxValue}";

        // Act
        short? actual = @this.ToNullableInt16Invariant();

        // Assert
        actual.Should().BeNull();
    }
}
