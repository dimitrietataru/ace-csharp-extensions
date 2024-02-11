namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToNullableSingleTests
{
    [Fact]
    internal void GivenToNullableSingleWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = float.MaxValue.ToString(CultureInfo.CurrentCulture);
        float expected = float.MaxValue;

        // Act
        float? actual = @this.ToNullableSingle(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToNullableSingleWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        string @this = "foo";

        // Act
        float? actual = @this.ToNullableSingle(provider: default);

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToNullableSingleWhenInputOverflownThenResultIsNull()
    {
        // Arrange
        string @this = $"{float.MaxValue}{float.MaxValue}";

        // Act
        float? actual = @this.ToNullableSingle(provider: default);

        // Assert
        actual.Should().BeNull();
    }

    [Theory]
    [InlineData(null, null)]
    [InlineData("", null)]
    [InlineData(" ", null)]
    internal void GivenToNullableSingleWhenInputIsNullOrWhiteSpaceThenResultIsExpected(string input, float? expected)
    {
        // Act
        float? actual = input.ToNullableSingle(null);

        // Assert
        actual.Should().Be(expected);
    }
}
