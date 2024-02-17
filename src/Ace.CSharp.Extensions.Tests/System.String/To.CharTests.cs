namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToCharTests
{
    [Fact]
    internal void GivenToCharWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = "*";
        char expected = '*';

        // Act
        char actual = @this.ToChar(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToCharWhenInputIsNotValidThenFormatExceptionIsThrown()
    {
        // Arrange
        string @this = "foo";

        // Act
        var action = () => @this.ToChar(provider: default);

        // Assert
        action.Should().Throw<FormatException>();
    }

    [Fact]
    internal void GivenToCharWhenInputIsNotValidThenArgumentNullExceptionIsThrown()
    {
        // Arrange
        string @this = null!;

        // Act
        var action = () => @this.ToChar(provider: default);

        // Assert
        action.Should().Throw<ArgumentNullException>();
    }

    [Fact]
    internal void GivenToCharOrDefaultWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = "*";
        char expected = '*';

        // Act
        char actual = @this.ToCharOrDefault(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToCharOrDefaultWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        string @this = "foo";
        char expected = '*';

        // Act
        char actual = @this.ToCharOrDefault(provider: default, @default: expected);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToCharOrNullWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = "*";
        char expected = '*';

        // Act
        char? actual = @this.ToCharOrNull(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToCharOrNullWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        string @this = "foo";

        // Act
        char? actual = @this.ToCharOrNull(provider: default);

        // Assert
        actual.Should().BeNull();
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData(" ")]
    internal void GivenToCharOrNullWhenInputIsNullOrWhiteSpaceThenResultIsNull(string @this)
    {
        // Act
        char? actual = @this.ToCharOrNull(provider: default);

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenTryConvertToCharWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = "*";
        char expected = '*';

        // Act
        bool isChar = @this.TryConvertToChar(provider: default, out char actual);

        // Assert
        isChar.Should().BeTrue();
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToCharWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        string @this = "foo";

        // Act
        bool isChar = @this.TryConvertToChar(provider: default, out char actual);

        // Assert
        isChar.Should().BeFalse();
        actual.Should().Be(default);
    }
}
