namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToNullableUIntInvariantTests
{
    [Fact]
    internal void GivenToNullableUIntInvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = uint.MaxValue.ToString(CultureInfo.CurrentCulture);
        uint expected = uint.MaxValue;

        // Act
        uint? actual = @this.ToNullableUIntInvariant();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToNullableUIntInvariantWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        string @this = "foo";

        // Act
        uint? actual = @this.ToNullableUIntInvariant();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToNullableUIntInvariantWhenInputOverflownThenResultIsNull()
    {
        // Arrange
        string @this = $"{uint.MaxValue}{uint.MaxValue}";

        // Act
        uint? actual = @this.ToNullableUIntInvariant();

        // Assert
        actual.Should().BeNull();
    }
}
