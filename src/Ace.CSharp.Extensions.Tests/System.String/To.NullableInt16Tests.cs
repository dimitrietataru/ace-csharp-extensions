namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToNullableInt16Tests
{
    [Fact]
    internal void GivenToNullableInt16WhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = short.MaxValue.ToString(CultureInfo.CurrentCulture);
        short expected = short.MaxValue;

        // Act
        short? actual = @this.ToNullableInt16(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToNullableInt16WhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        string @this = "foo";

        // Act
        short? actual = @this.ToNullableInt16(provider: default);

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToNullableInt16WhenInputOverflownThenResultIsNull()
    {
        // Arrange
        string @this = $"{short.MaxValue}{short.MaxValue}";

        // Act
        short? actual = @this.ToNullableInt16(provider: default);

        // Assert
        actual.Should().BeNull();
    }

    [Theory]
    [InlineData(null, null)]
    [InlineData("", null)]
    [InlineData(" ", null)]
    internal void GivenToNullableInt16WhenInputIsNullOrWhiteSpaceThenResultIsExpected(string input, short? expected)
    {
        // Act
        short? actual = input.ToNullableInt16(null);

        // Assert
        actual.Should().Be(expected);
    }
}
