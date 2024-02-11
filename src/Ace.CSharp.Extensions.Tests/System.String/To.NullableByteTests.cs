namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToNullableByteTests
{
    [Fact]
    internal void GivenToNullableByteWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = byte.MaxValue.ToString(CultureInfo.CurrentCulture);
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
        string @this = "foo";

        // Act
        byte? actual = @this.ToNullableByte(provider: default);

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToNullableByteWhenInputOverflownThenResultIsNull()
    {
        // Arrange
        string @this = $"{byte.MaxValue}{byte.MaxValue}";

        // Act
        byte? actual = @this.ToNullableByte(provider: default);

        // Assert
        actual.Should().BeNull();
    }

    [Theory]
    [InlineData(null, null)]
    [InlineData("", null)]
    [InlineData(" ", null)]
    internal void GivenToNullableByteWhenInputIsNullOrWhiteSpaceThenResultIsExpected(string input, byte? expected)
    {
        // Act
        byte? actual = input.ToNullableByte(null);

        // Assert
        actual.Should().Be(expected);
    }
}
