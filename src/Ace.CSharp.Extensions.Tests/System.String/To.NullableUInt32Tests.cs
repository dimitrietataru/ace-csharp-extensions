namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToNullableUInt32Tests
{
    [Fact]
    internal void GivenToNullableUInt32WhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = uint.MaxValue.ToString(CultureInfo.CurrentCulture);
        uint expected = uint.MaxValue;

        // Act
        uint? actual = @this.ToNullableUInt32(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToNullableUInt32WhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        string @this = "foo";

        // Act
        uint? actual = @this.ToNullableUInt32(provider: default);

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToNullableUInt32WhenInputOverflownThenResultIsNull()
    {
        // Arrange
        string @this = $"{uint.MaxValue}{uint.MaxValue}";

        // Act
        uint? actual = @this.ToNullableUInt32(provider: default);

        // Assert
        actual.Should().BeNull();
    }

    [Theory]
    [InlineData(null, null)]
    [InlineData("", null)]
    [InlineData(" ", null)]
    internal void GivenToNullableUInt32WhenInputIsNullOrWhiteSpaceThenResultIsExpected(string input, uint? expected)
    {
        // Act
        uint? actual = input.ToNullableUInt32(null);

        // Assert
        actual.Should().Be(expected);
    }
}
