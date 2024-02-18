namespace Ace.CSharp.Extensions.Tests.ObjectExtensions;

public sealed class ToInt16LocalTests
{
    [Fact]
    internal void GivenToInt16LocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = short.MaxValue;
        short expected = short.MaxValue;

        // Act
        short actual = @this.ToInt16Local();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToInt16LocalWhenInputIsNotValidThenFormatExceptionIsThrown()
    {
        // Arrange
        object @this = "foo";

        // Act
        var action = () => @this.ToInt16Local();

        // Assert
        action.Should().Throw<FormatException>();
    }

    [Fact]
    internal void GivenToInt16LocalWhenInputIsNotValidThenInvalidCastExceptionIsThrown()
    {
        // Arrange
        object @this = new { Foo = "foo" };

        // Act
        var action = () => @this.ToInt16Local();

        // Assert
        action.Should().Throw<InvalidCastException>();
    }

    [Fact]
    internal void GivenToInt16LocalWhenInputIsNotValidThenOverflowExceptionIsThrown()
    {
        // Arrange
        object @this = $"{short.MaxValue}{short.MaxValue}";

        // Act
        var action = () => @this.ToInt16Local();

        // Assert
        action.Should().Throw<OverflowException>();
    }

    [Fact]
    internal void GivenToInt16OrDefaultLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = short.MaxValue;
        short expected = short.MaxValue;

        // Act
        short actual = @this.ToInt16OrDefaultLocal();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToInt16OrDefaultLocalWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        object @this = "foo";
        short expected = short.MaxValue;

        // Act
        short actual = @this.ToInt16OrDefaultLocal(@default: expected);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToInt16OrNullLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = short.MaxValue;
        short expected = short.MaxValue;

        // Act
        short? actual = @this.ToInt16OrNullLocal();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToInt16OrNullLocalWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        object @this = "foo";

        // Act
        short? actual = @this.ToInt16OrNullLocal();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToInt16OrNullLocalWhenInputIsNullThenResultIsNull()
    {
        // Arrange
        object? @this = null;

        // Act
        short? actual = @this.ToInt16OrNullLocal();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenTryConvertToInt16LocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = short.MaxValue;
        short expected = short.MaxValue;

        // Act
        bool isInt16 = @this.TryConvertToInt16Local(out short actual);

        // Assert
        isInt16.Should().BeTrue();
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToInt16LocalWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        object @this = "foo";

        // Act
        bool isInt16 = @this.TryConvertToInt16Local(out short actual);

        // Assert
        isInt16.Should().BeFalse();
        actual.Should().Be(default);
    }
}
