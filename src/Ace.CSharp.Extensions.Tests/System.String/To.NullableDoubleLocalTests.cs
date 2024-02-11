namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToNullableDoubleLocalTests
{
    [Fact]
    internal void GivenToNullableDoubleLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = double.MaxValue.ToString(CultureInfo.CurrentCulture);
        double expected = double.MaxValue;

        // Act
        double? actual = @this.ToNullableDoubleLocal();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToNullableDoubleLocalWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        string @this = "foo";

        // Act
        double? actual = @this.ToNullableDoubleLocal();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToNullableDoubleLocalWhenInputOverflownThenResultIsNull()
    {
        // Arrange
        string @this = $"{double.MaxValue}{double.MaxValue}";

        // Act
        double? actual = @this.ToNullableDoubleLocal();

        // Assert
        actual.Should().BeNull();
    }
}
