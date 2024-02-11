namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToNullableUInt16Tests
{
    [Fact]
    internal void GivenToNullableUInt16WhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = ushort.MaxValue.ToString(CultureInfo.CurrentCulture);
        ushort expected = ushort.MaxValue;

        // Act
        ushort? actual = @this.ToNullableUInt16(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToNullableUInt16WhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        string @this = "foo";

        // Act
        ushort? actual = @this.ToNullableUInt16(provider: default);

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToNullableUInt16WhenInputOverflownThenResultIsNull()
    {
        // Arrange
        string @this = $"{ushort.MaxValue}{ushort.MaxValue}";

        // Act
        ushort? actual = @this.ToNullableUInt16(provider: default);

        // Assert
        actual.Should().BeNull();
    }

    [Theory]
    [InlineData(null, null)]
    [InlineData("", null)]
    [InlineData(" ", null)]
    internal void GivenToNullableUInt16WhenInputIsNullOrWhiteSpaceThenResultIsExpected(string input, ushort? expected)
    {
        // Act
        ushort? actual = input.ToNullableUInt16(null);

        // Assert
        actual.Should().Be(expected);
    }
}
