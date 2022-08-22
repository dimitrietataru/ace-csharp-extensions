namespace Ace.CSharp.Extensions.Tests.ObjectExtensions;

public sealed class ToBooleanTests
{
    [Fact]
    internal void GivenToBooleanWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = true;
        bool expected = true;

        // Act
        bool actual = @this.ToBoolean(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToBooleanWhenInputIsNotValidThenFormatExceptionIsThrown()
    {
        // Arrange
        object @this = "foo";

        // Act
        var action = () => @this.ToBoolean(provider: default);

        // Assert
        action.Should().Throw<FormatException>();
    }

    [Fact]
    internal void GivenToBooleanWhenInputIsNotValidThenInvalidCastExceptionIsThrown()
    {
        // Arrange
        object @this = new { Foo = "foo" };

        // Act
        var action = () => @this.ToBoolean(provider: default);

        // Assert
        action.Should().Throw<InvalidCastException>();
    }

    [Fact]
    internal void GivenToBooleanOrDefaultWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = true;
        bool expected = true;

        // Act
        bool actual = @this.ToBooleanOrDefault(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToBooleanOrDefaultWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        object @this = "foo";
        bool expected = true;

        // Act
        bool actual = @this.ToBooleanOrDefault(provider: default, @default: expected);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToBooleanWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = true;
        bool expected = true;

        // Act
        bool isBoolean = @this.TryConvertToBoolean(provider: default, out bool actual);

        // Assert
        isBoolean.Should().BeTrue();
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToBooleanWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        object @this = "foo";

        // Act
        bool isBoolean = @this.TryConvertToBoolean(provider: default, out bool actual);

        // Assert
        isBoolean.Should().BeFalse();
        actual.Should().BeFalse();
    }
}
