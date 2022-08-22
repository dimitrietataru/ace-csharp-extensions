namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToDecimalLocalTests
{
    [Fact]
    internal void GivenToDecimalLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = 1.024M.ToString(CultureInfo.CurrentCulture);
        decimal expected = 1.024M;

        // Act
        decimal actual = @this.ToDecimalLocal();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToDecimalLocalWhenInputIsNotValidThenFormatExceptionIsThrown()
    {
        // Arrange
        string @this = "foo";

        // Act
        var action = () => @this.ToDecimalLocal();

        // Assert
        action.Should().Throw<FormatException>();
    }

    [Fact]
    internal void GivenToDecimalLocalWhenInputIsNotValidThenOverflowExceptionIsThrown()
    {
        // Arrange
        string @this = $"{decimal.MaxValue}0";

        // Act
        var action = () => @this.ToDecimalLocal();

        // Assert
        action.Should().Throw<OverflowException>();
    }

    [Fact]
    internal void GivenToDecimalOrDefaultLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = 1.024M.ToString(CultureInfo.CurrentCulture);
        decimal expected = 1.024M;

        // Act
        decimal actual = @this.ToDecimalOrDefaultLocal();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToDecimalOrDefaultLocalWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        string @this = "foo";
        decimal expected = 1.024M;

        // Act
        decimal actual = @this.ToDecimalOrDefaultLocal(@default: expected);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToDecimalLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = 1.024M.ToString(CultureInfo.CurrentCulture);
        decimal expected = 1.024M;

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
        string @this = "foo";

        // Act
        bool isDecimal = @this.TryConvertToDecimalLocal(out decimal actual);

        // Assert
        isDecimal.Should().BeFalse();
        actual.Should().Be(default);
    }
}
