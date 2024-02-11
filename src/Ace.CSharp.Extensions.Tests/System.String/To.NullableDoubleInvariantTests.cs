namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToNullableDoubleInvariantTests
{
    [Fact]
    internal void GivenToNullableDoubleInvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = double.MaxValue.ToString(CultureInfo.InvariantCulture);
        double expected = double.MaxValue;

        // Act
        double? actual = @this.ToNullableDoubleInvariant();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToNullableDoubleInvariantWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        string @this = "foo";

        // Act
        double? actual = @this.ToNullableDoubleInvariant();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToNullableDoubleInvariantWhenInputOverflownThenResultIsNull()
    {
        // Arrange
        string @this = $"{double.MaxValue}{double.MaxValue}";

        // Act
        double? actual = @this.ToNullableDoubleInvariant();

        // Assert
        actual.Should().BeNull();
    }
}
