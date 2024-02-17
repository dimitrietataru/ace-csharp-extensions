namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToInt16InvariantTests
{
    [Fact]
    internal void GivenToInt16InvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = short.MaxValue.ToString(CultureInfo.InvariantCulture);
        short expected = short.MaxValue;

        // Act
        short actual = @this.ToInt16Invariant();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToInt16InvariantWhenInputIsNotValidThenFormatExceptionIsThrown()
    {
        // Arrange
        string @this = "foo";

        // Act
        var action = () => @this.ToInt16Invariant();

        // Assert
        action.Should().Throw<FormatException>();
    }

    [Fact]
    internal void GivenToInt16InvariantWhenInputIsNotValidThenOverflowExceptionIsThrown()
    {
        // Arrange
        string @this = $"{short.MaxValue}{short.MaxValue}";

        // Act
        var action = () => @this.ToInt16Invariant();

        // Assert
        action.Should().Throw<OverflowException>();
    }

    [Fact]
    internal void GivenToInt16OrDefaultInvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = short.MaxValue.ToString(CultureInfo.InvariantCulture);
        short expected = short.MaxValue;

        // Act
        short actual = @this.ToInt16OrDefaultInvariant();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToInt16OrDefaultInvariantWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        string @this = "foo";
        short expected = short.MaxValue;

        // Act
        short actual = @this.ToInt16OrDefaultInvariant(@default: expected);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToInt16OrNullInvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = int.MaxValue.ToString(CultureInfo.InvariantCulture);
        int expected = int.MaxValue;

        // Act
        int? actual = @this.ToInt16OrNullInvariant();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToInt16OrNullInvariantWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        string @this = "foo";

        // Act
        int? actual = @this.ToInt16OrNullInvariant();

        // Assert
        actual.Should().BeNull();
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData(" ")]
    internal void GivenToInt16OrNullInvariantWhenInputIsNullOrWhiteSpaceThenResultIsNull(string @this)
    {
        // Act
        int? actual = @this.ToInt16OrNullInvariant();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenTryConvertToInt16InvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = short.MaxValue.ToString(CultureInfo.InvariantCulture);
        short expected = short.MaxValue;

        // Act
        bool isInt16 = @this.TryConvertToInt16Invariant(out short actual);

        // Assert
        isInt16.Should().BeTrue();
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToInt16InvariantWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        string @this = "foo";

        // Act
        bool isInt16 = @this.TryConvertToInt16Invariant(out short actual);

        // Assert
        isInt16.Should().BeFalse();
        actual.Should().Be(default);
    }
}
