namespace Ace.CSharp.Extensions.Tests.ObjectExtensions;

public sealed class ToNullableDateTimeInvariantTests
{
    [Fact]
    internal void GivenToNullableDateTimeInvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = DateTime.UnixEpoch;
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
        object @this = "foo";

        // Act
        var actual = @this.ToNullableDateTimeInvariant();

        // Assert
        actual.Should().BeNull();
    }
}
