namespace Ace.CSharp.Extensions.Tests.ObjectExtensions;

public sealed class ToDoubleTests
{
    [Fact]
    internal void GivenToDoubleWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = 1.024D;
        double expected = 1.024D;

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
        object @this = $"{byte.MaxValue}{double.MaxValue}";

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
        object @this = 1.024D;
        double expected = 1.024D;

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
        double expected = 1.024D;

        // Act
        double actual = @this.ToDoubleOrDefault(provider: default, @default: expected);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToDoubleWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = 1.024D;
        double expected = 1.024D;

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
