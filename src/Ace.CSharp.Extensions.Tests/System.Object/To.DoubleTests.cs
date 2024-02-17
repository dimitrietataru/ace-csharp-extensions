namespace Ace.CSharp.Extensions.Tests.ObjectExtensions;

public sealed class ToDoubleTests
{
    [Fact]
    internal void GivenToDoubleWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = double.MaxValue;
        double expected = double.MaxValue;

        // Act
        double actual = @this.ToDouble(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToDoubleWhenInputIsNotValidThenFormatExceptionIsThrown()
    {
        // Arrange
        object @this = "foo";

        // Act
        var action = () => @this.ToDouble(provider: default);

        // Assert
        action.Should().Throw<FormatException>();
    }

    [Fact]
    internal void GivenToDoubleWhenInputIsNotValidThenInvalidCastExceptionIsThrown()
    {
        // Arrange
        object @this = new { Foo = "foo" };

        // Act
        var action = () => @this.ToDouble(provider: default);

        // Assert
        action.Should().Throw<InvalidCastException>();
    }

    [Fact]
    internal void GivenToDoubleWhenInputIsNotValidThenOverflowExceptionIsNotThrown()
    {
        // Arrange
        object @this = $"{int.MaxValue}{double.MaxValue}";

        // Act
        var action = () => @this.ToDouble(provider: default);

        // Assert
        action.Should().NotThrow<OverflowException>();
        action().Should().Be(double.PositiveInfinity);
    }

    [Fact]
    internal void GivenToDoubleOrDefaultWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = double.MaxValue;
        double expected = double.MaxValue;

        // Act
        double actual = @this.ToDoubleOrDefault(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToDoubleOrDefaultWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        object @this = "foo";
        double expected = double.MaxValue;

        // Act
        double actual = @this.ToDoubleOrDefault(provider: default, @default: expected);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToDoubleOrNullWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = double.MaxValue;
        double expected = double.MaxValue;

        // Act
        double? actual = @this.ToDoubleOrNull(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToDoubleOrNullWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        object @this = "foo";

        // Act
        double? actual = @this.ToDoubleOrNull(provider: default);

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToDoubleOrNullWhenInputIsNullThenResultIsNull()
    {
        // Arrange
        object? @this = null;

        // Act
        double? actual = @this.ToDoubleOrNull(provider: default);

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenTryConvertToDoubleWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = double.MaxValue;
        double expected = double.MaxValue;

        // Act
        bool isDouble = @this.TryConvertToDouble(provider: default, out double actual);

        // Assert
        isDouble.Should().BeTrue();
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToDoubleWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        object @this = "foo";

        // Act
        bool isDouble = @this.TryConvertToDouble(provider: default, out double actual);

        // Assert
        isDouble.Should().BeFalse();
        actual.Should().Be(default);
    }
}
