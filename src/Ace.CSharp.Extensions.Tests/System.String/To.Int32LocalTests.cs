namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToInt32LocalTests
{
    [Fact]
    internal void GivenToInt32LocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = int.MaxValue.ToString(CultureInfo.CurrentCulture);
        int expected = int.MaxValue;

        // Act
        int actual = @this.ToInt32Local();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToInt32LocalWhenInputIsNotValidThenFormatExceptionIsThrown()
    {
        // Arrange
        string @this = "foo";

        // Act
        var action = () => @this.ToInt32Local();

        // Assert
        action.Should().Throw<FormatException>();
    }

    [Fact]
    internal void GivenToInt32LocalWhenInputIsNotValidThenOverflowExceptionIsThrown()
    {
        // Arrange
        string @this = $"{int.MaxValue}{int.MaxValue}";

        // Act
        var action = () => @this.ToInt32Local();

        // Assert
        action.Should().Throw<OverflowException>();
    }

    [Fact]
    internal void GivenToInt32OrDefaultLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = int.MaxValue.ToString(CultureInfo.CurrentCulture);
        int expected = int.MaxValue;

        // Act
        int actual = @this.ToInt32OrDefaultLocal();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToInt32OrDefaultLocalWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        string @this = "foo";
        int expected = int.MaxValue;

        // Act
        int actual = @this.ToInt32OrDefaultLocal(@default: expected);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToInt32OrNullLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = int.MaxValue.ToString(CultureInfo.CurrentCulture);
        int expected = int.MaxValue;

        // Act
        int? actual = @this.ToInt32OrNullLocal();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToInt32OrNullLocalWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        string @this = "foo";

        // Act
        int? actual = @this.ToInt32OrNullLocal();

        // Assert
        actual.Should().BeNull();
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData(" ")]
    internal void GivenToInt32OrNullLocalWhenInputIsNullOrWhiteSpaceThenResultIsNull(string @this)
    {
        // Act
        int? actual = @this.ToInt32OrNullLocal();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenTryConvertToInt32LocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = int.MaxValue.ToString(CultureInfo.CurrentCulture);
        int expected = int.MaxValue;

        // Act
        bool isInt32 = @this.TryConvertToInt32Local(out int actual);

        // Assert
        isInt32.Should().BeTrue();
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToInt32LocalWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        string @this = "foo";

        // Act
        bool isInt32 = @this.TryConvertToInt32Local(out int actual);

        // Assert
        isInt32.Should().BeFalse();
        actual.Should().Be(default);
    }
}
