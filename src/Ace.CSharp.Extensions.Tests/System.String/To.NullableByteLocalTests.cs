namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToNullableByteLocalTests
{
    [Fact]
    internal void GivenToNullableByteLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = byte.MaxValue.ToString(CultureInfo.CurrentCulture);
        byte expected = byte.MaxValue;

        // Act
        byte? actual = @this.ToNullableByteLocal();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToNullableByteLocalWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        string @this = "foo";

        // Act
        byte? actual = @this.ToNullableByteLocal();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToNullableByteLocalWhenInputOverflownThenResultIsNull()
    {
        // Arrange
        string @this = $"{byte.MaxValue}{byte.MaxValue}";

        // Act
        byte? actual = @this.ToNullableByteLocal();

        // Assert
        actual.Should().BeNull();
    }
}
