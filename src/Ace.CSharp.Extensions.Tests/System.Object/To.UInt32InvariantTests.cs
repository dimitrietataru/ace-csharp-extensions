namespace Ace.CSharp.Extensions.Tests.ObjectExtensions;

public sealed class ToUInt32InvariantTests
{
    [Fact]
    internal void GivenToUInt32InvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = uint.MaxValue;
        uint expected = uint.MaxValue;

        // Act
        uint actual = @this.ToUInt32Invariant();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToUInt32InvariantWhenInputIsNotValidThenFormatExceptionIsThrown()
    {
        // Arrange
        object @this = "foo";

        // Act
        var action = () => @this.ToUInt32Invariant();

        // Assert
        action.Should().Throw<FormatException>();
    }

    [Fact]
    internal void GivenToUInt32InvariantWhenInputIsNotValidThenInvalidCastExceptionIsThrown()
    {
        // Arrange
        object @this = new { Foo = "foo" };

        // Act
        var action = () => @this.ToUInt32Invariant();

        // Assert
        action.Should().Throw<InvalidCastException>();
    }

    [Fact]
    internal void GivenToUInt32InvariantWhenInputIsNotValidThenOverflowExceptionIsThrown()
    {
        // Arrange
        object @this = $"{uint.MaxValue}{uint.MaxValue}";

        // Act
        var action = () => @this.ToUInt32Invariant();

        // Assert
        action.Should().Throw<OverflowException>();
    }

    [Fact]
    internal void GivenToUInt32OrDefaultInvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = uint.MaxValue;
        uint expected = uint.MaxValue;

        // Act
        uint actual = @this.ToUInt32OrDefaultInvariant();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToUInt32OrDefaultInvariantWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        object @this = "foo";
        uint expected = uint.MaxValue;

        // Act
        uint actual = @this.ToUInt32OrDefaultInvariant(@default: expected);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToUInt32InvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = uint.MaxValue;
        uint expected = uint.MaxValue;

        // Act
        bool isUInt32 = @this.TryConvertToUInt32Invariant(out uint actual);

        // Assert
        isUInt32.Should().BeTrue();
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToUInt32InvariantWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        object @this = "foo";

        // Act
        bool isUInt32 = @this.TryConvertToUInt32Invariant(out uint actual);

        // Assert
        isUInt32.Should().BeFalse();
        actual.Should().Be(default);
    }
}
