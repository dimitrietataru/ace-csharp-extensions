namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToDateTimeInvariantTests
{
    [Fact]
    internal void GivenToDateTimeInvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = DateTime.UnixEpoch.ToString(CultureInfo.InvariantCulture);
        var expected = DateTime.UnixEpoch;

        // Act
        var actual = @this.ToDateTimeInvariant();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToDateTimeInvariantWhenInputIsNotValidThenFormatExceptionIsThrown()
    {
        // Arrange
        string @this = "foo";

        // Act
        var action = () => @this.ToDateTimeInvariant();

        // Assert
        action.Should().Throw<FormatException>();
    }

    [Fact]
    internal void GivenToDateTimeOrDefaultInvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = DateTime.UnixEpoch.ToString(CultureInfo.InvariantCulture);
        var expected = DateTime.UnixEpoch;

        // Act
        var actual = @this.ToDateTimeOrDefaultInvariant();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToDateTimeOrDefaultInvariantWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        string @this = "foo";
        var expected = DateTime.UnixEpoch;

        // Act
        var actual = @this.ToDateTimeOrDefaultInvariant(@default: expected);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToDateTimeOrNullInvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = DateTime.UnixEpoch.ToString(CultureInfo.InvariantCulture);
        DateTime expected = DateTime.UnixEpoch;

        // Act
        DateTime? actual = @this.ToDateTimeOrNullInvariant();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToDateTimeOrNullInvariantWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        string @this = "foo";

        // Act
        DateTime? actual = @this.ToDateTimeOrNullInvariant();

        // Assert
        actual.Should().BeNull();
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData(" ")]
    internal void GivenToDateTimeOrNullInvariantWhenInputIsNullOrWhiteSpaceThenResultIsNull(string @this)
    {
        // Act
        DateTime? actual = @this.ToDateTimeOrNullInvariant();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenTryConvertToDateTimeInvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = DateTime.UnixEpoch.ToString(CultureInfo.InvariantCulture);
        var expected = DateTime.UnixEpoch;

        // Act
        bool isDateTime = @this.TryConvertToDateTimeInvariant(out var actual);

        // Assert
        isDateTime.Should().BeTrue();
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToDateTimeInvariantWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        string @this = "foo";

        // Act
        bool isDateTime = @this.TryConvertToDateTimeInvariant(out var actual);

        // Assert
        isDateTime.Should().BeFalse();
        actual.Should().Be(default);
    }
}
