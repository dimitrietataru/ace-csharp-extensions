namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToDoubleTests
{
    [Fact]
    internal void GivenToDoubleWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = double.MaxValue.ToString(provider: default);
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
        string @this = "foo";

        // Act
        var action = () => @this.ToDouble(provider: default);

        // Assert
        action.Should().Throw<FormatException>();
    }

    [Fact]
    internal void GivenToDoubleWhenInputIsNotValidThenOverflowExceptionIsNotThrown()
    {
        // Arrange
        string @this = $"{int.MaxValue}{double.MaxValue}";

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
        string @this = double.MaxValue.ToString(provider: default);
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
        string @this = "foo";
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
        string @this = double.MaxValue.ToString(provider: default);
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
        string @this = "foo";

        // Act
        double? actual = @this.ToDoubleOrNull(provider: default);

        // Assert
        actual.Should().BeNull();
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData(" ")]
    internal void GivenToDoubleOrNullWhenInputIsNullOrWhiteSpaceThenResultIsNull(string? @this)
    {
        // Arrange

        // Act
        double? actual = @this.ToDoubleOrNull(provider: default);

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenTryConvertToDoubleWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = double.MaxValue.ToString(provider: default);
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
        string @this = "foo";

        // Act
        bool isDouble = @this.TryConvertToDouble(provider: default, out double actual);

        // Assert
        isDouble.Should().BeFalse();
        actual.Should().Be(default);
    }
}
