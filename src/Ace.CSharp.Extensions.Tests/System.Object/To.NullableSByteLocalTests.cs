namespace Ace.CSharp.Extensions.Tests.ObjectExtensions;

public sealed class ToNullableSByteLocalTests
{
    [Fact]
    internal void GivenToNullableSByteLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object? @this = sbyte.MaxValue;
        sbyte expected = sbyte.MaxValue;

        // Act
        sbyte? actual = @this.ToNullableSByteLocal();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToNullableSByteLocalWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        object @this = "foo";

        // Act
        sbyte? actual = @this.ToNullableSByteLocal();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToNullableSByteLocalWhenInputOverflownThenResultIsNull()
    {
        // Arrange
        object @this = $"{sbyte.MaxValue}{sbyte.MaxValue}";

        // Act
        sbyte? actual = @this.ToNullableSByteLocal();

        // Assert
        actual.Should().BeNull();
    }
}
