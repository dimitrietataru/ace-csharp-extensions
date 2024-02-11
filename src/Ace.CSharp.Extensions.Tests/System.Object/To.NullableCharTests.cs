namespace Ace.CSharp.Extensions.Tests.ObjectExtensions;

public sealed class ToNullableCharTests
{
    [Fact]
    internal void GivenToNullableCharWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = "*";
        char expected = '*';

        // Act
        char? actual = @this.ToNullableChar(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToNullableCharWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        object @this = "foo";

        // Act
        char? actual = @this.ToNullableChar(provider: default);

        // Assert
        actual.Should().BeNull();
    }
}
