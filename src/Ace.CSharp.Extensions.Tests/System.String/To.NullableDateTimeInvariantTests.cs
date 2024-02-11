namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToNullableDateTimeInvariantTests
{
    [Fact]
    internal void GivenToNullableDateTimeInvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = DateTime.UnixEpoch.ToString(CultureInfo.CurrentCulture);
        var expected = DateTime.UnixEpoch;

        // Act
        var actual = @this.ToNullableDateTimeInvariant();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToNullableDateTimeInvariantWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        string @this = "foo";

        // Act
        var actual = @this.ToNullableDateTimeInvariant();

        // Assert
        actual.Should().BeNull();
    }
}
