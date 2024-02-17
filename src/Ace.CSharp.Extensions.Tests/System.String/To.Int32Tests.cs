namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToInt32Tests
{
    [Fact]
    internal void GivenToInt32WhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = int.MaxValue.ToString(provider: default);
        int expected = int.MaxValue;

        // Act
        int actual = @this.ToInt32(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToInt32WhenInputIsNotValidThenFormatExceptionIsThrown()
    {
        // Arrange
        string @this = "foo";

        // Act
        var action = () => @this.ToInt32(provider: default);

        // Assert
        action.Should().Throw<FormatException>();
    }

    [Fact]
    internal void GivenToInt32WhenInputIsNotValidThenOverflowExceptionIsThrown()
    {
        // Arrange
        string @this = $"{int.MaxValue}{int.MaxValue}";

        // Act
        var action = () => @this.ToInt32(provider: default);

        // Assert
        action.Should().Throw<OverflowException>();
    }

    [Fact]
    internal void GivenToInt32OrDefaultWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = int.MaxValue.ToString(provider: default);
        int expected = int.MaxValue;

        // Act
        int actual = @this.ToInt32OrDefault(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToInt32OrDefaultWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        string @this = "foo";
        int expected = int.MaxValue;

        // Act
        int actual = @this.ToInt32OrDefault(provider: default, @default: expected);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToInt32OrNullWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = int.MaxValue.ToString(CultureInfo.CurrentCulture);
        int expected = int.MaxValue;

        // Act
        int? actual = @this.ToInt32OrNull(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToInt32OrNullWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        string @this = "foo";

        // Act
        int? actual = @this.ToInt32OrNull(provider: default);

        // Assert
        actual.Should().BeNull();
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData(" ")]
    internal void GivenToInt32OrNullWhenInputIsNullOrWhiteSpaceThenResultIsNull(string @this)
    {
        // Act
        int? actual = @this.ToInt32OrNull(provider: default);

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenTryConvertToInt32WhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = int.MaxValue.ToString(provider: default);
        int expected = int.MaxValue;

        // Act
        bool isInt32 = @this.TryConvertToInt32(provider: default, out int actual);

        // Assert
        isInt32.Should().BeTrue();
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToInt32WhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        string @this = "foo";

        // Act
        bool isInt32 = @this.TryConvertToInt32(provider: default, out int actual);

        // Assert
        isInt32.Should().BeFalse();
        actual.Should().Be(default);
    }
}
