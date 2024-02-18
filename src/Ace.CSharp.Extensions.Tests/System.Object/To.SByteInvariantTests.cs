namespace Ace.CSharp.Extensions.Tests.ObjectExtensions;

public sealed class ToSByteInvariantTests
{
    [Fact]
    internal void GivenToSByteInvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = sbyte.MaxValue;
        sbyte expected = sbyte.MaxValue;

        // Act
        sbyte actual = @this.ToSByteInvariant();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToSByteInvariantWhenInputIsNotValidThenFormatExceptionIsThrown()
    {
        // Arrange
        object @this = "foo";

        // Act
        var action = () => @this.ToSByteInvariant();

        // Assert
        action.Should().Throw<FormatException>();
    }

    [Fact]
    internal void GivenToSByteInvariantWhenInputIsNotValidThenInvalidCastExceptionIsThrown()
    {
        // Arrange
        object @this = new { Foo = "foo" };

        // Act
        var action = () => @this.ToSByteInvariant();

        // Assert
        action.Should().Throw<InvalidCastException>();
    }

    [Fact]
    internal void GivenToSByteInvariantWhenInputIsNotValidThenOverflowExceptionIsThrown()
    {
        // Arrange
        object @this = $"{sbyte.MaxValue}{sbyte.MaxValue}";

        // Act
        var action = () => @this.ToSByteInvariant();

        // Assert
        action.Should().Throw<OverflowException>();
    }

    [Fact]
    internal void GivenToSByteOrDefaultInvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = sbyte.MaxValue;
        sbyte expected = sbyte.MaxValue;

        // Act
        sbyte actual = @this.ToSByteOrDefaultInvariant();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToSByteOrDefaultInvariantWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        object @this = "foo";
        sbyte expected = sbyte.MaxValue;

        // Act
        sbyte actual = @this.ToSByteOrDefaultInvariant(@default: expected);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToByteOrNullInvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = sbyte.MaxValue;
        sbyte expected = sbyte.MaxValue;

        // Act
        sbyte? actual = @this.ToSByteOrNullInvariant();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToByteOrNullInvariantWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        object @this = "foo";

        // Act
        sbyte? actual = @this.ToSByteOrNullInvariant();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToByteOrNullInvariantWhenInputIsNullThenResultIsNull()
    {
        // Arrange
        object? @this = null;

        // Act
        sbyte? actual = @this.ToSByteOrNullInvariant();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenTryConvertToSByteInvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = sbyte.MaxValue;
        sbyte expected = sbyte.MaxValue;

        // Act
        bool isSByte = @this.TryConvertToSByteInvariant(out sbyte actual);

        // Assert
        isSByte.Should().BeTrue();
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToSByteInvariantWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        object @this = "foo";

        // Act
        bool isSByte = @this.TryConvertToSByteInvariant(out sbyte actual);

        // Assert
        isSByte.Should().BeFalse();
        actual.Should().Be(default);
    }
}
