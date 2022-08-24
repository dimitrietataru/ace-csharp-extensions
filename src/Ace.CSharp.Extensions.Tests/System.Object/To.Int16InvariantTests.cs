namespace Ace.CSharp.Extensions.Tests.ObjectExtensions;

public sealed class ToInt16InvariantTests
{
    [Fact]
    internal void GivenToInt16InvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = (short)1024;
        short expected = 1024;

        // Act
        short actual = @this.ToInt16Invariant();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToInt16InvariantWhenInputIsNotValidThenFormatExceptionIsThrown()
    {
        // Arrange
        object @this = "foo";

        // Act
        var action = () => @this.ToInt16Invariant();

        // Assert
        action.Should().Throw<FormatException>();
    }

    [Fact]
    internal void GivenToInt16InvariantWhenInputIsNotValidThenInvalidCastExceptionIsThrown()
    {
        // Arrange
        object @this = new { Foo = "foo" };

        // Act
        var action = () => @this.ToInt16Invariant();

        // Assert
        action.Should().Throw<InvalidCastException>();
    }

    [Fact]
    internal void GivenToInt16InvariantWhenInputIsNotValidThenOverflowExceptionIsThrown()
    {
        // Arrange
        object @this = $"{short.MaxValue}{short.MaxValue}";

        // Act
        var action = () => @this.ToInt16Invariant();

        // Assert
        action.Should().Throw<OverflowException>();
    }

    [Fact]
    internal void GivenToInt16OrDefaultInvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = (short)1024;
        short expected = 1024;

        // Act
        short actual = @this.ToInt16OrDefaultInvariant();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToInt16OrDefaultInvariantWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        object @this = "foo";
        short expected = 1024;

        // Act
        short actual = @this.ToInt16OrDefaultInvariant(@default: expected);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToInt16InvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = (short)1024;
        short expected = 1024;

        // Act
        bool isInt16 = @this.TryConvertToInt16Invariant(out short actual);

        // Assert
        isInt16.Should().BeTrue();
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToInt16InvariantWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        object @this = "foo";

        // Act
        bool isInt16 = @this.TryConvertToInt16Invariant(out short actual);

        // Assert
        isInt16.Should().BeFalse();
        actual.Should().Be(default);
    }
}
