namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToInt64Tests
{
    [Fact]
    internal void GivenToInt64WhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = long.MaxValue.ToString(provider: default);
        long expected = long.MaxValue;

        // Act
        long actual = @this.ToInt64(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToInt64WhenInputIsNotValidThenFormatExceptionIsThrown()
    {
        // Arrange
        string @this = "foo";

        // Act
        var action = () => @this.ToInt64(provider: default);

        // Assert
        action.Should().Throw<FormatException>();
    }

    [Fact]
    internal void GivenToInt64WhenInputIsNotValidThenOverflowExceptionIsThrown()
    {
        // Arrange
        string @this = $"{long.MaxValue}{long.MaxValue}";

        // Act
        var action = () => @this.ToInt64(provider: default);

        // Assert
        action.Should().Throw<OverflowException>();
    }

    [Fact]
    internal void GivenToInt64OrDefaultWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = long.MaxValue.ToString(provider: default);
        long expected = long.MaxValue;

        // Act
        long actual = @this.ToInt64OrDefault(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToInt64OrDefaultWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        string @this = "foo";
        long expected = long.MaxValue;

        // Act
        long actual = @this.ToInt64OrDefault(provider: default, @default: expected);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToInt64WhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = long.MaxValue.ToString(provider: default);
        long expected = long.MaxValue;

        // Act
        bool isInt64 = @this.TryConvertToInt64(provider: default, out long actual);

        // Assert
        isInt64.Should().BeTrue();
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToInt64WhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        string @this = "foo";

        // Act
        bool isInt64 = @this.TryConvertToInt64(provider: default, out long actual);

        // Assert
        isInt64.Should().BeFalse();
        actual.Should().Be(default);
    }
}
