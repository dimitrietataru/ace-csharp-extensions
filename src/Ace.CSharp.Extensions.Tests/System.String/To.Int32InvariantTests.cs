namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToInt32InvariantTests
{
    [Fact]
    internal void GivenToInt32InvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = int.MaxValue.ToString(CultureInfo.InvariantCulture);
        int expected = int.MaxValue;

        // Act
        int actual = @this.ToInt32Invariant();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToInt32InvariantWhenInputIsNotValidThenFormatExceptionIsThrown()
    {
        // Arrange
        string @this = "foo";

        // Act
        var action = () => @this.ToInt32Invariant();

        // Assert
        action.Should().Throw<FormatException>();
    }

    [Fact]
    internal void GivenToInt32InvariantWhenInputIsNotValidThenOverflowExceptionIsThrown()
    {
        // Arrange
        string @this = $"{int.MaxValue}{int.MaxValue}";

        // Act
        var action = () => @this.ToInt32Invariant();

        // Assert
        action.Should().Throw<OverflowException>();
    }

    [Fact]
    internal void GivenToInt32OrDefaultInvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = int.MaxValue.ToString(CultureInfo.InvariantCulture);
        int expected = int.MaxValue;

        // Act
        int actual = @this.ToInt32OrDefaultInvariant();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToInt32OrDefaultInvariantWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        string @this = "foo";
        int expected = int.MaxValue;

        // Act
        int actual = @this.ToInt32OrDefaultInvariant(@default: expected);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToInt32InvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = int.MaxValue.ToString(CultureInfo.InvariantCulture);
        int expected = int.MaxValue;

        // Act
        bool isInt32 = @this.TryConvertToInt32Invariant(out int actual);

        // Assert
        isInt32.Should().BeTrue();
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToInt32InvariantWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        string @this = "foo";

        // Act
        bool isInt32 = @this.TryConvertToInt32Invariant(out int actual);

        // Assert
        isInt32.Should().BeFalse();
        actual.Should().Be(default);
    }
}
