namespace Ace.CSharp.Extensions.Tests.ObjectExtensions;

public sealed class ToNullableBooleanInvariantTests
{
    [Fact]
    internal void GivenToNullableBooleanInvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = true;
        bool expected = true;

        // Act
        bool? actual = @this.ToNullableBooleanInvariant();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToNullableBooleanInvariantWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        object @this = "foo";

        // Act
        bool? actual = @this.ToNullableBooleanInvariant();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToNullableBooleanInvariantWhenInputOverflownThenResultIsNull()
    {
        // Arrange
        object @this = $"{true}{true}";

        // Act
        bool? actual = @this.ToNullableBooleanInvariant();

        // Assert
        actual.Should().BeNull();
    }
}
