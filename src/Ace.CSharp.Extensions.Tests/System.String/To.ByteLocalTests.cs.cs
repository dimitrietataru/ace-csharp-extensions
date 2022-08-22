namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToByteLocalTests
{
    [Fact]
    internal void GivenToByteLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = ((byte)128).ToString(CultureInfo.CurrentCulture);
        byte expected = 128;

        // Act
        byte actual = @this.ToByteLocal();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToByteLocalWhenInputIsNotValidThenFormatExceptionIsThrown()
    {
        // Arrange
        string @this = "foo";

        // Act
        var action = () => @this.ToByteLocal();

        // Assert
        action.Should().Throw<FormatException>();
    }

    [Fact]
    internal void GivenToByteLocalWhenInputIsNotValidThenOverflowExceptionIsThrown()
    {
        // Arrange
        string @this = "512";

        // Act
        var action = () => @this.ToByteLocal();

        // Assert
        action.Should().Throw<OverflowException>();
    }

    [Fact]
    internal void GivenToByteOrDefaultLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = ((byte)128).ToString(CultureInfo.CurrentCulture);
        byte expected = 128;

        // Act
        byte actual = @this.ToByteOrDefaultLocal();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToByteOrDefaultLocalWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        string @this = "foo";
        byte expected = 128;

        // Act
        byte actual = @this.ToByteOrDefaultLocal(@default: expected);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToByteLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = ((byte)128).ToString(CultureInfo.CurrentCulture);
        byte expected = 128;

        // Act
        bool isByte = @this.TryConvertToByteLocal(out byte actual);

        // Assert
        isByte.Should().BeTrue();
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToByteLocalWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        string @this = "foo";

        // Act
        bool isByte = @this.TryConvertToByteLocal(out byte actual);

        // Assert
        isByte.Should().BeFalse();
        actual.Should().Be(default);
    }
}
