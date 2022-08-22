namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToByteInvariantTests
{
    [Fact]
    internal void GivenToByteInvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = ((byte)128).ToString(CultureInfo.InvariantCulture);
        byte expected = 128;

        // Act
        byte actual = @this.ToByteInvariant();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToByteInvariantWhenInputIsNotValidThenFormatExceptionIsThrown()
    {
        // Arrange
        string @this = "foo";

        // Act
        var action = () => @this.ToByteInvariant();

        // Assert
        action.Should().Throw<FormatException>();
    }

    [Fact]
    internal void GivenToByteInvariantWhenInputIsNotValidThenOverflowExceptionIsThrown()
    {
        // Arrange
        string @this = "512";

        // Act
        var action = () => @this.ToByteInvariant();

        // Assert
        action.Should().Throw<OverflowException>();
    }

    [Fact]
    internal void GivenToByteOrDefaultInvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = ((byte)128).ToString(CultureInfo.InvariantCulture);
        byte expected = 128;

        // Act
        byte actual = @this.ToByteOrDefaultInvariant();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToByteOrDefaultInvariantWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        string @this = "foo";
        byte expected = 128;

        // Act
        byte actual = @this.ToByteOrDefaultInvariant(@default: expected);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToByteInvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = ((byte)128).ToString(CultureInfo.InvariantCulture);
        byte expected = 128;

        // Act
        bool isByte = @this.TryConvertToByteInvariant(out byte actual);

        // Assert
        isByte.Should().BeTrue();
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToByteInvariantWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        string @this = "foo";

        // Act
        bool isByte = @this.TryConvertToByteInvariant(out byte actual);

        // Assert
        isByte.Should().BeFalse();
        actual.Should().Be(default);
    }
}
