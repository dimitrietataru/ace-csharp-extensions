namespace Ace.CSharp.Extensions.Tests.ObjectExtensions;

public sealed class ToNullableByteTests
{
    [Fact]
    internal void GivenToNullableByteWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object? @this = byte.MaxValue;
        byte expected = byte.MaxValue;

        // Act
        byte? actual = @this.ToNullableByte(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToNullableByteWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        object @this = "foo";

        // Act
        byte? actual = @this.ToNullableByte(provider: default);

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToNullableByteWhenInputOverflownThenResultIsNull()
    {
        // Arrange
        object @this = $"{byte.MaxValue}{byte.MaxValue}";

        // Act
        byte? actual = @this.ToNullableByte(provider: default);

        // Assert
        actual.Should().BeNull();
    }
}
