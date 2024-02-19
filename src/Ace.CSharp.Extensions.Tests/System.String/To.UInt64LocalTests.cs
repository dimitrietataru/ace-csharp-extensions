namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToUInt64LocalTests
{
    [Fact]
    internal void GivenToUInt64LocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = ulong.MaxValue.ToString(CultureInfo.CurrentCulture);
        ulong expected = ulong.MaxValue;

        // Act
        ulong actual = @this.ToUInt64Local();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToUInt64LocalWhenInputIsNotValidThenFormatExceptionIsThrown()
    {
        // Arrange
        string @this = "foo";

        // Act
        var action = () => @this.ToUInt64Local();

        // Assert
        action.Should().Throw<FormatException>();
    }

    [Fact]
    internal void GivenToUInt64LocalWhenInputIsNotValidThenOverflowExceptionIsThrown()
    {
        // Arrange
        string @this = $"{ulong.MaxValue}{ulong.MaxValue}";

        // Act
        var action = () => @this.ToUInt64Local();

        // Assert
        action.Should().Throw<OverflowException>();
    }

    [Fact]
    internal void GivenToUInt64OrDefaultLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = ulong.MaxValue.ToString(CultureInfo.CurrentCulture);
        ulong expected = ulong.MaxValue;

        // Act
        ulong actual = @this.ToUInt64OrDefaultLocal();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToUInt64OrDefaultLocalWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        string @this = "foo";
        ulong expected = ulong.MaxValue;

        // Act
        ulong actual = @this.ToUInt64OrDefaultLocal(@default: expected);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToUInt64OrNullLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = ulong.MaxValue.ToString(CultureInfo.CurrentCulture);
        ulong expected = ulong.MaxValue;

        // Act
        ulong? actual = @this.ToUInt64OrNullLocal();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToUInt64OrNullLocalWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        string @this = "foo";

        // Act
        ulong? actual = @this.ToUInt64OrNullLocal();

        // Assert
        actual.Should().BeNull();
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData(" ")]
    internal void GivenToUInt64OrNullLocalWhenInputIsNullOrWhiteSpaceThenResultIsNull(string? @this)
    {
        // Arrange

        // Act
        ulong? actual = @this.ToUInt64OrNullLocal();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenTryConvertToUInt64LocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = ulong.MaxValue.ToString(CultureInfo.CurrentCulture);
        ulong expected = ulong.MaxValue;

        // Act
        bool isUInt64 = @this.TryConvertToUInt64Local(out ulong actual);

        // Assert
        isUInt64.Should().BeTrue();
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToUInt64LocalWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        string @this = "foo";

        // Act
        bool isUInt64 = @this.TryConvertToUInt64Local(out ulong actual);

        // Assert
        isUInt64.Should().BeFalse();
        actual.Should().Be(default);
    }
}
