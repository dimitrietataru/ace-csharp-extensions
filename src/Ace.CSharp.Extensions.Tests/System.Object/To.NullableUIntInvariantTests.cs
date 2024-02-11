namespace Ace.CSharp.Extensions.Tests.ObjectExtensions;

public sealed class ToNullableUIntInvariantTests
{
    [Fact]
    internal void GivenToNullableUIntInvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object? @this = uint.MaxValue;
        uint expected = uint.MaxValue;

        // Act
        uint? actual = @this.ToNullableUIntInvariant();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToNullableUIntInvariantWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        object @this = "foo";

        // Act
        uint? actual = @this.ToNullableUIntInvariant();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToNullableUIntInvariantWhenInputOverflownThenResultIsNull()
    {
        // Arrange
        object @this = $"{uint.MaxValue}{uint.MaxValue}";

        // Act
        uint? actual = @this.ToNullableUIntInvariant();

        // Assert
        actual.Should().BeNull();
    }
}
