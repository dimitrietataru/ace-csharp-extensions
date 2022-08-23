namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToDoubleInvariantTests
{
    [Fact]
    internal void GivenToDoubleInvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = 1.024D.ToString(CultureInfo.InvariantCulture);
        double expected = 1.024D;

        // Act
        double actual = @this.ToDoubleInvariant();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToDoubleInvariantWhenInputIsNotValidThenFormatExceptionIsThrown()
    {
        // Arrange
        string @this = "foo";

        // Act
        var action = () => @this.ToDoubleInvariant();

        // Assert
        action.Should().Throw<FormatException>();
    }

    [Fact]
    internal void GivenToDoubleInvariantWhenInputIsNotValidThenOverflowExceptionIsNotThrown()
    {
        // Arrange
        string @this = $"{byte.MaxValue}{double.MaxValue}";

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
        string @this = 1.024D.ToString(CultureInfo.InvariantCulture);
        double expected = 1.024D;

        // Act
        double actual = @this.ToDoubleOrDefaultInvariant();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToDoubleOrDefaultInvariantWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        string @this = "foo";
        double expected = 1.024D;

        // Act
        double actual = @this.ToDoubleOrDefaultInvariant(@default: expected);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToDoubleInvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = 1.024D.ToString(CultureInfo.InvariantCulture);
        double expected = 1.024D;

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
        string @this = "foo";

        // Act
        bool isDouble = @this.TryConvertToDoubleInvariant(out double actual);

        // Assert
        isDouble.Should().BeFalse();
        actual.Should().Be(default);
    }
}
