namespace Ace.CSharp.Extensions.Tests.ObjectExtensions;

public sealed class ToInt64LocalTests
{
    [Fact]
    internal void GivenToInt64LocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = long.MaxValue.ToString(CultureInfo.CurrentCulture);
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
        object @this = "foo";

        // Act
        var action = () => @this.ToInt64Local();

        // Assert
        action.Should().Throw<FormatException>();
    }

    [Fact]
    internal void GivenToInt64LocalWhenInputIsNotValidThenInvalidCastExceptionIsThrown()
    {
        // Arrange
        object @this = new { Foo = "foo" };

        // Act
        var action = () => @this.ToInt64Local();

        // Assert
        action.Should().Throw<InvalidCastException>();
    }

    [Fact]
    internal void GivenToInt64LocalWhenInputIsNotValidThenOverflowExceptionIsThrown()
    {
        // Arrange
        object @this = $"{long.MaxValue}{long.MaxValue}";

        // Act
        var action = () => @this.ToInt64Local();

        // Assert
        action.Should().Throw<OverflowException>();
    }

    [Fact]
    internal void GivenToInt64OrDefaultLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = long.MaxValue.ToString(CultureInfo.CurrentCulture);
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
        object @this = "foo";
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
        object @this = long.MaxValue.ToString(CultureInfo.CurrentCulture);
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
        object @this = "foo";

        // Act
        bool isInt64 = @this.TryConvertToInt64Local(out long actual);

        // Assert
        isInt64.Should().BeFalse();
        actual.Should().Be(default);
    }
}
