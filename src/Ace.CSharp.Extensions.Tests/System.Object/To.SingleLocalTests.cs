namespace Ace.CSharp.Extensions.Tests.ObjectExtensions;

public sealed class ToSingleLocalTests
{
    [Fact]
    internal void GivenToSingleLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = float.MaxValue;
        float expected = float.MaxValue;

        // Act
        float actual = @this.ToSingleLocal();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToSingleLocalWhenInputIsNotValidThenFormatExceptionIsThrown()
    {
        // Arrange
        object @this = "foo";

        // Act
        var action = () => @this.ToSingleLocal();

        // Assert
        action.Should().Throw<FormatException>();
    }

    [Fact]
    internal void GivenToSingleLocalWhenInputIsNotValidThenInvalidCastExceptionIsThrown()
    {
        // Arrange
        object @this = new { Foo = "foo" };

        // Act
        var action = () => @this.ToSingleLocal();

        // Assert
        action.Should().Throw<InvalidCastException>();
    }

    [Fact]
    internal void GivenToSingleLocalWhenInputIsNotValidThenOverflowExceptionIsNotThrown()
    {
        // Arrange
        object @this = $"{int.MaxValue}{float.MaxValue}";

        // Act
        var action = () => @this.ToSingleLocal();

        // Assert
        action.Should().NotThrow<OverflowException>();
        action().Should().Be(float.PositiveInfinity);
    }

    [Fact]
    internal void GivenToSingleOrDefaultLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = float.MaxValue;
        float expected = float.MaxValue;

        // Act
        float actual = @this.ToSingleOrDefaultLocal();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToSingleOrDefaultLocalWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        object @this = "foo";
        float expected = float.MaxValue;

        // Act
        float actual = @this.ToSingleOrDefaultLocal(@default: expected);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToSingleLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = float.MaxValue;
        float expected = float.MaxValue;

        // Act
        bool isSingle = @this.TryConvertToSingleLocal(out float actual);

        // Assert
        isSingle.Should().BeTrue();
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToSingleLocalWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        object @this = "foo";

        // Act
        bool isSingle = @this.TryConvertToSingleLocal(out float actual);

        // Assert
        isSingle.Should().BeFalse();
        actual.Should().Be(default);
    }
}
