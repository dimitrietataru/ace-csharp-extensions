namespace Ace.CSharp.Extensions.Tests.ObjectExtensions;

public sealed class ToNullableInt32LocalTests
{
    [Fact]
    internal void GivenToNullableInt32LocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object? @this = int.MaxValue;
        int expected = int.MaxValue;

        // Act
        int? actual = @this.ToNullableInt32Local();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToNullableInt32LocalWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        object @this = "foo";

        // Act
        int? actual = @this.ToNullableInt32Local();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToNullableInt32LocalWhenInputOverflownThenResultIsNull()
    {
        // Arrange
        object @this = $"{int.MaxValue}{int.MaxValue}";

        // Act
        int? actual = @this.ToNullableInt32Local();

        // Assert
        actual.Should().BeNull();
    }
}
