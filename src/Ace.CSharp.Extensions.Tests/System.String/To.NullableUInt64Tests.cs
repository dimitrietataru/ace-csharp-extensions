namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToNullableUInt64Tests
{
    [Fact]
    internal void GivenToNullableUInt64WhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = ulong.MaxValue.ToString(CultureInfo.CurrentCulture);
        ulong expected = ulong.MaxValue;

        // Act
        ulong? actual = @this.ToNullableUInt64(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToNullableUInt64WhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        string @this = "foo";

        // Act
        ulong? actual = @this.ToNullableUInt64(provider: default);

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToNullableUInt64WhenInputOverflownThenResultIsNull()
    {
        // Arrange
        string @this = $"{ulong.MaxValue}{ulong.MaxValue}";

        // Act
        ulong? actual = @this.ToNullableUInt64(provider: default);

        // Assert
        actual.Should().BeNull();
    }

    [Theory]
    [InlineData(null, null)]
    [InlineData("", null)]
    [InlineData(" ", null)]
    internal void GivenToNullableUInt64WhenInputIsNullOrWhiteSpaceThenResultIsExpected(string input, ulong? expected)
    {
        // Act
        ulong? actual = input.ToNullableUInt64(null);

        // Assert
        actual.Should().Be(expected);
    }
}
