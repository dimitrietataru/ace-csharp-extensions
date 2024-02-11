namespace Ace.CSharp.Extensions.Tests.ObjectExtensions;

public sealed class ToNullableInt32Tests
{
    [Fact]
    internal void GivenToNullableInt32WhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object? @this = int.MaxValue;
        int expected = int.MaxValue;

        // Act
        int? actual = @this.ToNullableInt32(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToNullableInt32WhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        object @this = "foo";

        // Act
        int? actual = @this.ToNullableInt32(provider: default);

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToNullableInt32WhenInputOverflownThenResultIsNull()
    {
        // Arrange
        object @this = $"{int.MaxValue}{int.MaxValue}";

        // Act
        int? actual = @this.ToNullableInt32(provider: default);

        // Assert
        actual.Should().BeNull();
    }
}
