namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToDoubleLocalTests
{
    [Fact]
    internal void GivenToDoubleLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = 1.024D.ToString(CultureInfo.CurrentCulture);
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
        string @this = "foo";

        // Act
        var action = () => @this.ToDoubleLocal();

        // Assert
        action.Should().Throw<FormatException>();
    }

    [Fact]
    internal void GivenToDoubleLocalWhenInputIsNotValidThenOverflowExceptionIsNotThrown()
    {
        // Arrange
        string @this = $"{byte.MaxValue}{double.MaxValue}";

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
        string @this = 1.024D.ToString(CultureInfo.CurrentCulture);
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
        string @this = "foo";
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
        string @this = 1.024D.ToString(CultureInfo.CurrentCulture);
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
        string @this = "foo";

        // Act
        bool isDouble = @this.TryConvertToDoubleLocal(out double actual);

        // Assert
        isDouble.Should().BeFalse();
        actual.Should().Be(default);
    }
}
