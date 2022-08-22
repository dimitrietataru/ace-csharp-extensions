namespace Ace.CSharp.Extensions.Tests.ObjectExtensions;

public sealed class ToCharInvariantTests
{
    [Fact]
    internal void GivenToCharInvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = '*';
        char expected = '*';

        // Act
        char actual = @this.ToCharInvariant();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToCharInvariantWhenInputIsNotValidThenFormatExceptionIsThrown()
    {
        // Arrange
        object @this = "foo";

        // Act
        var action = () => @this.ToCharInvariant();

        // Assert
        action.Should().Throw<FormatException>();
    }

    [Fact]
    internal void GivenToCharInvariantWhenInputIsNotValidThenArgumentNullExceptionIsNotThrown()
    {
        // Arrange
        object @this = null!;

        // Act
        var action = () => @this.ToCharInvariant();

        // Assert
        action.Should().NotThrow<ArgumentNullException>();
    }

    [Fact]
    internal void GivenToCharWhenInputIsNotValidThenInvalidCastExceptionIsThrown()
    {
        // Arrange
        object @this = new { Foo = "foo" };

        // Act
        var action = () => @this.ToCharInvariant();

        // Assert
        action.Should().Throw<InvalidCastException>();
    }

    [Fact]
    internal void GivenToCharInvariantWhenInputIsNotValidThenOverflowExceptionIsThrown()
    {
        // Arrange
        object @this = -1;

        // Act
        var action = () => @this.ToCharInvariant();

        // Assert
        action.Should().Throw<OverflowException>();
    }

    [Fact]
    internal void GivenToCharOrDefaultInvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = '*';
        char expected = '*';

        // Act
        char actual = @this.ToCharOrDefaultInvariant();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToCharOrDefaultInvariantWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        object @this = "foo";
        char expected = '*';

        // Act
        char actual = @this.ToCharOrDefaultInvariant(@default: expected);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToCharInvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = '*';
        char expected = '*';

        // Act
        bool isChar = @this.TryConvertToCharInvariant(out char actual);

        // Assert
        isChar.Should().BeTrue();
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToCharInvariantWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        object @this = "foo";

        // Act
        bool isChar = @this.TryConvertToCharInvariant(out char actual);

        // Assert
        isChar.Should().BeFalse();
        actual.Should().Be(default);
    }
}
