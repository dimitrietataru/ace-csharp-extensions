namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToBooleanLocalTests
{
    [Fact]
    internal void GivenToBooleanLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = true.ToString(CultureInfo.CurrentCulture);
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
        string @this = "foo";

        // Act
        var action = () => @this.ToBooleanLocal();

        // Assert
        action.Should().Throw<FormatException>();
    }

    [Fact]
    internal void GivenToBooleanOrDefaultLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = true.ToString(CultureInfo.CurrentCulture);
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
        string @this = "foo";
        bool expected = true;

        // Act
        bool actual = @this.ToBooleanOrDefaultLocal(@default: expected);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToBooleanLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = true.ToString(CultureInfo.CurrentCulture);
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
        string @this = "foo";

        // Act
        bool isBoolean = @this.TryConvertToBooleanLocal(out bool actual);

        // Assert
        isBoolean.Should().BeFalse();
        actual.Should().BeFalse();
    }
}
