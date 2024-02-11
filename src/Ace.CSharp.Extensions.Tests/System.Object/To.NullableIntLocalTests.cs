namespace Ace.CSharp.Extensions.Tests.ObjectExtensions;

public sealed class ToNullableIntLocalTests
{
    [Fact]
    internal void GivenToNullableIntLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object? @this = int.MaxValue;
        int expected = int.MaxValue;

        // Act
        int? actual = @this.ToNullableIntLocal();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToNullableIntLocalWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        object @this = "foo";

        // Act
        int? actual = @this.ToNullableIntLocal();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToNullableIntLocalWhenInputOverflownThenResultIsNull()
    {
        // Arrange
        object @this = $"{int.MaxValue}{int.MaxValue}";

        // Act
        int? actual = @this.ToNullableIntLocal();

        // Assert
        actual.Should().BeNull();
    }
}
