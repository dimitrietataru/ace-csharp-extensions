namespace Ace.CSharp.Extensions.Tests.ObjectExtensions;

public sealed class ToCharTests
{
    [Fact]
    internal void GivenToCharWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = '*';
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
        object @this = "foo";

        // Act
        var action = () => @this.ToChar(provider: default);

        // Assert
        action.Should().Throw<FormatException>();
    }

    [Fact]
    internal void GivenToCharWhenInputIsNotValidThenArgumentNullExceptionIsNotThrown()
    {
        // Arrange
        object @this = null!;

        // Act
        var action = () => @this.ToChar(provider: default);

        // Assert
        action.Should().NotThrow<ArgumentNullException>();
    }

    [Fact]
    internal void GivenToCharWhenInputIsNotValidThenInvalidCastExceptionIsThrown()
    {
        // Arrange
        object @this = new { Foo = "foo" };

        // Act
        var action = () => @this.ToChar(provider: default);

        // Assert
        action.Should().Throw<InvalidCastException>();
    }

    [Fact]
    internal void GivenToCharWhenInputIsNotValidThenOverflowExceptionIsThrown()
    {
        // Arrange
        object @this = -1;

        // Act
        var action = () => @this.ToChar(provider: default);

        // Assert
        action.Should().Throw<OverflowException>();
    }

    [Fact]
    internal void GivenToCharOrDefaultWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = '*';
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
        object @this = "foo";
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
        object @this = '*';
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
        object @this = "foo";

        // Act
        char? actual = @this.ToCharOrNull(provider: default);

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToCharOrNullWhenInputIsNullThenResultIsNull()
    {
        // Arrange
        object? @this = null;

        // Act
        char? actual = @this.ToCharOrNull(provider: default);

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenTryConvertToCharWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = '*';
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
        object @this = "foo";

        // Act
        bool isChar = @this.TryConvertToChar(provider: default, out char actual);

        // Assert
        isChar.Should().BeFalse();
        actual.Should().Be(default);
    }
}
