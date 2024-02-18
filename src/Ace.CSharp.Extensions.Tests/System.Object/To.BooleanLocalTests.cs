namespace Ace.CSharp.Extensions.Tests.ObjectExtensions;

public sealed class ToBooleanLocalTests
{
    [Fact]
    internal void GivenToBooleanLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = true;
        bool expected = true;

        // Act
        bool actual = @this.ToBooleanLocal();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToBooleanLocalWhenInputIsNotValidThenFormatExceptionIsThrown()
    {
        // Arrange
        object @this = "foo";

        // Act
        var action = () => @this.ToBooleanLocal();

        // Assert
        action.Should().Throw<FormatException>();
    }

    [Fact]
    internal void GivenToBooleanLocalWhenInputIsNotValidThenInvalidCastExceptionIsThrown()
    {
        // Arrange
        object @this = new { Foo = "foo" };

        // Act
        var action = () => @this.ToBooleanLocal();

        // Assert
        action.Should().Throw<InvalidCastException>();
    }

    [Fact]
    internal void GivenToBooleanOrDefaultLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = true;
        bool expected = true;

        // Act
        bool actual = @this.ToBooleanOrDefaultLocal();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToBooleanOrDefaultLocalWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        object @this = "foo";
        bool expected = true;

        // Act
        bool actual = @this.ToBooleanOrDefaultLocal(@default: expected);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToBooleanOrNullLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = true;
        bool expected = true;

        // Act
        bool? actual = @this.ToBooleanOrNullLocal();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToBooleanOrNullLocalWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        object @this = "foo";

        // Act
        bool? actual = @this.ToBooleanOrNullLocal();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToBooleanOrNullLocalWhenInputIsNullThenResultIsNull()
    {
        // Arrange
        object? @this = null;

        // Act
        bool? actual = @this.ToBooleanOrNullLocal();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenTryConvertToBooleanLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = true;
        bool expected = true;

        // Act
        bool isBoolean = @this.TryConvertToBooleanLocal(out bool actual);

        // Assert
        isBoolean.Should().BeTrue();
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToBooleanLocalWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        object @this = "foo";

        // Act
        bool isBoolean = @this.TryConvertToBooleanLocal(out bool actual);

        // Assert
        isBoolean.Should().BeFalse();
        actual.Should().BeFalse();
    }
}
