namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToNullableBooleanLocalTests
{
    [Fact]
    internal void GivenToNullableBooleanLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = true.ToString(CultureInfo.CurrentCulture);
        bool expected = true;

        // Act
        bool? actual = @this.ToNullableBooleanLocal();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToNullableBooleanLocalWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        string @this = "foo";

        // Act
        bool? actual = @this.ToNullableBooleanLocal();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToNullableBooleanLocalWhenInputOverflownThenResultIsNull()
    {
        // Arrange
        string @this = $"{true}{true}";

        // Act
        bool? actual = @this.ToNullableBooleanLocal();

        // Assert
        actual.Should().BeNull();
    }
}
