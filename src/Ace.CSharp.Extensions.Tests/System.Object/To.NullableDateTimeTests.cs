namespace Ace.CSharp.Extensions.Tests.ObjectExtensions;

public sealed class ToNullableDateTimeTests
{
    [Fact]
    internal void GivenToNullableDateTimeWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = DateTime.UnixEpoch;
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
        object @this = "foo";

        // Act
        var actual = @this.ToNullableDateTime(provider: default);

        // Assert
        actual.Should().BeNull();
    }
}
