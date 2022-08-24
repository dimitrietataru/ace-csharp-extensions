namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToUInt16InvariantTests
{
    [Fact]
    internal void GivenToUInt16InvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = ((ushort)1024).ToString(CultureInfo.InvariantCulture);
        ushort expected = 1024;

        // Act
        ushort actual = @this.ToUInt16Invariant();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToUInt16InvariantWhenInputIsNotValidThenFormatExceptionIsThrown()
    {
        // Arrange
        string @this = "foo";

        // Act
        var action = () => @this.ToUInt16Invariant();

        // Assert
        action.Should().Throw<FormatException>();
    }

    [Fact]
    internal void GivenToUInt16InvariantWhenInputIsNotValidThenOverflowExceptionIsThrown()
    {
        // Arrange
        string @this = $"{ushort.MaxValue}{ushort.MaxValue}";

        // Act
        var action = () => @this.ToUInt16Invariant();

        // Assert
        action.Should().Throw<OverflowException>();
    }

    [Fact]
    internal void GivenToUInt16OrDefaultInvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = ((ushort)1024).ToString(CultureInfo.InvariantCulture);
        ushort expected = 1024;

        // Act
        ushort actual = @this.ToUInt16OrDefaultInvariant();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToUInt16OrDefaultInvariantWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        string @this = "foo";
        ushort expected = 1024;

        // Act
        ushort actual = @this.ToUInt16OrDefaultInvariant(@default: expected);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToUInt16InvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = ((ushort)1024).ToString(CultureInfo.InvariantCulture);
        ushort expected = 1024;

        // Act
        bool isUInt16 = @this.TryConvertToUInt16Invariant(out ushort actual);

        // Assert
        isUInt16.Should().BeTrue();
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToUInt16InvariantWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        string @this = "foo";

        // Act
        bool isUInt16 = @this.TryConvertToUInt16Invariant(out ushort actual);

        // Assert
        isUInt16.Should().BeFalse();
        actual.Should().Be(default);
    }
}
