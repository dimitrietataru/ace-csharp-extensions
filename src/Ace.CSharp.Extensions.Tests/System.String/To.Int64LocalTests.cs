namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToInt64LocalTests
{
    [Fact]
    internal void GivenToInt64LocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = long.MaxValue.ToString(CultureInfo.CurrentCulture);
        long expected = long.MaxValue;

        // Act
        long actual = @this.ToInt64Local();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToInt64LocalWhenInputIsNotValidThenFormatExceptionIsThrown()
    {
        // Arrange
        string @this = "foo";

        // Act
        var action = () => @this.ToInt64Local();

        // Assert
        action.Should().Throw<FormatException>();
    }

    [Fact]
    internal void GivenToInt64LocalWhenInputIsNotValidThenOverflowExceptionIsThrown()
    {
        // Arrange
        string @this = $"{long.MaxValue}{long.MaxValue}";

        // Act
        var action = () => @this.ToInt64Local();

        // Assert
        action.Should().Throw<OverflowException>();
    }

    [Fact]
    internal void GivenToInt64OrDefaultLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = long.MaxValue.ToString(CultureInfo.CurrentCulture);
        long expected = long.MaxValue;

        // Act
        long actual = @this.ToInt64OrDefaultLocal();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToInt64OrDefaultLocalWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        string @this = "foo";
        long expected = long.MaxValue;

        // Act
        long actual = @this.ToInt64OrDefaultLocal(@default: expected);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToInt64LocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = long.MaxValue.ToString(CultureInfo.CurrentCulture);
        long expected = long.MaxValue;

        // Act
        bool isInt64 = @this.TryConvertToInt64Local(out long actual);

        // Assert
        isInt64.Should().BeTrue();
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToInt64LocalWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        string @this = "foo";

        // Act
        bool isInt64 = @this.TryConvertToInt64Local(out long actual);

        // Assert
        isInt64.Should().BeFalse();
        actual.Should().Be(default);
    }
}
