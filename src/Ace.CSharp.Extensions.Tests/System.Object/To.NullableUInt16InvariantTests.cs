namespace Ace.CSharp.Extensions.Tests.ObjectExtensions;

public sealed class ToNullableUInt16InvariantTests
{
    [Fact]
    internal void GivenToNullableUInt16InvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object? @this = ushort.MaxValue;
        ushort expected = ushort.MaxValue;

        // Act
        ushort? actual = @this.ToNullableUInt16Invariant();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToNullableUInt16InvariantWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        object @this = "foo";

        // Act
        ushort? actual = @this.ToNullableUInt16Invariant();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToNullableUInt16InvariantWhenInputOverflownThenResultIsNull()
    {
        // Arrange
        object @this = $"{ushort.MaxValue}{ushort.MaxValue}";

        // Act
        ushort? actual = @this.ToNullableUInt16Invariant();

        // Assert
        actual.Should().BeNull();
    }
}
