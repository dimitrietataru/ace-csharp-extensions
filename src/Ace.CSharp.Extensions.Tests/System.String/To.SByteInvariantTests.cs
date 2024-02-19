namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToSByteInvariantTests
{
    [Fact]
    internal void GivenToSByteInvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = sbyte.MaxValue.ToString(CultureInfo.InvariantCulture);
        sbyte expected = sbyte.MaxValue;

        // Act
        sbyte actual = @this.ToSByteInvariant();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToSByteInvariantWhenInputIsNotValidThenFormatExceptionIsThrown()
    {
        // Arrange
        string @this = "foo";

        // Act
        var action = () => @this.ToSByteInvariant();

        // Assert
        action.Should().Throw<FormatException>();
    }

    [Fact]
    internal void GivenToSByteInvariantWhenInputIsNotValidThenArgumentNullExceptionIsThrown()
    {
        // Arrange
        string @this = null!;

        // Act
        var action = () => @this.ToSByteInvariant();

        // Assert
        action.Should().Throw<ArgumentNullException>();
    }

    [Fact]
    internal void GivenToSByteInvariantWhenInputIsNotValidThenOverflowExceptionIsThrown()
    {
        // Arrange
        string @this = $"{sbyte.MaxValue}{sbyte.MaxValue}";

        // Act
        var action = () => @this.ToSByteInvariant();

        // Assert
        action.Should().Throw<OverflowException>();
    }

    [Fact]
    internal void GivenToSByteOrDefaultInvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = sbyte.MaxValue.ToString(CultureInfo.InvariantCulture);
        sbyte expected = sbyte.MaxValue;

        // Act
        sbyte actual = @this.ToSByteOrDefaultInvariant();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToSByteOrDefaultInvariantWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        string @this = "foo";
        sbyte expected = sbyte.MaxValue;

        // Act
        sbyte actual = @this.ToSByteOrDefaultInvariant(@default: expected);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToByteOrNullInvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = sbyte.MaxValue.ToString(CultureInfo.InvariantCulture);
        sbyte expected = sbyte.MaxValue;

        // Act
        sbyte? actual = @this.ToSByteOrNullInvariant();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToByteOrNullInvariantWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        string @this = "foo";

        // Act
        sbyte? actual = @this.ToSByteOrNullInvariant();

        // Assert
        actual.Should().BeNull();
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData(" ")]
    internal void GivenToByteOrNullInvariantWhenInputIsNullOrWhiteSpaceThenResultIsNull(string? @this)
    {
        // Arrange

        // Act
        sbyte? actual = @this.ToSByteOrNullInvariant();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenTryConvertToSByteInvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = sbyte.MaxValue.ToString(CultureInfo.InvariantCulture);
        sbyte expected = sbyte.MaxValue;

        // Act
        bool isSByte = @this.TryConvertToSByteInvariant(out sbyte actual);

        // Assert
        isSByte.Should().BeTrue();
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToSByteInvariantWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        string @this = "foo";

        // Act
        bool isSByte = @this.TryConvertToSByteInvariant(out sbyte actual);

        // Assert
        isSByte.Should().BeFalse();
        actual.Should().Be(default);
    }
}
