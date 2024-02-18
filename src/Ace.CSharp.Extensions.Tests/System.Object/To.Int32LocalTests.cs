namespace Ace.CSharp.Extensions.Tests.ObjectExtensions;

public sealed class ToInt32LocalTests
{
    [Fact]
    internal void GivenToInt32LocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = int.MaxValue;
        int expected = int.MaxValue;

        // Act
        int actual = @this.ToInt32Local();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToInt32LocalWhenInputIsNotValidThenFormatExceptionIsThrown()
    {
        // Arrange
        object @this = "foo";

        // Act
        var action = () => @this.ToInt32Local();

        // Assert
        action.Should().Throw<FormatException>();
    }

    [Fact]
    internal void GivenToInt32LocalWhenInputIsNotValidThenOverflowExceptionIsThrown()
    {
        // Arrange
        object @this = $"{int.MaxValue}{int.MaxValue}";

        // Act
        var action = () => @this.ToInt32Local();

        // Assert
        action.Should().Throw<OverflowException>();
    }

    [Fact]
    internal void GivenToInt32OrDefaultLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = int.MaxValue;
        int expected = int.MaxValue;

        // Act
        int actual = @this.ToInt32OrDefaultLocal();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToInt32OrDefaultLocalWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        object @this = "foo";
        int expected = int.MaxValue;

        // Act
        int actual = @this.ToInt32OrDefaultLocal(@default: expected);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToInt32OrNullLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = int.MaxValue;
        int expected = int.MaxValue;

        // Act
        int? actual = @this.ToInt32OrNullLocal();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToInt32OrNullLocalWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        object @this = "foo";

        // Act
        int? actual = @this.ToInt32OrNullLocal();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToInt32OrNullLocalWhenInputIsNullThenResultIsNull()
    {
        // Arrange
        object? @this = null;

        // Act
        int? actual = @this.ToInt32OrNullLocal();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenTryConvertToInt32LocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = int.MaxValue;
        int expected = int.MaxValue;

        // Act
        bool isInt32 = @this.TryConvertToInt32Local(out int actual);

        // Assert
        isInt32.Should().BeTrue();
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToInt32LocalWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        object @this = "foo";

        // Act
        bool isInt32 = @this.TryConvertToInt32Local(out int actual);

        // Assert
        isInt32.Should().BeFalse();
        actual.Should().Be(default);
    }
}
