namespace Ace.CSharp.Extensions.Tests.ObjectExtensions;

public sealed class ToByteLocalTests
{
    [Fact]
    internal void GivenToByteLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = (byte)128;
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
        object @this = "foo";

        // Act
        var action = () => @this.ToByteLocal();

        // Assert
        action.Should().Throw<FormatException>();
    }

    [Fact]
    internal void GivenToByteLocalWhenInputIsNotValidThenOverflowExceptionIsThrown()
    {
        // Arrange
        object @this = "512";

        // Act
        var action = () => @this.ToByteLocal();

        // Assert
        action.Should().Throw<OverflowException>();
    }

    [Fact]
    internal void GivenToByteOrDefaultLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = (byte)128;
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
        object @this = "foo";
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
        object @this = (byte)128;
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
        object @this = "foo";

        // Act
        bool isByte = @this.TryConvertToByteLocal(out byte actual);

        // Assert
        isByte.Should().BeFalse();
        actual.Should().Be(default);
    }
}
