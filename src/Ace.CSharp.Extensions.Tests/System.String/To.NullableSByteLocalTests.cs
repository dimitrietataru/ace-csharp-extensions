namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToNullableSByteLocalTests
{
    [Fact]
    internal void GivenToNullableSByteLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = sbyte.MaxValue.ToString(CultureInfo.CurrentCulture);
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
        string @this = "foo";

        // Act
        sbyte? actual = @this.ToNullableSByteLocal();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToNullableSByteLocalWhenInputOverflownThenResultIsNull()
    {
        // Arrange
        string @this = $"{sbyte.MaxValue}{sbyte.MaxValue}";

        // Act
        sbyte? actual = @this.ToNullableSByteLocal();

        // Assert
        actual.Should().BeNull();
    }
}
