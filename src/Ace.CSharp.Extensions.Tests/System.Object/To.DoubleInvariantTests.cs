namespace Ace.CSharp.Extensions.Tests.ObjectExtensions;

public sealed class ToDoubleInvariantTests
{
    [Fact]
    internal void GivenToDoubleInvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = double.MaxValue;
        double expected = double.MaxValue;

        // Act
        double actual = @this.ToDoubleInvariant();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToDoubleInvariantWhenInputIsNotValidThenFormatExceptionIsThrown()
    {
        // Arrange
        object @this = "foo";

        // Act
        var action = () => @this.ToDoubleInvariant();

        // Assert
        action.Should().Throw<FormatException>();
    }

    [Fact]
    internal void GivenToDoubleInvariantWhenInputIsNotValidThenInvalidCastExceptionIsThrown()
    {
        // Arrange
        object @this = new { Foo = "foo" };

        // Act
        var action = () => @this.ToDoubleInvariant();

        // Assert
        action.Should().Throw<InvalidCastException>();
    }

    [Fact]
    internal void GivenToDoubleInvariantWhenInputIsNotValidThenOverflowExceptionIsNotThrown()
    {
        // Arrange
        object @this = $"{int.MaxValue}{double.MaxValue}";

        // Act
        var action = () => @this.ToDoubleInvariant();

        // Assert
        action.Should().NotThrow<OverflowException>();
        action().Should().Be(double.PositiveInfinity);
    }

    [Fact]
    internal void GivenToDoubleOrDefaultInvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = double.MaxValue;
        double expected = double.MaxValue;

        // Act
        double actual = @this.ToDoubleOrDefaultInvariant();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToDoubleOrDefaultInvariantWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        object @this = "foo";
        double expected = double.MaxValue;

        // Act
        double actual = @this.ToDoubleOrDefaultInvariant(@default: expected);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToDoubleOrNullInvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = double.MaxValue;
        double expected = double.MaxValue;

        // Act
        double? actual = @this.ToDoubleOrNullInvariant();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToDoubleOrNullInvariantWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        object @this = "foo";

        // Act
        double? actual = @this.ToDoubleOrNullInvariant();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToDoubleOrNullInvariantWhenInputIsNullThenResultIsNull()
    {
        // Arrange
        object? @this = null;

        // Act
        double? actual = @this.ToDoubleOrNullInvariant();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenTryConvertToDoubleInvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = double.MaxValue;
        double expected = double.MaxValue;

        // Act
        bool isDouble = @this.TryConvertToDoubleInvariant(out double actual);

        // Assert
        isDouble.Should().BeTrue();
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToDoubleInvariantWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        object @this = "foo";

        // Act
        bool isDouble = @this.TryConvertToDoubleInvariant(out double actual);

        // Assert
        isDouble.Should().BeFalse();
        actual.Should().Be(default);
    }
}
