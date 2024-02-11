namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToNullableCharInvariantTests
{
    [Fact]
    internal void GivenToNullableCharInvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = "*";
        char expected = '*';

        // Act
        char? actual = @this.ToNullableCharInvariant();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToNullableCharInvariantWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        string @this = "foo";

        // Act
        char? actual = @this.ToNullableCharInvariant();

        // Assert
        actual.Should().BeNull();
    }
}
