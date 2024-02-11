namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToNullableSByteTests
{
    [Fact]
    internal void GivenToNullableSByteWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = sbyte.MaxValue.ToString(CultureInfo.CurrentCulture);
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
        string @this = "foo";

        // Act
        sbyte? actual = @this.ToNullableSByte(provider: default);

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToNullableSByteWhenInputOverflownThenResultIsNull()
    {
        // Arrange
        string @this = $"{sbyte.MaxValue}{sbyte.MaxValue}";

        // Act
        sbyte? actual = @this.ToNullableSByte(provider: default);

        // Assert
        actual.Should().BeNull();
    }

    [Theory]
    [InlineData(null, null)]
    [InlineData("", null)]
    [InlineData(" ", null)]
    internal void GivenToNullableByteWhenInputIsNullOrWhiteSpaceThenResultIsExpected(string input, sbyte? expected)
    {
        // Act
        sbyte? actual = input.ToNullableSByte(null);

        // Assert
        actual.Should().Be(expected);
    }
}
