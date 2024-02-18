namespace Ace.CSharp.Extensions.Tests.ObjectExtensions;

public sealed class ToInt32InvariantTests
{
    [Fact]
    internal void GivenToInt32InvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = int.MaxValue;
        int expected = int.MaxValue;

        // Act
        int actual = @this.ToInt32Invariant();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToInt32InvariantWhenInputIsNotValidThenFormatExceptionIsThrown()
    {
        // Arrange
        object @this = "foo";

        // Act
        var action = () => @this.ToInt32Invariant();

        // Assert
        action.Should().Throw<FormatException>();
    }

    [Fact]
    internal void GivenToInt32InvariantWhenInputIsNotValidThenOverflowExceptionIsThrown()
    {
        // Arrange
        object @this = $"{int.MaxValue}{int.MaxValue}";

        // Act
        var action = () => @this.ToInt32Invariant();

        // Assert
        action.Should().Throw<OverflowException>();
    }

    [Fact]
    internal void GivenToInt32OrDefaultInvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = int.MaxValue;
        int expected = int.MaxValue;

        // Act
        int actual = @this.ToInt32OrDefaultInvariant();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToInt32OrDefaultInvariantWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        object @this = "foo";
        int expected = int.MaxValue;

        // Act
        int actual = @this.ToInt32OrDefaultInvariant(@default: expected);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToInt32OrNullInvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = int.MaxValue;
        int expected = int.MaxValue;

        // Act
        int? actual = @this.ToInt32OrNullInvariant();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToInt32OrNullInvariantWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        object @this = "foo";

        // Act
        int? actual = @this.ToInt32OrNullInvariant();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToInt32OrNullInvariantWhenInputIsNullThenResultIsNull()
    {
        // Arrange
        object? @this = null;

        // Act
        int? actual = @this.ToInt32OrNullInvariant();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenTryConvertToInt32InvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = int.MaxValue;
        int expected = int.MaxValue;

        // Act
        bool isInt32 = @this.TryConvertToInt32Invariant(out int actual);

        // Assert
        isInt32.Should().BeTrue();
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToInt32InvariantWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        object @this = "foo";

        // Act
        bool isInt32 = @this.TryConvertToInt32Invariant(out int actual);

        // Assert
        isInt32.Should().BeFalse();
        actual.Should().Be(default);
    }
}
