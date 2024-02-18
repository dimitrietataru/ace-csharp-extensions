namespace Ace.CSharp.Extensions.Tests.ObjectExtensions;

public sealed class ToDoubleLocalTests
{
    [Fact]
    internal void GivenToDoubleLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = double.MaxValue;
        double expected = double.MaxValue;

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
        object @this = $"{int.MaxValue}{double.MaxValue}";

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
        object @this = double.MaxValue;
        double expected = double.MaxValue;

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
        double expected = double.MaxValue;

        // Act
        double actual = @this.ToDoubleOrDefaultLocal(@default: expected);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToDoubleOrNullLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = double.MaxValue;
        double expected = double.MaxValue;

        // Act
        double? actual = @this.ToDoubleOrNullLocal();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToDoubleOrNullLocalWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        object @this = "foo";

        // Act
        double? actual = @this.ToDoubleOrNullLocal();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToDoubleOrNullLocalWhenInputIsNullThenResultIsNull()
    {
        // Arrange
        object? @this = null;

        // Act
        double? actual = @this.ToDoubleOrNullLocal();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenTryConvertToDoubleLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = double.MaxValue;
        double expected = double.MaxValue;

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
