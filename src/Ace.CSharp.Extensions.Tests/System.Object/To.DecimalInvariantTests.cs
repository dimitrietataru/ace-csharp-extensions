namespace Ace.CSharp.Extensions.Tests.ObjectExtensions;

public sealed class ToDecimalInvariantTests
{
    [Fact]
    internal void GivenToDecimalInvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = decimal.MaxValue;
        decimal expected = decimal.MaxValue;

        // Act
        decimal actual = @this.ToDecimalInvariant();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToDecimalInvariantWhenInputIsNotValidThenFormatExceptionIsThrown()
    {
        // Arrange
        object @this = "foo";

        // Act
        var action = () => @this.ToDecimalInvariant();

        // Assert
        action.Should().Throw<FormatException>();
    }

    [Fact]
    internal void GivenToDecimalInvariantWhenInputIsNotValidThenInvalidCastExceptionIsThrown()
    {
        // Arrange
        object @this = new { Foo = "foo" };

        // Act
        var action = () => @this.ToDecimalInvariant();

        // Assert
        action.Should().Throw<InvalidCastException>();
    }

    [Fact]
    internal void GivenToDecimalInvariantWhenInputIsNotValidThenOverflowExceptionIsThrown()
    {
        // Arrange
        object @this = $"{int.MaxValue}{decimal.MaxValue}";

        // Act
        var action = () => @this.ToDecimalInvariant();

        // Assert
        action.Should().Throw<OverflowException>();
    }

    [Fact]
    internal void GivenToDecimalOrDefaultInvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = decimal.MaxValue;
        decimal expected = decimal.MaxValue;

        // Act
        decimal actual = @this.ToDecimalOrDefaultInvariant();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToDecimalOrDefaultInvariantWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        object @this = "foo";
        decimal expected = decimal.MaxValue;

        // Act
        decimal actual = @this.ToDecimalOrDefaultInvariant(@default: expected);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToDecimalInvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = decimal.MaxValue;
        decimal expected = decimal.MaxValue;

        // Act
        bool isDecimal = @this.TryConvertToDecimalInvariant(out decimal actual);

        // Assert
        isDecimal.Should().BeTrue();
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToDecimalInvariantWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        object @this = "foo";

        // Act
        bool isDecimal = @this.TryConvertToDecimalInvariant(out decimal actual);

        // Assert
        isDecimal.Should().BeFalse();
        actual.Should().Be(default);
    }
}
