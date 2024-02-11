namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToNullableUInt32LocalTests
{
    [Fact]
    internal void GivenToNullableUInt32LocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = uint.MaxValue.ToString(CultureInfo.CurrentCulture);
        uint expected = uint.MaxValue;

        // Act
        uint? actual = @this.ToNullableUInt32Local();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToNullableUInt32LocalWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        string @this = "foo";

        // Act
        uint? actual = @this.ToNullableUInt32Local();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToNullableUInt32LocalWhenInputOverflownThenResultIsNull()
    {
        // Arrange
        string @this = $"{uint.MaxValue}{uint.MaxValue}";

        // Act
        uint? actual = @this.ToNullableUInt32Local();

        // Assert
        actual.Should().BeNull();
    }
}
