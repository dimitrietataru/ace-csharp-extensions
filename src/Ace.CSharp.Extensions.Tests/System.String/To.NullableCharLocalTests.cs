namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToNullableCharLocalTests
{
    [Fact]
    internal void GivenToNullableCharLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = "*";
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
        string @this = "foo";

        // Act
        char? actual = @this.ToNullableCharLocal();

        // Assert
        actual.Should().BeNull();
    }
}
