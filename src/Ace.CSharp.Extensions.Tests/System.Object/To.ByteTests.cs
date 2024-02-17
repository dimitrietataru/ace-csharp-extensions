namespace Ace.CSharp.Extensions.Tests.ObjectExtensions;

public sealed class ToByteTests
{
    [Fact]
    internal void GivenToByteWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = byte.MaxValue;
        byte expected = byte.MaxValue;

        // Act
        byte actual = @this.ToByte(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToByteWhenInputIsNotValidThenFormatExceptionIsThrown()
    {
        // Arrange
        object @this = "foo";

        // Act
        var action = () => @this.ToByte(provider: default);

        // Assert
        action.Should().Throw<FormatException>();
    }

    [Fact]
    internal void GivenToByteWhenInputIsNotValidThenInvalidCastExceptionIsThrown()
    {
        // Arrange
        object @this = new { Foo = "foo" };

        // Act
        var action = () => @this.ToByte(provider: default);

        // Assert
        action.Should().Throw<InvalidCastException>();
    }

    [Fact]
    internal void GivenToByteWhenInputIsNotValidThenOverflowExceptionIsThrown()
    {
        // Arrange
        object @this = $"{byte.MaxValue}{byte.MaxValue}";

        // Act
        var action = () => @this.ToByte(provider: default);

        // Assert
        action.Should().Throw<OverflowException>();
    }

    [Fact]
    internal void GivenToByteOrDefaultWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = byte.MaxValue;
        byte expected = byte.MaxValue;

        // Act
        byte actual = @this.ToByteOrDefault(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToByteOrDefaultWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        object @this = "foo";
        byte expected = byte.MaxValue;

        // Act
        byte actual = @this.ToByteOrDefault(provider: default, @default: expected);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToByteOrNullWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = byte.MaxValue;
        byte expected = byte.MaxValue;

        // Act
        byte? actual = @this.ToByteOrNull(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToByteOrNullWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        object @this = "foo";

        // Act
        byte? actual = @this.ToByteOrNull(provider: default);

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToByteOrNullWhenInputIsNullThenResultIsNull()
    {
        // Arrange
        object? @this = null;

        // Act
        byte? actual = @this.ToByteOrNull(provider: default);

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenTryConvertToByteWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = byte.MaxValue;
        byte expected = byte.MaxValue;

        // Act
        bool isByte = @this.TryConvertToByte(provider: default, out byte actual);

        // Assert
        isByte.Should().BeTrue();
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToByteWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        object @this = "foo";

        // Act
        bool isByte = @this.TryConvertToByte(provider: default, out byte actual);

        // Assert
        isByte.Should().BeFalse();
        actual.Should().Be(default);
    }
}
