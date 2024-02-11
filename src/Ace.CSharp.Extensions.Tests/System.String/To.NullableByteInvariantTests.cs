namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToNullableByteInvariantTests
{
    [Fact]
    internal void GivenToNullableByteInvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = byte.MaxValue.ToString(CultureInfo.CurrentCulture);
        byte expected = byte.MaxValue;

        // Act
        byte? actual = @this.ToNullableByteInvariant();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToNullableByteInvariantWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        string @this = "foo";

        // Act
        byte? actual = @this.ToNullableByteInvariant();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToNullableByteInvariantWhenInputOverflownThenResultIsNull()
    {
        // Arrange
        string @this = $"{byte.MaxValue}{byte.MaxValue}";

        // Act
        byte? actual = @this.ToNullableByteInvariant();

        // Assert
        actual.Should().BeNull();
    }
}
