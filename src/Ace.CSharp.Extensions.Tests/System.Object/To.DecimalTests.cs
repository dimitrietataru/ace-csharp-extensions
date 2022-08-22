namespace Ace.CSharp.Extensions.Tests.ObjectExtensions;

public sealed class ToDecimalTests
{
    [Fact]
    internal void GivenToDecimalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = 1.024M;
        decimal expected = 1.024M;

        // Act
        decimal actual = @this.ToDecimal(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToDecimalWhenInputIsNotValidThenFormatExceptionIsThrown()
    {
        // Arrange
        object @this = "foo";

        // Act
        var action = () => @this.ToDecimal(provider: default);

        // Assert
        action.Should().Throw<FormatException>();
    }

    [Fact]
    internal void GivenToDecimalWhenInputIsNotValidThenOverflowExceptionIsThrown()
    {
        // Arrange
        object @this = $"{decimal.MaxValue}0";

        // Act
        var action = () => @this.ToDecimal(provider: default);

        // Assert
        action.Should().Throw<OverflowException>();
    }

    [Fact]
    internal void GivenToDecimalOrDefaultWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = 1.024M;
        decimal expected = 1.024M;

        // Act
        decimal actual = @this.ToDecimalOrDefault(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToDecimalOrDefaultWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        object @this = "foo";
        decimal expected = 1.024M;

        // Act
        decimal actual = @this.ToDecimalOrDefault(provider: default, @default: expected);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToDecimalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = 1.024M;
        decimal expected = 1.024M;

        // Act
        bool isDecimal = @this.TryConvertToDecimal(provider: default, out decimal actual);

        // Assert
        isDecimal.Should().BeTrue();
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToDecimalWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        object @this = "foo";

        // Act
        bool isDecimal = @this.TryConvertToDecimal(provider: default, out decimal actual);

        // Assert
        isDecimal.Should().BeFalse();
        actual.Should().Be(default);
    }
}
