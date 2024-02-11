namespace Ace.CSharp.Extensions.Tests.ObjectExtensions;

public sealed class ToNullableInt16Tests
{
    [Fact]
    internal void GivenToNullableInt16WhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object? @this = short.MaxValue;
        short expected = short.MaxValue;

        // Act
        short? actual = @this.ToNullableInt16(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToNullableInt16WhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        object @this = "foo";

        // Act
        short? actual = @this.ToNullableInt16(provider: default);

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToNullableInt16WhenInputOverflownThenResultIsNull()
    {
        // Arrange
        object @this = $"{short.MaxValue}{short.MaxValue}";

        // Act
        short? actual = @this.ToNullableInt16(provider: default);

        // Assert
        actual.Should().BeNull();
    }
}
