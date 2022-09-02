namespace Ace.CSharp.Extensions.Tests.ObjectExtensions;

public sealed class ToUInt64Tests
{
    [Fact]
    internal void GivenToUInt64WhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = ulong.MaxValue;
        ulong expected = ulong.MaxValue;

        // Act
        ulong actual = @this.ToUInt64(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToUInt64WhenInputIsNotValidThenFormatExceptionIsThrown()
    {
        // Arrange
        object @this = "foo";

        // Act
        var action = () => @this.ToUInt64(provider: default);

        // Assert
        action.Should().Throw<FormatException>();
    }

    [Fact]
    internal void GivenToUInt64WhenInputIsNotValidThenInvalidCastExceptionIsThrown()
    {
        // Arrange
        object @this = new { Foo = "foo" };

        // Act
        var action = () => @this.ToUInt64(provider: default);

        // Assert
        action.Should().Throw<InvalidCastException>();
    }

    [Fact]
    internal void GivenToUInt64WhenInputIsNotValidThenOverflowExceptionIsThrown()
    {
        // Arrange
        object @this = $"{ulong.MaxValue}{ulong.MaxValue}";

        // Act
        var action = () => @this.ToUInt64(provider: default);

        // Assert
        action.Should().Throw<OverflowException>();
    }

    [Fact]
    internal void GivenToUInt64OrDefaultWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = ulong.MaxValue;
        ulong expected = ulong.MaxValue;

        // Act
        ulong actual = @this.ToUInt64OrDefault(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToUInt64OrDefaultWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        object @this = "foo";
        ulong expected = ulong.MaxValue;

        // Act
        ulong actual = @this.ToUInt64OrDefault(provider: default, @default: expected);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToUInt64WhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = ulong.MaxValue;
        ulong expected = ulong.MaxValue;

        // Act
        bool isUInt64 = @this.TryConvertToUInt64(provider: default, out ulong actual);

        // Assert
        isUInt64.Should().BeTrue();
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToUInt64WhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        object @this = "foo";

        // Act
        bool isUInt64 = @this.TryConvertToUInt64(provider: default, out ulong actual);

        // Assert
        isUInt64.Should().BeFalse();
        actual.Should().Be(default);
    }
}
