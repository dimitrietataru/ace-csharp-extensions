namespace Ace.CSharp.Extensions.Tests.ObjectExtensions;

public sealed class ToDecimalTests
{
    [Fact]
    internal void GivenToDecimalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = decimal.MaxValue;
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
        object @this = "foo";

        // Act
        var action = () => @this.ToDecimal(provider: default);

        // Assert
        action.Should().Throw<FormatException>();
    }

    [Fact]
    internal void GivenToDecimalWhenInputIsNotValidThenInvalidCastExceptionIsThrown()
    {
        // Arrange
        object @this = new { Foo = "foo" };

        // Act
        var action = () => @this.ToDecimal(provider: default);

        // Assert
        action.Should().Throw<InvalidCastException>();
    }

    [Fact]
    internal void GivenToDecimalWhenInputIsNotValidThenOverflowExceptionIsThrown()
    {
        // Arrange
        object @this = $"{int.MaxValue}{decimal.MaxValue}";

        // Act
        var action = () => @this.ToDecimal(provider: default);

        // Assert
        action.Should().Throw<OverflowException>();
    }

    [Fact]
    internal void GivenToDecimalOrDefaultWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = decimal.MaxValue;
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
        object @this = "foo";
        decimal expected = decimal.MaxValue;

        // Act
        decimal actual = @this.ToDecimalOrDefault(provider: default, @default: expected);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToDecimalOrNullWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = decimal.MaxValue;
        decimal expected = decimal.MaxValue;

        // Act
        decimal? actual = @this.ToDecimalOrNull(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToDecimalOrNullWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        object @this = "foo";

        // Act
        decimal? actual = @this.ToDecimalOrNull(provider: default);

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToDecimalOrNullWhenInputIsNullThenResultIsNull()
    {
        // Arrange
        object? @this = null;

        // Act
        decimal? actual = @this.ToDecimalOrNull(provider: default);

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenTryConvertToDecimalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = decimal.MaxValue;
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
        object @this = "foo";

        // Act
        bool isDecimal = @this.TryConvertToDecimal(provider: default, out decimal actual);

        // Assert
        isDecimal.Should().BeFalse();
        actual.Should().Be(default);
    }
}
