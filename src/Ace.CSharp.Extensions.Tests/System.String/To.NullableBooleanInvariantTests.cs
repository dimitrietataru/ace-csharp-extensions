namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToNullableBooleanInvariantTests
{
    [Fact]
    internal void GivenToNullableBooleanInvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = true.ToString(CultureInfo.CurrentCulture);
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
        string @this = "foo";

        // Act
        bool? actual = @this.ToNullableBooleanInvariant();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToNullableBooleanInvariantWhenInputOverflownThenResultIsNull()
    {
        // Arrange
        string @this = $"{true}{true}";

        // Act
        bool? actual = @this.ToNullableBooleanInvariant();

        // Assert
        actual.Should().BeNull();
    }
}
