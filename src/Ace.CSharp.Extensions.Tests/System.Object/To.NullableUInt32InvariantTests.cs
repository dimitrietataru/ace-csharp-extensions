namespace Ace.CSharp.Extensions.Tests.ObjectExtensions;

public sealed class ToNullableUInt32InvariantTests
{
    [Fact]
    internal void GivenToNullableUInt32InvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object? @this = uint.MaxValue;
        uint expected = uint.MaxValue;

        // Act
        uint? actual = @this.ToNullableUInt32Invariant();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToNullableUInt32InvariantWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        object @this = "foo";

        // Act
        uint? actual = @this.ToNullableUInt32Invariant();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToNullableUInt32InvariantWhenInputOverflownThenResultIsNull()
    {
        // Arrange
        object @this = $"{uint.MaxValue}{uint.MaxValue}";

        // Act
        uint? actual = @this.ToNullableUInt32Invariant();

        // Assert
        actual.Should().BeNull();
    }
}
