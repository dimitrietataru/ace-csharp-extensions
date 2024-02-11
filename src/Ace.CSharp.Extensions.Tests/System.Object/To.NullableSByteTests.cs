namespace Ace.CSharp.Extensions.Tests.ObjectExtensions;

public sealed class ToNullableSByteTests
{
    [Fact]
    internal void GivenToNullableSByteWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object? @this = sbyte.MaxValue;
        sbyte expected = sbyte.MaxValue;

        // Act
        sbyte? actual = @this.ToNullableSByte(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToNullableSByteWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        object @this = "foo";

        // Act
        sbyte? actual = @this.ToNullableSByte(provider: default);

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToNullableSByteWhenInputOverflownThenResultIsNull()
    {
        // Arrange
        object @this = $"{sbyte.MaxValue}{sbyte.MaxValue}";

        // Act
        sbyte? actual = @this.ToNullableSByte(provider: default);

        // Assert
        actual.Should().BeNull();
    }
}
