namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToNullableSByteInvariantTests
{
    [Fact]
    internal void GivenToNullableSByteInvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = sbyte.MaxValue.ToString(CultureInfo.CurrentCulture);
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
        string @this = "foo";

        // Act
        sbyte? actual = @this.ToNullableSByteInvariant();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToNullableSByteInvariantWhenInputOverflownThenResultIsNull()
    {
        // Arrange
        string @this = $"{sbyte.MaxValue}{sbyte.MaxValue}";

        // Act
        sbyte? actual = @this.ToNullableSByteInvariant();

        // Assert
        actual.Should().BeNull();
    }
}
