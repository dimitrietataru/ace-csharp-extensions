namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToDateTimeTests
{
    [Fact]
    internal void GivenToDateTimeWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = DateTime.UnixEpoch.ToString(CultureInfo.CurrentCulture);
        var expected = DateTime.UnixEpoch;

        // Act
        var actual = @this.ToDateTime(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToDateTimeWhenInputIsNotValidThenFormatExceptionIsThrown()
    {
        // Arrange
        string @this = "foo";

        // Act
        var action = () => @this.ToDateTime(provider: default);

        // Assert
        action.Should().Throw<FormatException>();
    }

    [Fact]
    internal void GivenToDateTimeOrDefaultWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = DateTime.UnixEpoch.ToString(CultureInfo.CurrentCulture);
        var expected = DateTime.UnixEpoch;

        // Act
        var actual = @this.ToDateTimeOrDefault(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToDateTimeOrDefaultWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        string @this = "foo";
        var expected = DateTime.UnixEpoch;

        // Act
        var actual = @this.ToDateTimeOrDefault(provider: default, @default: expected);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToDateTimeOrNullWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = DateTime.UnixEpoch.ToString(CultureInfo.CurrentCulture);
        DateTime expected = DateTime.UnixEpoch;

        // Act
        DateTime? actual = @this.ToDateTimeOrNull(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToDateTimeOrNullWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        string @this = "foo";

        // Act
        DateTime? actual = @this.ToDateTimeOrNull(provider: default);

        // Assert
        actual.Should().BeNull();
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData(" ")]
    internal void GivenToDateTimeOrNullWhenInputIsNullOrWhiteSpaceThenResultIsNull(string @this)
    {
        // Act
        DateTime? actual = @this.ToDateTimeOrNull(provider: default);

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenTryConvertToDateTimeWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = DateTime.UnixEpoch.ToString(CultureInfo.CurrentCulture);
        var expected = DateTime.UnixEpoch;

        // Act
        bool isDateTime = @this.TryConvertToDateTime(provider: default, out var actual);

        // Assert
        isDateTime.Should().BeTrue();
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToDateTimeWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        string @this = "foo";

        // Act
        bool isDateTime = @this.TryConvertToDateTime(provider: default, out var actual);

        // Assert
        isDateTime.Should().BeFalse();
        actual.Should().Be(default);
    }
}
