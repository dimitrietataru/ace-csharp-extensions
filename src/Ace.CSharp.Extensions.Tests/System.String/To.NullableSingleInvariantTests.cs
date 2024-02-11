namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToNullableSingleInvariantTests
{
    [Fact]
    internal void GivenToNullableSingleInvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = float.MaxValue.ToString(CultureInfo.InvariantCulture);
        float expected = float.MaxValue;

        // Act
        float? actual = @this.ToNullableSingleInvariant();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToNullableSingleInvariantWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        string @this = "foo";

        // Act
        float? actual = @this.ToNullableSingleInvariant();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToNullableSingleInvariantWhenInputOverflownThenResultIsNull()
    {
        // Arrange
        string @this = $"{float.MaxValue}{float.MaxValue}";

        // Act
        float? actual = @this.ToNullableSingleInvariant();

        // Assert
        actual.Should().BeNull();
    }
}
