namespace Ace.CSharp.Extensions.Tests.ObjectExtensions;

public sealed class ToNullableCharLocalTests
{
    [Fact]
    internal void GivenToNullableCharLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = "*";
        char expected = '*';

        // Act
        char? actual = @this.ToNullableCharLocal();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToNullableCharLocalWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        object @this = "foo";

        // Act
        char? actual = @this.ToNullableCharLocal();

        // Assert
        actual.Should().BeNull();
    }
}
