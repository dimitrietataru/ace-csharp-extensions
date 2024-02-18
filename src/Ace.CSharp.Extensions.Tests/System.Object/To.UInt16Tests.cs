namespace Ace.CSharp.Extensions.Tests.ObjectExtensions;

public sealed class ToUInt16Tests
{
    [Fact]
    internal void GivenToUInt16WhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = ushort.MaxValue;
        ushort expected = ushort.MaxValue;

        // Act
        ushort actual = @this.ToUInt16(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToUInt16WhenInputIsNotValidThenFormatExceptionIsThrown()
    {
        // Arrange
        object @this = "foo";

        // Act
        var action = () => @this.ToUInt16(provider: default);

        // Assert
        action.Should().Throw<FormatException>();
    }

    [Fact]
    internal void GivenToUInt16WhenInputIsNotValidThenInvalidCastExceptionIsThrown()
    {
        // Arrange
        object @this = new { Foo = "foo" };

        // Act
        var action = () => @this.ToUInt16(provider: default);

        // Assert
        action.Should().Throw<InvalidCastException>();
    }

    [Fact]
    internal void GivenToUInt16WhenInputIsNotValidThenOverflowExceptionIsThrown()
    {
        // Arrange
        object @this = $"{ushort.MaxValue}{ushort.MaxValue}";

        // Act
        var action = () => @this.ToUInt16(provider: default);

        // Assert
        action.Should().Throw<OverflowException>();
    }

    [Fact]
    internal void GivenToUInt16OrDefaultWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = ushort.MaxValue;
        ushort expected = ushort.MaxValue;

        // Act
        ushort actual = @this.ToUInt16OrDefault(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToUInt16OrDefaultWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        object @this = "foo";
        ushort expected = ushort.MaxValue;

        // Act
        ushort actual = @this.ToUInt16OrDefault(provider: default, @default: expected);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToUInt16OrNullWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = ushort.MaxValue;
        ushort expected = ushort.MaxValue;

        // Act
        ushort? actual = @this.ToUInt16OrNull(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToUInt16OrNullWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        object @this = "foo";

        // Act
        ushort? actual = @this.ToUInt16OrNull(provider: default);

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToUInt16OrNullWhenInputIsNullThenResultIsNull()
    {
        // Arrange
        object? @this = null;

        // Act
        ushort? actual = @this.ToUInt16OrNull(provider: default);

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenTryConvertToUInt16WhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = ushort.MaxValue;
        ushort expected = ushort.MaxValue;

        // Act
        bool isUInt16 = @this.TryConvertToUInt16(provider: default, out ushort actual);

        // Assert
        isUInt16.Should().BeTrue();
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToUInt16WhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        object @this = "foo";

        // Act
        bool isUInt16 = @this.TryConvertToUInt16(provider: default, out ushort actual);

        // Assert
        isUInt16.Should().BeFalse();
        actual.Should().Be(default);
    }
}
