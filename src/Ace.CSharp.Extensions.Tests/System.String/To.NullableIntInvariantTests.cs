namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToNullableIntInvariantTests
{
    [Fact]
    internal void GivenToNullableIntInvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = int.MaxValue.ToString(CultureInfo.CurrentCulture);
        int expected = int.MaxValue;

        // Act
        int? actual = @this.ToNullableIntInvariant();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToNullableIntInvariantWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        string @this = "foo";

        // Act
        int? actual = @this.ToNullableIntInvariant();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToNullableIntInvariantWhenInputOverflownThenResultIsNull()
    {
        // Arrange
        string @this = $"{int.MaxValue}{int.MaxValue}";

        // Act
        int? actual = @this.ToNullableIntInvariant();

        // Assert
        actual.Should().BeNull();
    }
}
