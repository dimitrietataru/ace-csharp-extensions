namespace Ace.CSharp.Extensions.Tests.ObjectExtensions;

public sealed class ToDecimalLocalTests
{
    [Fact]
    internal void GivenToDecimalLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = decimal.MaxValue;
        decimal expected = decimal.MaxValue;

        // Act
        decimal actual = @this.ToDecimalLocal();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToDecimalLocalWhenInputIsNotValidThenFormatExceptionIsThrown()
    {
        // Arrange
        object @this = "foo";

        // Act
        var action = () => @this.ToDecimalLocal();

        // Assert
        action.Should().Throw<FormatException>();
    }

    [Fact]
    internal void GivenToDecimalLocalWhenInputIsNotValidThenOverflowExceptionIsThrown()
    {
        // Arrange
        object @this = $"{int.MaxValue}{decimal.MaxValue}";

        // Act
        var action = () => @this.ToDecimalLocal();

        // Assert
        action.Should().Throw<OverflowException>();
    }

    [Fact]
    internal void GivenToDecimalOrDefaultLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = decimal.MaxValue;
        decimal expected = decimal.MaxValue;

        // Act
        decimal actual = @this.ToDecimalOrDefaultLocal();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToDecimalOrDefaultLocalWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        object @this = "foo";
        decimal expected = decimal.MaxValue;

        // Act
        decimal actual = @this.ToDecimalOrDefaultLocal(@default: expected);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToDecimalLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = decimal.MaxValue;
        decimal expected = decimal.MaxValue;

        // Act
        bool isDecimal = @this.TryConvertToDecimalLocal(out decimal actual);

        // Assert
        isDecimal.Should().BeTrue();
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToDecimalLocalWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        object @this = "foo";

        // Act
        bool isDecimal = @this.TryConvertToDecimalLocal(out decimal actual);

        // Assert
        isDecimal.Should().BeFalse();
        actual.Should().Be(default);
    }
}
