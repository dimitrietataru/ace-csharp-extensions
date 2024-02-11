namespace Ace.CSharp.Extensions.Tests.ObjectExtensions;

public sealed class ToNullableByteLocalTests
{
    [Fact]
    internal void GivenToNullableByteLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object? @this = byte.MaxValue;
        byte expected = byte.MaxValue;

        // Act
        byte? actual = @this.ToNullableByteLocal();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToNullableByteLocalWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        object @this = "foo";

        // Act
        byte? actual = @this.ToNullableByteLocal();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToNullableByteLocalWhenInputOverflownThenResultIsNull()
    {
        // Arrange
        object @this = $"{byte.MaxValue}{byte.MaxValue}";

        // Act
        byte? actual = @this.ToNullableByteLocal();

        // Assert
        actual.Should().BeNull();
    }
}
