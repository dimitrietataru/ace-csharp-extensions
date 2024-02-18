namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToByteTests
{
    [Fact]
    internal void GivenToByteWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = byte.MaxValue.ToString(CultureInfo.CurrentCulture);
        byte expected = byte.MaxValue;

        // Act
        byte actual = @this.ToByte(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToByteWhenInputIsNotValidThenFormatExceptionIsThrown()
    {
        // Arrange
        string @this = "foo";

        // Act
        var action = () => @this.ToByte(provider: default);

        // Assert
        action.Should().Throw<FormatException>();
    }

    [Fact]
    internal void GivenToByteWhenInputIsNotValidThenOverflowExceptionIsThrown()
    {
        // Arrange
        string @this = $"{byte.MaxValue}{byte.MaxValue}";

        // Act
        var action = () => @this.ToByte(provider: default);

        // Assert
        action.Should().Throw<OverflowException>();
    }

    [Fact]
    internal void GivenToByteOrDefaultWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = byte.MaxValue.ToString(CultureInfo.CurrentCulture);
        byte expected = byte.MaxValue;

        // Act
        byte actual = @this.ToByteOrDefault(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToByteOrDefaultWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        string @this = "foo";
        byte expected = byte.MaxValue;

        // Act
        byte actual = @this.ToByteOrDefault(provider: default, @default: expected);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToByteOrNullWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = byte.MaxValue.ToString(CultureInfo.CurrentCulture);
        byte expected = byte.MaxValue;

        // Act
        byte? actual = @this.ToByteOrNull(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToByteOrNullWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        string @this = "foo";

        // Act
        byte? actual = @this.ToByteOrNull(provider: default);

        // Assert
        actual.Should().BeNull();
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData(" ")]
    internal void GivenToByteOrNullWhenInputIsNullOrWhiteSpaceThenResultIsNull(string @this)
    {
        // Act
        byte? actual = @this.ToByteOrNull(provider: default);

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenTryConvertToByteWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = byte.MaxValue.ToString(CultureInfo.CurrentCulture);
        byte expected = byte.MaxValue;

        // Act
        bool isByte = @this.TryConvertToByte(provider: default, out byte actual);

        // Assert
        isByte.Should().BeTrue();
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToByteWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        string @this = "foo";

        // Act
        bool isByte = @this.TryConvertToByte(provider: default, out byte actual);

        // Assert
        isByte.Should().BeFalse();
        actual.Should().Be(default);
    }
}
