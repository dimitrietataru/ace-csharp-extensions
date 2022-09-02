namespace Ace.CSharp.Extensions.Tests.ObjectExtensions;

public sealed class ToUInt32Tests
{
    [Fact]
    internal void GivenToUInt32WhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = uint.MaxValue;
        uint expected = uint.MaxValue;

        // Act
        uint actual = @this.ToUInt32(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToUInt32WhenInputIsNotValidThenFormatExceptionIsThrown()
    {
        // Arrange
        object @this = "foo";

        // Act
        var action = () => @this.ToUInt32(provider: default);

        // Assert
        action.Should().Throw<FormatException>();
    }

    [Fact]
    internal void GivenToUInt32WhenInputIsNotValidThenInvalidCastExceptionIsThrown()
    {
        // Arrange
        object @this = new { Foo = "foo" };

        // Act
        var action = () => @this.ToUInt32(provider: default);

        // Assert
        action.Should().Throw<InvalidCastException>();
    }

    [Fact]
    internal void GivenToUInt32WhenInputIsNotValidThenOverflowExceptionIsThrown()
    {
        // Arrange
        object @this = $"{uint.MaxValue}{uint.MaxValue}";

        // Act
        var action = () => @this.ToUInt32(provider: default);

        // Assert
        action.Should().Throw<OverflowException>();
    }

    [Fact]
    internal void GivenToUInt32OrDefaultWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = uint.MaxValue;
        uint expected = uint.MaxValue;

        // Act
        uint actual = @this.ToUInt32OrDefault(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToUInt32OrDefaultWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        object @this = "foo";
        uint expected = uint.MaxValue;

        // Act
        uint actual = @this.ToUInt32OrDefault(provider: default, @default: expected);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToUInt32WhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = uint.MaxValue;
        uint expected = uint.MaxValue;

        // Act
        bool isUInt32 = @this.TryConvertToUInt32(provider: default, out uint actual);

        // Assert
        isUInt32.Should().BeTrue();
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToUInt32WhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        object @this = "foo";

        // Act
        bool isUInt32 = @this.TryConvertToUInt32(provider: default, out uint actual);

        // Assert
        isUInt32.Should().BeFalse();
        actual.Should().Be(default);
    }
}
