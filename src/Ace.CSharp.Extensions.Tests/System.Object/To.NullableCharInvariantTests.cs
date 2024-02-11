namespace Ace.CSharp.Extensions.Tests.ObjectExtensions;

public sealed class ToNullableCharInvariantTests
{
    [Fact]
    internal void GivenToNullableCharInvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = "*";
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
        object @this = "foo";

        // Act
        char? actual = @this.ToNullableCharInvariant();

        // Assert
        actual.Should().BeNull();
    }
}
