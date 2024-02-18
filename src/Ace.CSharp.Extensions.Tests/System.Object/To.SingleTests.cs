namespace Ace.CSharp.Extensions.Tests.ObjectExtensions;

public sealed class ToSingleTests
{
    [Fact]
    internal void GivenToSingleWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = float.MaxValue;
        float expected = float.MaxValue;

        // Act
        float actual = @this.ToSingle(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToSingleWhenInputIsNotValidThenFormatExceptionIsThrown()
    {
        // Arrange
        object @this = "foo";

        // Act
        var action = () => @this.ToSingle(provider: default);

        // Assert
        action.Should().Throw<FormatException>();
    }

    [Fact]
    internal void GivenToSingleWhenInputIsNotValidThenInvalidCastExceptionIsThrown()
    {
        // Arrange
        object @this = new { Foo = "foo" };

        // Act
        var action = () => @this.ToSingle(provider: default);

        // Assert
        action.Should().Throw<InvalidCastException>();
    }

    [Fact]
    internal void GivenToSingleWhenInputIsNotValidThenOverflowExceptionIsNotThrown()
    {
        // Arrange
        object @this = $"{int.MaxValue}{float.MaxValue}";

        // Act
        var action = () => @this.ToSingle(provider: default);

        // Assert
        action.Should().NotThrow<OverflowException>();
        action().Should().Be(float.PositiveInfinity);
    }

    [Fact]
    internal void GivenToSingleOrDefaultWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = float.MaxValue;
        float expected = float.MaxValue;

        // Act
        float actual = @this.ToSingleOrDefault(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToSingleOrDefaultWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        object @this = "foo";
        float expected = float.MaxValue;

        // Act
        float actual = @this.ToSingleOrDefault(provider: default, @default: expected);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToSingleOrNullWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = float.MaxValue;
        float expected = float.MaxValue;

        // Act
        float? actual = @this.ToSingleOrNull(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToSingleOrNullWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        object @this = "foo";

        // Act
        float? actual = @this.ToSingleOrNull(provider: default);

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToSingleOrNullWhenInputIsNullThenResultIsNull()
    {
        // Arrange
        object? @this = null;

        // Act
        float? actual = @this.ToSingleOrNull(provider: default);

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenTryConvertToSingleWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = float.MaxValue;
        float expected = float.MaxValue;

        // Act
        bool isSingle = @this.TryConvertToSingle(provider: default, out float actual);

        // Assert
        isSingle.Should().BeTrue();
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToSingleWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        object @this = "foo";

        // Act
        bool isSingle = @this.TryConvertToSingle(provider: default, out float actual);

        // Assert
        isSingle.Should().BeFalse();
        actual.Should().Be(default);
    }
}
