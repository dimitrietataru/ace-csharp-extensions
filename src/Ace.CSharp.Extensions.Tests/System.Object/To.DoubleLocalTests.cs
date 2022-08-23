namespace Ace.CSharp.Extensions.Tests.ObjectExtensions;

public sealed class ToDoubleLocalTests
{
    [Fact]
    internal void GivenToDoubleLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = 1.024D;
        double expected = 1.024D;

        // Act
        double actual = @this.ToDoubleLocal();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToDoubleLocalWhenInputIsNotValidThenFormatExceptionIsThrown()
    {
        // Arrange
        object @this = "foo";

        // Act
        var action = () => @this.ToDoubleLocal();

        // Assert
        action.Should().Throw<FormatException>();
    }

    [Fact]
    internal void GivenToDoubleLocalWhenInputIsNotValidThenInvalidCastExceptionIsThrown()
    {
        // Arrange
        object @this = new { Foo = "foo" };

        // Act
        var action = () => @this.ToDoubleLocal();

        // Assert
        action.Should().Throw<InvalidCastException>();
    }

    [Fact]
    internal void GivenToDoubleLocalWhenInputIsNotValidThenOverflowExceptionIsNotThrown()
    {
        // Arrange
        object @this = $"{byte.MaxValue}{double.MaxValue}";

        // Act
        var action = () => @this.ToDoubleLocal();

        // Assert
        action.Should().NotThrow<OverflowException>();
        action().Should().Be(double.PositiveInfinity);
    }

    [Fact]
    internal void GivenToDoubleOrDefaultLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = 1.024D;
        double expected = 1.024D;

        // Act
        double actual = @this.ToDoubleOrDefaultLocal();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToDoubleOrDefaultLocalWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        object @this = "foo";
        double expected = 1.024D;

        // Act
        double actual = @this.ToDoubleOrDefaultLocal(@default: expected);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToDoubleLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = 1.024D;
        double expected = 1.024D;

        // Act
        bool isDouble = @this.TryConvertToDoubleLocal(out double actual);

        // Assert
        isDouble.Should().BeTrue();
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToDoubleLocalWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        object @this = "foo";

        // Act
        bool isDouble = @this.TryConvertToDoubleLocal(out double actual);

        // Assert
        isDouble.Should().BeFalse();
        actual.Should().Be(default);
    }
}
