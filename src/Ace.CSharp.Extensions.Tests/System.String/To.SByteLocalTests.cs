namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToSByteLocalTests
{
    [Fact]
    internal void GivenToSByteLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = sbyte.MaxValue.ToString(CultureInfo.CurrentCulture);
        sbyte expected = sbyte.MaxValue;

        // Act
        sbyte actual = @this.ToSByteLocal();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToSByteLocalWhenInputIsNotValidThenFormatExceptionIsThrown()
    {
        // Arrange
        string @this = "foo";

        // Act
        var action = () => @this.ToSByteLocal();

        // Assert
        action.Should().Throw<FormatException>();
    }

    [Fact]
    internal void GivenToSByteLocalWhenInputIsNotValidThenArgumentNullExceptionIsThrown()
    {
        // Arrange
        string @this = null!;

        // Act
        var action = () => @this.ToSByteLocal();

        // Assert
        action.Should().Throw<ArgumentNullException>();
    }

    [Fact]
    internal void GivenToSByteLocalWhenInputIsNotValidThenOverflowExceptionIsThrown()
    {
        // Arrange
        string @this = $"{sbyte.MaxValue}{sbyte.MaxValue}";

        // Act
        var action = () => @this.ToSByteLocal();

        // Assert
        action.Should().Throw<OverflowException>();
    }

    [Fact]
    internal void GivenToSByteOrDefaultLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = sbyte.MaxValue.ToString(CultureInfo.CurrentCulture);
        sbyte expected = sbyte.MaxValue;

        // Act
        sbyte actual = @this.ToSByteOrDefaultLocal();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToSByteOrDefaultLocalWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        string @this = "foo";
        sbyte expected = sbyte.MaxValue;

        // Act
        sbyte actual = @this.ToSByteOrDefaultLocal(@default: expected);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToSByteLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = sbyte.MaxValue.ToString(CultureInfo.CurrentCulture);
        sbyte expected = sbyte.MaxValue;

        // Act
        bool isSByte = @this.TryConvertToSByteLocal(out sbyte actual);

        // Assert
        isSByte.Should().BeTrue();
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToSByteLocalWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        string @this = "foo";

        // Act
        bool isSByte = @this.TryConvertToSByteLocal(out sbyte actual);

        // Assert
        isSByte.Should().BeFalse();
        actual.Should().Be(default);
    }
}
