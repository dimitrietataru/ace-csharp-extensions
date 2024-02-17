namespace Ace.CSharp.Extensions.Tests.ObjectExtensions;

public sealed class ToSingleInvariantTests
{
    [Fact]
    internal void GivenToSingleInvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = float.MaxValue;
        float expected = float.MaxValue;

        // Act
        float actual = @this.ToSingleInvariant();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToSingleInvariantWhenInputIsNotValidThenFormatExceptionIsThrown()
    {
        // Arrange
        object @this = "foo";

        // Act
        var action = () => @this.ToSingleInvariant();

        // Assert
        action.Should().Throw<FormatException>();
    }

    [Fact]
    internal void GivenToSingleInvariantWhenInputIsNotValidThenInvalidCastExceptionIsThrown()
    {
        // Arrange
        object @this = new { Foo = "foo" };

        // Act
        var action = () => @this.ToSingleInvariant();

        // Assert
        action.Should().Throw<InvalidCastException>();
    }

    [Fact]
    internal void GivenToSingleInvariantWhenInputIsNotValidThenOverflowExceptionIsNotThrown()
    {
        // Arrange
        object @this = $"{int.MaxValue}{float.MaxValue}";

        // Act
        var action = () => @this.ToSingleInvariant();

        // Assert
        action.Should().NotThrow<OverflowException>();
        action().Should().Be(float.PositiveInfinity);
    }

    [Fact]
    internal void GivenToSingleOrDefaultInvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = float.MaxValue;
        float expected = float.MaxValue;

        // Act
        float actual = @this.ToSingleOrDefaultInvariant();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToSingleOrDefaultInvariantWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        object @this = "foo";
        float expected = float.MaxValue;

        // Act
        float actual = @this.ToSingleOrDefaultInvariant(@default: expected);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToSingleOrNullInvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = float.MaxValue;
        float expected = float.MaxValue;

        // Act
        float? actual = @this.ToSingleOrNullInvariant();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToSingleOrNullInvariantWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        object @this = "foo";

        // Act
        float? actual = @this.ToSingleOrNullInvariant();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToSingleOrNullInvariantWhenInputIsNullThenResultIsNull()
    {
        // Arrange
        object? @this = null;

        // Act
        float? actual = @this.ToSingleOrNullInvariant();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenTryConvertToSingleInvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = float.MaxValue;
        float expected = float.MaxValue;

        // Act
        bool isSingle = @this.TryConvertToSingleInvariant(out float actual);

        // Assert
        isSingle.Should().BeTrue();
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToSingleInvariantWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        object @this = "foo";

        // Act
        bool isSingle = @this.TryConvertToSingleInvariant(out float actual);

        // Assert
        isSingle.Should().BeFalse();
        actual.Should().Be(default);
    }
}
