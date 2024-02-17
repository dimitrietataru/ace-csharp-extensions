namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToSByteTests
{
    [Fact]
    internal void GivenToSByteWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = sbyte.MaxValue.ToString(provider: default);
        sbyte expected = sbyte.MaxValue;

        // Act
        sbyte actual = @this.ToSByte(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToSByteWhenInputIsNotValidThenFormatExceptionIsThrown()
    {
        // Arrange
        string @this = "foo";

        // Act
        var action = () => @this.ToSByte(provider: default);

        // Assert
        action.Should().Throw<FormatException>();
    }

    [Fact]
    internal void GivenToSByteWhenInputIsNotValidThenArgumentNullExceptionIsThrown()
    {
        // Arrange
        string @this = null!;

        // Act
        var action = () => @this.ToSByte(provider: default);

        // Assert
        action.Should().Throw<ArgumentNullException>();
    }

    [Fact]
    internal void GivenToSByteWhenInputIsNotValidThenOverflowExceptionIsThrown()
    {
        // Arrange
        string @this = $"{sbyte.MaxValue}{sbyte.MaxValue}";

        // Act
        var action = () => @this.ToSByte(provider: default);

        // Assert
        action.Should().Throw<OverflowException>();
    }

    [Fact]
    internal void GivenToSByteOrDefaultWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = sbyte.MaxValue.ToString(provider: default);
        sbyte expected = sbyte.MaxValue;

        // Act
        sbyte actual = @this.ToSByteOrDefault(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToSByteOrDefaultWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        string @this = "foo";
        sbyte expected = sbyte.MaxValue;

        // Act
        sbyte actual = @this.ToSByteOrDefault(provider: default, @default: expected);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToSByteOrNullWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = sbyte.MaxValue.ToString(CultureInfo.CurrentCulture);
        sbyte expected = sbyte.MaxValue;

        // Act
        sbyte? actual = @this.ToSByteOrNull(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToSByteOrNullWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        string @this = "foo";

        // Act
        sbyte? actual = @this.ToSByteOrNull(provider: default);

        // Assert
        actual.Should().BeNull();
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData(" ")]
    internal void GivenToSByteOrNullWhenInputIsNullOrWhiteSpaceThenResultIsNull(string @this)
    {
        // Act
        sbyte? actual = @this.ToSByteOrNull(provider: default);

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenTryConvertToSByteWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = sbyte.MaxValue.ToString(provider: default);
        sbyte expected = sbyte.MaxValue;

        // Act
        bool isSByte = @this.TryConvertToSByte(provider: default, out sbyte actual);

        // Assert
        isSByte.Should().BeTrue();
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToSByteWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        string @this = "foo";

        // Act
        bool isSByte = @this.TryConvertToSByte(provider: default, out sbyte actual);

        // Assert
        isSByte.Should().BeFalse();
        actual.Should().Be(default);
    }
}
