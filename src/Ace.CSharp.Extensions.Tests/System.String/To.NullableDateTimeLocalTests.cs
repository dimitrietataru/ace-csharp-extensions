namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToNullableDateTimeLocalTests
{
    [Fact]
    internal void GivenToNullableDateTimeLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = DateTime.UnixEpoch.ToString(CultureInfo.CurrentCulture);
        var expected = DateTime.UnixEpoch;

        // Act
        var actual = @this.ToNullableDateTimeLocal();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToNullableDateTimeLocalWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        string @this = "foo";

        // Act
        var actual = @this.ToNullableDateTimeLocal();

        // Assert
        actual.Should().BeNull();
    }
}
