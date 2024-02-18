namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToDateTimeLocalTests
{
    [Fact]
    internal void GivenToDateTimeLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = DateTime.UnixEpoch.ToString(CultureInfo.CurrentCulture);
        var expected = DateTime.UnixEpoch;

        // Act
        var actual = @this.ToDateTimeLocal();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToDateTimeLocalWhenInputIsNotValidThenFormatExceptionIsThrown()
    {
        // Arrange
        string @this = "foo";

        // Act
        var action = () => @this.ToDateTimeLocal();

        // Assert
        action.Should().Throw<FormatException>();
    }

    [Fact]
    internal void GivenToDateTimeOrDefaultLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = DateTime.UnixEpoch.ToString(CultureInfo.CurrentCulture);
        var expected = DateTime.UnixEpoch;

        // Act
        var actual = @this.ToDateTimeOrDefaultLocal();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToDateTimeOrDefaultLocalWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        string @this = "foo";
        var expected = DateTime.UnixEpoch;

        // Act
        var actual = @this.ToDateTimeOrDefaultLocal(@default: expected);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToDateTimeOrNullLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = DateTime.UnixEpoch.ToString(CultureInfo.CurrentCulture);
        DateTime expected = DateTime.UnixEpoch;

        // Act
        DateTime? actual = @this.ToDateTimeOrNullLocal();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToDateTimeOrNullLocalWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        string @this = "foo";

        // Act
        DateTime? actual = @this.ToDateTimeOrNullLocal();

        // Assert
        actual.Should().BeNull();
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData(" ")]
    internal void GivenToDateTimeOrNullLocalWhenInputIsNullOrWhiteSpaceThenResultIsNull(string @this)
    {
        // Act
        DateTime? actual = @this.ToDateTimeOrNullLocal();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenTryConvertToDateTimeLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = DateTime.UnixEpoch.ToString(CultureInfo.CurrentCulture);
        var expected = DateTime.UnixEpoch;

        // Act
        bool isDateTime = @this.TryConvertToDateTimeLocal(out var actual);

        // Assert
        isDateTime.Should().BeTrue();
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToDateTimeLocalWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        string @this = "foo";

        // Act
        bool isDateTime = @this.TryConvertToDateTimeLocal(out var actual);

        // Assert
        isDateTime.Should().BeFalse();
        actual.Should().Be(default);
    }
}
