namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToNullableUIntLocalTests
{
    [Fact]
    internal void GivenToNullableUIntLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = uint.MaxValue.ToString(CultureInfo.CurrentCulture);
        uint expected = uint.MaxValue;

        // Act
        uint? actual = @this.ToNullableUIntLocal();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToNullableUIntLocalWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        string @this = "foo";

        // Act
        uint? actual = @this.ToNullableUIntLocal();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToNullableUIntLocalWhenInputOverflownThenResultIsNull()
    {
        // Arrange
        string @this = $"{uint.MaxValue}{uint.MaxValue}";

        // Act
        uint? actual = @this.ToNullableUIntLocal();

        // Assert
        actual.Should().BeNull();
    }
}
