namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToNullableCharTests
{
    [Fact]
    internal void GivenToNullableCharWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = "*";
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
        string @this = "foo";

        // Act
        char? actual = @this.ToNullableChar(provider: default);

        // Assert
        actual.Should().BeNull();
    }

    [Theory]
    [InlineData(null, null)]
    [InlineData("", null)]
    [InlineData(" ", null)]
    internal void GivenToNullableCharWhenInputIsNullOrWhiteSpaceThenResultIsExpected(string input, char? expected)
    {
        // Act
        char? actual = input.ToNullableChar(null);

        // Assert
        actual.Should().Be(expected);
    }
}
