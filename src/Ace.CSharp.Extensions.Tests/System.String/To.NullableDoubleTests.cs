namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToNullableDoubleTests
{
    [Fact]
    internal void GivenToNullableDoubleWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = double.MaxValue.ToString(CultureInfo.CurrentCulture);
        double expected = double.MaxValue;

        // Act
        double? actual = @this.ToNullableDouble(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToNullableDoubleWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        string @this = "foo";

        // Act
        double? actual = @this.ToNullableDouble(provider: default);

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToNullableDoubleWhenInputOverflownThenResultIsNull()
    {
        // Arrange
        string @this = $"{double.MaxValue}{double.MaxValue}";

        // Act
        double? actual = @this.ToNullableDouble(provider: default);

        // Assert
        actual.Should().BeNull();
    }

    [Theory]
    [InlineData(null, null)]
    [InlineData("", null)]
    [InlineData(" ", null)]
    internal void GivenToNullableDoubleWhenInputIsNullOrWhiteSpaceThenResultIsExpected(string input, double? expected)
    {
        // Act
        double? actual = input.ToNullableDouble(null);

        // Assert
        actual.Should().Be(expected);
    }
}
