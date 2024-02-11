namespace Ace.CSharp.Extensions.Tests.ObjectExtensions;

public sealed class ToNullableIntTests
{
    [Fact]
    internal void GivenToNullableIntWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object? @this = int.MaxValue;
        int expected = int.MaxValue;

        // Act
        int? actual = @this.ToNullableInt(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToNullableIntWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        object @this = "foo";

        // Act
        int? actual = @this.ToNullableInt(provider: default);

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToNullableIntWhenInputOverflownThenResultIsNull()
    {
        // Arrange
        object @this = $"{int.MaxValue}{int.MaxValue}";

        // Act
        int? actual = @this.ToNullableInt(provider: default);

        // Assert
        actual.Should().BeNull();
    }
}
