namespace Ace.CSharp.Extensions.Tests.ObjectExtensions;

public sealed class ToNullableUInt64LocalTests
{
    [Fact]
    internal void GivenToNullableUInt64LocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object? @this = ulong.MaxValue;
        ulong expected = ulong.MaxValue;

        // Act
        ulong? actual = @this.ToNullableUInt64Local();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToNullableUInt64LocalWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        object @this = "foo";

        // Act
        ulong? actual = @this.ToNullableUInt64Local();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToNullableUInt64LocalWhenInputOverflownThenResultIsNull()
    {
        // Arrange
        object @this = $"{ulong.MaxValue}{ulong.MaxValue}";

        // Act
        ulong? actual = @this.ToNullableUInt64Local();

        // Assert
        actual.Should().BeNull();
    }
}
