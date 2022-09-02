namespace Ace.CSharp.Extensions.Tests.ObjectExtensions;

public sealed class ToInt64InvariantTests
{
    [Fact]
    internal void GivenToInt64InvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = long.MaxValue;
        long expected = long.MaxValue;

        // Act
        long actual = @this.ToInt64Invariant();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToInt64InvariantWhenInputIsNotValidThenFormatExceptionIsThrown()
    {
        // Arrange
        object @this = "foo";

        // Act
        var action = () => @this.ToInt64Invariant();

        // Assert
        action.Should().Throw<FormatException>();
    }

    [Fact]
    internal void GivenToInt64InvariantWhenInputIsNotValidThenInvalidCastExceptionIsThrown()
    {
        // Arrange
        object @this = new { Foo = "foo" };

        // Act
        var action = () => @this.ToInt64Invariant();

        // Assert
        action.Should().Throw<InvalidCastException>();
    }

    [Fact]
    internal void GivenToInt64InvariantWhenInputIsNotValidThenOverflowExceptionIsThrown()
    {
        // Arrange
        object @this = $"{long.MaxValue}{long.MaxValue}";

        // Act
        var action = () => @this.ToInt64Invariant();

        // Assert
        action.Should().Throw<OverflowException>();
    }

    [Fact]
    internal void GivenToInt64OrDefaultInvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = long.MaxValue;
        long expected = long.MaxValue;

        // Act
        long actual = @this.ToInt64OrDefaultInvariant();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToInt64OrDefaultInvariantWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        object @this = "foo";
        long expected = long.MaxValue;

        // Act
        long actual = @this.ToInt64OrDefaultInvariant(@default: expected);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToInt64InvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = long.MaxValue;
        long expected = long.MaxValue;

        // Act
        bool isInt64 = @this.TryConvertToInt64Invariant(out long actual);

        // Assert
        isInt64.Should().BeTrue();
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToInt64InvariantWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        object @this = "foo";

        // Act
        bool isInt64 = @this.TryConvertToInt64Invariant(out long actual);

        // Assert
        isInt64.Should().BeFalse();
        actual.Should().Be(default);
    }
}
