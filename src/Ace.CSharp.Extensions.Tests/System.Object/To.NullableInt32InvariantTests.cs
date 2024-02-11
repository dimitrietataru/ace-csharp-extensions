namespace Ace.CSharp.Extensions.Tests.ObjectExtensions;

public sealed class ToNullableInt32InvariantTests
{
    [Fact]
    internal void GivenToNullableInt32InvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object? @this = int.MaxValue;
        int expected = int.MaxValue;

        // Act
        int? actual = @this.ToNullableInt32Invariant();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToNullableInt32InvariantWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        object @this = "foo";

        // Act
        int? actual = @this.ToNullableInt32Invariant();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToNullableInt32InvariantWhenInputOverflownThenResultIsNull()
    {
        // Arrange
        object @this = $"{int.MaxValue}{int.MaxValue}";

        // Act
        int? actual = @this.ToNullableInt32Invariant();

        // Assert
        actual.Should().BeNull();
    }
}
