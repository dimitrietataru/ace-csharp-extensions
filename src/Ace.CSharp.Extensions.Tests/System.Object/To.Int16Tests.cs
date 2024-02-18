namespace Ace.CSharp.Extensions.Tests.ObjectExtensions;

public sealed class ToInt16Tests
{
    [Fact]
    internal void GivenToInt16WhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = short.MaxValue;
        short expected = short.MaxValue;

        // Act
        short actual = @this.ToInt16(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToInt16WhenInputIsNotValidThenFormatExceptionIsThrown()
    {
        // Arrange
        object @this = "foo";

        // Act
        var action = () => @this.ToInt16(provider: default);

        // Assert
        action.Should().Throw<FormatException>();
    }

    [Fact]
    internal void GivenToInt16WhenInputIsNotValidThenInvalidCastExceptionIsThrown()
    {
        // Arrange
        object @this = new { Foo = "foo" };

        // Act
        var action = () => @this.ToInt16(provider: default);

        // Assert
        action.Should().Throw<InvalidCastException>();
    }

    [Fact]
    internal void GivenToInt16WhenInputIsNotValidThenOverflowExceptionIsThrown()
    {
        // Arrange
        object @this = $"{short.MaxValue}{short.MaxValue}";

        // Act
        var action = () => @this.ToInt16(provider: default);

        // Assert
        action.Should().Throw<OverflowException>();
    }

    [Fact]
    internal void GivenToInt16OrDefaultWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = short.MaxValue;
        short expected = short.MaxValue;

        // Act
        short actual = @this.ToInt16OrDefault(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToInt16OrDefaultWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        object @this = "foo";
        short expected = short.MaxValue;

        // Act
        short actual = @this.ToInt16OrDefault(provider: default, @default: expected);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToInt16OrNullWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = short.MaxValue;
        short expected = short.MaxValue;

        // Act
        short? actual = @this.ToInt16OrNull(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToInt16OrNullWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        object @this = "foo";

        // Act
        short? actual = @this.ToInt16OrNull(provider: default);

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToInt16OrNullWhenInputIsNullThenResultIsNull()
    {
        // Arrange
        object? @this = null;

        // Act
        short? actual = @this.ToInt16OrNull(provider: default);

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenTryConvertToInt16WhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = short.MaxValue;
        short expected = short.MaxValue;

        // Act
        bool isInt16 = @this.TryConvertToInt16(provider: default, out short actual);

        // Assert
        isInt16.Should().BeTrue();
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToInt16WhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        object @this = "foo";

        // Act
        bool isInt16 = @this.TryConvertToInt16(provider: default, out short actual);

        // Assert
        isInt16.Should().BeFalse();
        actual.Should().Be(default);
    }
}
