namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToCharLocalTests
{
    [Fact]
    internal void GivenToCharLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = "*";
        char expected = '*';

        // Act
        char actual = @this.ToCharLocal();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToCharLocalWhenInputIsNotValidThenFormatExceptionIsThrown()
    {
        // Arrange
        string @this = "foo";

        // Act
        var action = () => @this.ToCharLocal();

        // Assert
        action.Should().Throw<FormatException>();
    }

    [Fact]
    internal void GivenToCharLocalWhenInputIsNotValidThenArgumentNullExceptionIsThrown()
    {
        // Arrange
        string @this = null!;

        // Act
        var action = () => @this.ToCharLocal();

        // Assert
        action.Should().Throw<ArgumentNullException>();
    }

    [Fact]
    internal void GivenToCharOrDefaultLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = "*";
        char expected = '*';

        // Act
        char actual = @this.ToCharOrDefaultLocal();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToCharOrDefaultLocalWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        string @this = "foo";
        char expected = '*';

        // Act
        char actual = @this.ToCharOrDefaultLocal(@default: expected);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToCharOrNullLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = "*";
        char expected = '*';

        // Act
        char? actual = @this.ToCharOrNullLocal();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToCharOrNullLocalWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        string @this = "foo";

        // Act
        char? actual = @this.ToCharOrNullLocal();

        // Assert
        actual.Should().BeNull();
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData(" ")]
    internal void GivenToCharOrNullLocalWhenInputIsNullOrWhiteSpaceThenResultIsNull(string @this)
    {
        // Act
        char? actual = @this.ToCharOrNullLocal();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenTryConvertToCharLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = "*";
        char expected = '*';

        // Act
        bool isChar = @this.TryConvertToCharLocal(out char actual);

        // Assert
        isChar.Should().BeTrue();
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToCharLocalWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        string @this = "foo";

        // Act
        bool isChar = @this.TryConvertToCharLocal(out char actual);

        // Assert
        isChar.Should().BeFalse();
        actual.Should().Be(default);
    }
}
