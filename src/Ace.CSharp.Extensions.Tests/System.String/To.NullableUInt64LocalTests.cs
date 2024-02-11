namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToNullableUInt64LocalTests
{
    [Fact]
    internal void GivenToNullableUInt64LocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = ulong.MaxValue.ToString(CultureInfo.CurrentCulture);
        ulong expected = ulong.MaxValue;

        // Act
        ulong? actual = @this.ToNullableUInt64Local();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToNullableUInt64LocalWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        string @this = "foo";

        // Act
        ulong? actual = @this.ToNullableUInt64Local();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToNullableUInt64LocalWhenInputOverflownThenResultIsNull()
    {
        // Arrange
        string @this = $"{ulong.MaxValue}{ulong.MaxValue}";

        // Act
        ulong? actual = @this.ToNullableUInt64Local();

        // Assert
        actual.Should().BeNull();
    }
}
