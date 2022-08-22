namespace Ace.CSharp.Extensions.Tests.ObjectExtensions;

public sealed class ToByteInvariantTests
{
    [Fact]
    internal void GivenToByteInvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = (byte)128;
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
        object @this = "foo";

        // Act
        var action = () => @this.ToByteInvariant();

        // Assert
        action.Should().Throw<FormatException>();
    }

    [Fact]
    internal void GivenToByteInvariantWhenInputIsNotValidThenOverflowExceptionIsThrown()
    {
        // Arrange
        object @this = "512";

        // Act
        var action = () => @this.ToByteInvariant();

        // Assert
        action.Should().Throw<OverflowException>();
    }

    [Fact]
    internal void GivenToByteOrDefaultInvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = (byte)128;
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
        object @this = "foo";
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
        object @this = (byte)128;
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
        object @this = "foo";

        // Act
        bool isByte = @this.TryConvertToByteInvariant(out byte actual);

        // Assert
        isByte.Should().BeFalse();
        actual.Should().Be(default);
    }
}
