namespace Ace.CSharp.Extensions.Tests.ObjectExtensions;

public sealed class ToNullableDateTimeLocalTests
{
    [Fact]
    internal void GivenToNullableDateTimeLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = DateTime.UnixEpoch;
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
        object @this = "foo";

        // Act
        var actual = @this.ToNullableDateTimeLocal();

        // Assert
        actual.Should().BeNull();
    }
}
