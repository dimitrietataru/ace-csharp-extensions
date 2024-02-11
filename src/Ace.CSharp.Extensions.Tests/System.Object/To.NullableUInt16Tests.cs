namespace Ace.CSharp.Extensions.Tests.ObjectExtensions;

public sealed class ToNullableUInt16Tests
{
    [Fact]
    internal void GivenToNullableUInt16WhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object? @this = ushort.MaxValue;
        ushort expected = ushort.MaxValue;

        // Act
        ushort? actual = @this.ToNullableUInt16(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToNullableUInt16WhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        object @this = "foo";

        // Act
        ushort? actual = @this.ToNullableUInt16(provider: default);

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToNullableUInt16WhenInputOverflownThenResultIsNull()
    {
        // Arrange
        object @this = $"{ushort.MaxValue}{ushort.MaxValue}";

        // Act
        ushort? actual = @this.ToNullableUInt16(provider: default);

        // Assert
        actual.Should().BeNull();
    }
}
