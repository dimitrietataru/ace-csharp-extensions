namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToDecimalInvariantTests
{
    [Fact]
    internal void GivenToDecimalInvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = 1.024M.ToString(CultureInfo.InvariantCulture);
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
        string @this = "foo";

        // Act
        var action = () => @this.ToDecimalInvariant();

        // Assert
        action.Should().Throw<FormatException>();
    }

    [Fact]
    internal void GivenToDecimalInvariantWhenInputIsNotValidThenOverflowExceptionIsThrown()
    {
        // Arrange
        string @this = $"{decimal.MaxValue}0";

        // Act
        var action = () => @this.ToDecimalInvariant();

        // Assert
        action.Should().Throw<OverflowException>();
    }

    [Fact]
    internal void GivenToDecimalOrDefaultInvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = 1.024M.ToString(CultureInfo.InvariantCulture);
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
        string @this = "foo";
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
        string @this = 1.024M.ToString(CultureInfo.InvariantCulture);
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
        string @this = "foo";

        // Act
        bool isDecimal = @this.TryConvertToDecimalInvariant(out decimal actual);

        // Assert
        isDecimal.Should().BeFalse();
        actual.Should().Be(default);
    }
}
