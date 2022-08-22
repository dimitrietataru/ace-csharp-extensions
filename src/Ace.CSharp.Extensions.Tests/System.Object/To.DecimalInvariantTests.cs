namespace Ace.CSharp.Extensions.Tests.ObjectExtensions;

public sealed class ToDecimalInvariantTests
{
    [Fact]
    internal void GivenToDecimalInvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = 1.024M;
        decimal expected = 1.024M;

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
    internal void GivenToDecimalInvariantWhenInputIsNotValidThenOverflowExceptionIsThrown()
    {
        // Arrange
        object @this = $"{decimal.MaxValue}0";

        // Act
        var action = () => @this.ToDecimalInvariant();

        // Assert
        action.Should().Throw<OverflowException>();
    }

    [Fact]
    internal void GivenToDecimalOrDefaultInvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = 1.024M;
        decimal expected = 1.024M;

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
        decimal expected = 1.024M;

        // Act
        decimal actual = @this.ToDecimalOrDefaultInvariant(@default: expected);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToDecimalInvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = 1.024M;
        decimal expected = 1.024M;

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
