namespace Ace.CSharp.Extensions.Tests.ObjectExtensions;

public sealed class ToSByteTests
{
    [Fact]
    internal void GivenToSByteWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = sbyte.MaxValue;
        sbyte expected = sbyte.MaxValue;

        // Act
        sbyte actual = @this.ToSByte(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToSByteWhenInputIsNotValidThenFormatExceptionIsThrown()
    {
        // Arrange
        object @this = "foo";

        // Act
        var action = () => @this.ToSByte(provider: default);

        // Assert
        action.Should().Throw<FormatException>();
    }

    [Fact]
    internal void GivenToSByteWhenInputIsNotValidThenInvalidCastExceptionIsThrown()
    {
        // Arrange
        object @this = new { Foo = "foo" };

        // Act
        var action = () => @this.ToSByte(provider: default);

        // Assert
        action.Should().Throw<InvalidCastException>();
    }

    [Fact]
    internal void GivenToSByteWhenInputIsNotValidThenOverflowExceptionIsThrown()
    {
        // Arrange
        object @this = $"{sbyte.MaxValue}{sbyte.MaxValue}";

        // Act
        var action = () => @this.ToSByte(provider: default);

        // Assert
        action.Should().Throw<OverflowException>();
    }

    [Fact]
    internal void GivenToSByteOrDefaultWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = sbyte.MaxValue;
        sbyte expected = sbyte.MaxValue;

        // Act
        sbyte actual = @this.ToSByteOrDefault(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToSByteOrDefaultWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        object @this = "foo";
        sbyte expected = sbyte.MaxValue;

        // Act
        sbyte actual = @this.ToSByteOrDefault(provider: default, @default: expected);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToSByteOrNullWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = sbyte.MaxValue;
        sbyte expected = sbyte.MaxValue;

        // Act
        sbyte? actual = @this.ToSByteOrNull(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToSByteOrNullWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        object @this = "foo";

        // Act
        sbyte? actual = @this.ToSByteOrNull(provider: default);

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToSByteOrNullWhenInputIsNullThenResultIsNull()
    {
        // Arrange
        object? @this = null;

        // Act
        sbyte? actual = @this.ToSByteOrNull(provider: default);

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenTryConvertToSByteWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = sbyte.MaxValue;
        sbyte expected = sbyte.MaxValue;

        // Act
        bool isSByte = @this.TryConvertToSByte(provider: default, out sbyte actual);

        // Assert
        isSByte.Should().BeTrue();
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToSByteWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        object @this = "foo";

        // Act
        bool isSByte = @this.TryConvertToSByte(provider: default, out sbyte actual);

        // Assert
        isSByte.Should().BeFalse();
        actual.Should().Be(default);
    }
}
