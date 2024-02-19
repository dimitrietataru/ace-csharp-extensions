namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToInt16Tests
{
    [Fact]
    internal void GivenToInt16WhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = short.MaxValue.ToString(provider: default);
        short expected = short.MaxValue;

        // Act
        short actual = @this.ToInt16(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToInt16WhenInputIsNotValidThenFormatExceptionIsThrown()
    {
        // Arrange
        string @this = "foo";

        // Act
        var action = () => @this.ToInt16(provider: default);

        // Assert
        action.Should().Throw<FormatException>();
    }

    [Fact]
    internal void GivenToInt16WhenInputIsNotValidThenOverflowExceptionIsThrown()
    {
        // Arrange
        string @this = $"{short.MaxValue}{short.MaxValue}";

        // Act
        var action = () => @this.ToInt16(provider: default);

        // Assert
        action.Should().Throw<OverflowException>();
    }

    [Fact]
    internal void GivenToInt16OrDefaultWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = short.MaxValue.ToString(provider: default);
        short expected = short.MaxValue;

        // Act
        short actual = @this.ToInt16OrDefault(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToInt16OrDefaultWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        string @this = "foo";
        short expected = short.MaxValue;

        // Act
        short actual = @this.ToInt16OrDefault(provider: default, @default: expected);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToInt16OrNullWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = short.MaxValue.ToString(provider: default);
        short expected = short.MaxValue;

        // Act
        short? actual = @this.ToInt16OrNull(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToInt16OrNullWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        string @this = "foo";

        // Act
        short? actual = @this.ToInt16OrNull(provider: default);

        // Assert
        actual.Should().BeNull();
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData(" ")]
    internal void GivenToInt16OrNullWhenInputIsNullOrWhiteSpaceThenResultIsNull(string? @this)
    {
        // Arrange

        // Act
        short? actual = @this.ToInt16OrNull(provider: default);

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenTryConvertToInt16WhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = short.MaxValue.ToString(provider: default);
        short expected = short.MaxValue;

        // Act
        bool isInt16 = @this.TryConvertToInt16(provider: default, out short actual);

        // Assert
        isInt16.Should().BeTrue();
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToInt16WhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        string @this = "foo";

        // Act
        bool isInt16 = @this.TryConvertToInt16(provider: default, out short actual);

        // Assert
        isInt16.Should().BeFalse();
        actual.Should().Be(default);
    }
}
