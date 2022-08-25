namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToDecimalTests
{
    [Fact]
    internal void GivenToDecimalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = decimal.MaxValue.ToString(CultureInfo.CurrentCulture);
        decimal expected = decimal.MaxValue;

        // Act
        decimal actual = @this.ToDecimal(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToDecimalWhenInputIsNotValidThenFormatExceptionIsThrown()
    {
        // Arrange
        string @this = "foo";

        // Act
        var action = () => @this.ToDecimal(provider: default);

        // Assert
        action.Should().Throw<FormatException>();
    }

    [Fact]
    internal void GivenToDecimalWhenInputIsNotValidThenOverflowExceptionIsThrown()
    {
        // Arrange
        string @this = $"{int.MaxValue}{decimal.MaxValue}";

        // Act
        var action = () => @this.ToDecimal(provider: default);

        // Assert
        action.Should().Throw<OverflowException>();
    }

    [Fact]
    internal void GivenToDecimalOrDefaultWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = decimal.MaxValue.ToString(CultureInfo.CurrentCulture);
        decimal expected = decimal.MaxValue;

        // Act
        decimal actual = @this.ToDecimalOrDefault(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToDecimalOrDefaultWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        string @this = "foo";
        decimal expected = decimal.MaxValue;

        // Act
        decimal actual = @this.ToDecimalOrDefault(provider: default, @default: expected);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToDecimalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = decimal.MaxValue.ToString(CultureInfo.CurrentCulture);
        decimal expected = decimal.MaxValue;

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
        string @this = "foo";

        // Act
        bool isDecimal = @this.TryConvertToDecimal(provider: default, out decimal actual);

        // Assert
        isDecimal.Should().BeFalse();
        actual.Should().Be(default);
    }
}
