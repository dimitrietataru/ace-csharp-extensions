namespace Ace.CSharp.Extensions.Tests.ObjectExtensions;

public sealed class ToByteTests
{
    [Fact]
    internal void GivenToByteWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = (byte)128;
        byte expected = 128;

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
        object @this = "512";

        // Act
        var action = () => @this.ToByte(provider: default);

        // Assert
        action.Should().Throw<OverflowException>();
    }

    [Fact]
    internal void GivenToByteOrDefaultWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = (byte)128;
        byte expected = 128;

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
        byte expected = 128;

        // Act
        byte actual = @this.ToByteOrDefault(provider: default, @default: expected);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToByteWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = (byte)128;
        byte expected = 128;

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
