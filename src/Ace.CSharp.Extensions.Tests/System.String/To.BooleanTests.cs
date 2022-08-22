namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToBooleanTests
{
    [Fact]
    internal void GivenToBooleanWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = true.ToString();
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
        string @this = "foo";

        // Act
        var action = () => @this.ToBoolean(provider: default);

        // Assert
        action.Should().Throw<FormatException>();
    }

    [Fact]
    internal void GivenToBooleanOrDefaultWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = true.ToString();
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
        string @this = "foo";
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
        string @this = true.ToString();
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
        string @this = "foo";

        // Act
        bool isBoolean = @this.TryConvertToBoolean(provider: default, out bool actual);

        // Assert
        isBoolean.Should().BeFalse();
        actual.Should().BeFalse();
    }
}
