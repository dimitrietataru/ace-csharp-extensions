namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToNullableUInt32InvariantTests
{
    [Fact]
    internal void GivenToNullableUInt32InvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = uint.MaxValue.ToString(CultureInfo.CurrentCulture);
        uint expected = uint.MaxValue;

        // Act
        uint? actual = @this.ToNullableUInt32Invariant();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToNullableUInt32InvariantWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        string @this = "foo";

        // Act
        uint? actual = @this.ToNullableUInt32Invariant();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToNullableUInt32InvariantWhenInputOverflownThenResultIsNull()
    {
        // Arrange
        string @this = $"{uint.MaxValue}{uint.MaxValue}";

        // Act
        uint? actual = @this.ToNullableUInt32Invariant();

        // Assert
        actual.Should().BeNull();
    }
}
