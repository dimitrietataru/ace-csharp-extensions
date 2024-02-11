namespace Ace.CSharp.Extensions.Tests.ObjectExtensions;

public sealed class ToNullableSByteInvariantTests
{
    [Fact]
    internal void GivenToNullableSByteInvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object? @this = sbyte.MaxValue;
        sbyte expected = sbyte.MaxValue;

        // Act
        sbyte? actual = @this.ToNullableSByteInvariant();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToNullableSByteInvariantWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        object @this = "foo";

        // Act
        sbyte? actual = @this.ToNullableSByteInvariant();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToNullableSByteInvariantWhenInputOverflownThenResultIsNull()
    {
        // Arrange
        object @this = $"{sbyte.MaxValue}{sbyte.MaxValue}";

        // Act
        sbyte? actual = @this.ToNullableSByteInvariant();

        // Assert
        actual.Should().BeNull();
    }
}
