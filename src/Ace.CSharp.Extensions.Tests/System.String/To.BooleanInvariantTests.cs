namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToBooleanInvariantTests
{
    [Fact]
    internal void GivenToBooleanInvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = true.ToString(CultureInfo.InvariantCulture);
        bool expected = true;

        // Act
        bool actual = @this.ToBooleanInvariant();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToBooleanInvariantWhenInputIsNotValidThenFormatExceptionIsThrown()
    {
        // Arrange
        string @this = "foo";

        // Act
        var action = () => @this.ToBooleanInvariant();

        // Assert
        action.Should().Throw<FormatException>();
    }

    [Fact]
    internal void GivenToBooleanOrDefaultInvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = true.ToString(CultureInfo.InvariantCulture);
        bool expected = true;

        // Act
        bool actual = @this.ToBooleanOrDefaultInvariant();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToBooleanOrDefaultInvariantWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        string @this = "foo";
        bool expected = true;

        // Act
        bool actual = @this.ToBooleanOrDefaultInvariant(@default: expected);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToBooleanInvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = true.ToString(CultureInfo.InvariantCulture);
        bool expected = true;

        // Act
        bool isBoolean = @this.TryConvertToBooleanInvariant(out bool actual);

        // Assert
        isBoolean.Should().BeTrue();
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToBooleanInvariantWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        string @this = "foo";

        // Act
        bool isBoolean = @this.TryConvertToBooleanInvariant(out bool actual);

        // Assert
        isBoolean.Should().BeFalse();
        actual.Should().BeFalse();
    }
}
