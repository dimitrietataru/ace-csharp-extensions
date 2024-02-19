namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToDecimalLocalTests
{
    [Fact]
    internal void GivenToDecimalLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = decimal.MaxValue.ToString(CultureInfo.CurrentCulture);
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
        string @this = $"{int.MaxValue}{decimal.MaxValue}";

        // Act
        var action = () => @this.ToDecimalLocal();

        // Assert
        action.Should().Throw<OverflowException>();
    }

    [Fact]
    internal void GivenToDecimalOrDefaultLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = decimal.MaxValue.ToString(CultureInfo.CurrentCulture);
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
        string @this = "foo";
        decimal expected = decimal.MaxValue;

        // Act
        decimal actual = @this.ToDecimalOrDefaultLocal(@default: expected);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToDecimalOrNullLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = decimal.MaxValue.ToString(CultureInfo.CurrentCulture);
        decimal expected = decimal.MaxValue;

        // Act
        decimal? actual = @this.ToDecimalOrNullLocal();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToDecimalOrNullLocalWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        string @this = "foo";

        // Act
        decimal? actual = @this.ToDecimalOrNullLocal();

        // Assert
        actual.Should().BeNull();
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData(" ")]
    internal void GivenToDecimalOrNullLocalWhenInputIsNullOrWhiteSpaceThenResultIsNull(string? @this)
    {
        // Arrange

        // Act
        decimal? actual = @this.ToDecimalOrNullLocal();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenTryConvertToDecimalLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = decimal.MaxValue.ToString(CultureInfo.CurrentCulture);
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
        string @this = "foo";

        // Act
        bool isDecimal = @this.TryConvertToDecimalLocal(out decimal actual);

        // Assert
        isDecimal.Should().BeFalse();
        actual.Should().Be(default);
    }
}
