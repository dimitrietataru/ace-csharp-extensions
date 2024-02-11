namespace Ace.CSharp.Extensions.Tests.ObjectExtensions;

public sealed class ToNullableByteInvariantTests
{
    [Fact]
    internal void GivenToNullableByteInvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object? @this = byte.MaxValue;
        byte expected = byte.MaxValue;

        // Act
        byte? actual = @this.ToNullableByteInvariant();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToNullableByteInvariantWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        object @this = "foo";

        // Act
        byte? actual = @this.ToNullableByteInvariant();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToNullableByteInvariantWhenInputOverflownThenResultIsNull()
    {
        // Arrange
        object @this = $"{byte.MaxValue}{byte.MaxValue}";

        // Act
        byte? actual = @this.ToNullableByteInvariant();

        // Assert
        actual.Should().BeNull();
    }
}
