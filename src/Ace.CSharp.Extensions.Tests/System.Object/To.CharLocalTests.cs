namespace Ace.CSharp.Extensions.Tests.ObjectExtensions;

public sealed class ToCharLocalTests
{
    [Fact]
    internal void GivenToCharLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = '*';
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
        object @this = "foo";

        // Act
        var action = () => @this.ToCharLocal();

        // Assert
        action.Should().Throw<FormatException>();
    }

    [Fact]
    internal void GivenToCharLocalWhenInputIsNotValidThenArgumentNullExceptionIsNotThrown()
    {
        // Arrange
        object @this = null!;

        // Act
        var action = () => @this.ToCharLocal();

        // Assert
        action.Should().NotThrow<ArgumentNullException>();
    }

    [Fact]
    internal void GivenToCharWhenInputIsNotValidThenInvalidCastExceptionIsThrown()
    {
        // Arrange
        object @this = new { Foo = "foo" };

        // Act
        var action = () => @this.ToCharLocal();

        // Assert
        action.Should().Throw<InvalidCastException>();
    }

    [Fact]
    internal void GivenToCharLocalWhenInputIsNotValidThenOverflowExceptionIsThrown()
    {
        // Arrange
        object @this = -1;

        // Act
        var action = () => @this.ToCharLocal();

        // Assert
        action.Should().Throw<OverflowException>();
    }

    [Fact]
    internal void GivenToCharOrDefaultLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = '*';
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
        object @this = "foo";
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
        object @this = '*';
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
        object @this = "foo";

        // Act
        char? actual = @this.ToCharOrNullLocal();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToCharOrNullLocalWhenInputIsNullThenResultIsNull()
    {
        // Arrange
        object? @this = null;

        // Act
        char? actual = @this.ToCharOrNullLocal();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenTryConvertToCharLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = '*';
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
        object @this = "foo";

        // Act
        bool isChar = @this.TryConvertToCharLocal(out char actual);

        // Assert
        isChar.Should().BeFalse();
        actual.Should().Be(default);
    }
}
