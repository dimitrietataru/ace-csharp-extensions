namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToUInt32LocalTests
{
    [Fact]
    internal void GivenToUInt32LocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = uint.MaxValue.ToString(CultureInfo.CurrentCulture);
        uint expected = uint.MaxValue;

        // Act
        uint actual = @this.ToUInt32Local();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToUInt32LocalWhenInputIsNotValidThenFormatExceptionIsThrown()
    {
        // Arrange
        string @this = "foo";

        // Act
        var action = () => @this.ToUInt32Local();

        // Assert
        action.Should().Throw<FormatException>();
    }

    [Fact]
    internal void GivenToUInt32LocalWhenInputIsNotValidThenOverflowExceptionIsThrown()
    {
        // Arrange
        string @this = $"{uint.MaxValue}{uint.MaxValue}";

        // Act
        var action = () => @this.ToUInt32Local();

        // Assert
        action.Should().Throw<OverflowException>();
    }

    [Fact]
    internal void GivenToUInt32OrDefaultLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = uint.MaxValue.ToString(CultureInfo.CurrentCulture);
        uint expected = uint.MaxValue;

        // Act
        uint actual = @this.ToUInt32OrDefaultLocal();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToUInt32OrDefaultLocalWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        string @this = "foo";
        uint expected = uint.MaxValue;

        // Act
        uint actual = @this.ToUInt32OrDefaultLocal(@default: expected);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToUInt32OrNullLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = uint.MaxValue.ToString(CultureInfo.CurrentCulture);
        uint expected = uint.MaxValue;

        // Act
        uint? actual = @this.ToUInt32OrNullLocal();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToUInt32OrNullLocalWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        string @this = "foo";

        // Act
        uint? actual = @this.ToUInt32OrNullLocal();

        // Assert
        actual.Should().BeNull();
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData(" ")]
    internal void GivenToUInt32OrNullLocalWhenInputIsNullOrWhiteSpaceThenResultIsNull(string @this)
    {
        // Act
        uint? actual = @this.ToUInt32OrNullLocal();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenTryConvertToUInt32LocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = uint.MaxValue.ToString(CultureInfo.CurrentCulture);
        uint expected = uint.MaxValue;

        // Act
        bool isUInt32 = @this.TryConvertToUInt32Local(out uint actual);

        // Assert
        isUInt32.Should().BeTrue();
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToUInt32LocalWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        string @this = "foo";

        // Act
        bool isUInt32 = @this.TryConvertToUInt32Local(out uint actual);

        // Assert
        isUInt32.Should().BeFalse();
        actual.Should().Be(default);
    }
}
