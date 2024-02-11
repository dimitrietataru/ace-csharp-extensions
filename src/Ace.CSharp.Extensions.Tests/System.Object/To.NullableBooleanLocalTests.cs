namespace Ace.CSharp.Extensions.Tests.ObjectExtensions;

public sealed class ToNullableBooleanLocalTests
{
    [Fact]
    internal void GivenToNullableBooleanLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = true;
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
        object @this = "foo";

        // Act
        bool? actual = @this.ToNullableBooleanLocal();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToNullableBooleanLocalWhenInputOverflownThenResultIsNull()
    {
        // Arrange
        object @this = $"{true}{true}";

        // Act
        bool? actual = @this.ToNullableBooleanLocal();

        // Assert
        actual.Should().BeNull();
    }
}
