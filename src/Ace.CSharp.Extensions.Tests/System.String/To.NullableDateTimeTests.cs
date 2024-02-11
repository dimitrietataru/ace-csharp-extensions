namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToNullableDateTimeTests
{
    [Fact]
    internal void GivenToNullableDateTimeWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = DateTime.UnixEpoch.ToString(CultureInfo.CurrentCulture);
        var expected = DateTime.UnixEpoch;

        // Act
        var actual = @this.ToNullableDateTime(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToNullableDateTimeWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        string @this = "foo";

        // Act
        var actual = @this.ToNullableDateTime(provider: default);

        // Assert
        actual.Should().BeNull();
    }

    [Theory]
    [InlineData(null, null)]
    [InlineData("", null)]
    [InlineData(" ", null)]
    internal void GivenToNullableDateTimeWhenInputIsNullOrWhiteSpaceThenResultIsExpected(string input, DateTime? expected)
    {
        // Act
        var actual = input.ToNullableDateTime(null);

        // Assert
        actual.Should().Be(expected);
    }
}
