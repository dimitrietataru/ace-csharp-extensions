namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToByteTests
{
    [Fact]
    internal void GivenToByteWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = ((byte)128).ToString(CultureInfo.InvariantCulture);
        byte expected = 128;

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
        string @this = "512";

        // Act
        var action = () => @this.ToByte(provider: default);

        // Assert
        action.Should().Throw<OverflowException>();
    }

    [Fact]
    internal void GivenToByteOrDefaultWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = ((byte)128).ToString(CultureInfo.InvariantCulture);
        byte expected = 128;

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
        byte expected = 128;

        // Act
        byte actual = @this.ToByteOrDefault(provider: default, @default: expected);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToByteWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = ((byte)128).ToString(CultureInfo.InvariantCulture);
        byte expected = 128;

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
