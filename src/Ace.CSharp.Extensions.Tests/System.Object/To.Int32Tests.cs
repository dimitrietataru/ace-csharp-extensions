namespace Ace.CSharp.Extensions.Tests.ObjectExtensions;

public sealed class ToInt32Tests
{
    [Fact]
    internal void GivenToInt32WhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = int.MaxValue;
        int expected = int.MaxValue;

        // Act
        int actual = @this.ToInt32(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToInt32WhenInputIsNotValidThenFormatExceptionIsThrown()
    {
        // Arrange
        object @this = "foo";

        // Act
        var action = () => @this.ToInt32(provider: default);

        // Assert
        action.Should().Throw<FormatException>();
    }

    [Fact]
    internal void GivenToInt32WhenInputIsNotValidThenOverflowExceptionIsThrown()
    {
        // Arrange
        object @this = $"{int.MaxValue}{int.MaxValue}";

        // Act
        var action = () => @this.ToInt32(provider: default);

        // Assert
        action.Should().Throw<OverflowException>();
    }

    [Fact]
    internal void GivenToInt32OrDefaultWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = int.MaxValue;
        int expected = int.MaxValue;

        // Act
        int actual = @this.ToInt32OrDefault(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToInt32OrDefaultWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        object @this = "foo";
        int expected = int.MaxValue;

        // Act
        int actual = @this.ToInt32OrDefault(provider: default, @default: expected);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToInt32WhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = int.MaxValue;
        int expected = int.MaxValue;

        // Act
        bool isInt32 = @this.TryConvertToInt32(provider: default, out int actual);

        // Assert
        isInt32.Should().BeTrue();
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToInt32WhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        object @this = "foo";

        // Act
        bool isInt32 = @this.TryConvertToInt32(provider: default, out int actual);

        // Assert
        isInt32.Should().BeFalse();
        actual.Should().Be(default);
    }
}
