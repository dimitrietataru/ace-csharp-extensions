namespace Ace.CSharp.Extensions.Tests.ObjectExtensions;

public sealed class ToNullableUInt16LocalTests
{
    [Fact]
    internal void GivenToNullableUInt16LocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object? @this = ushort.MaxValue;
        ushort expected = ushort.MaxValue;

        // Act
        ushort? actual = @this.ToNullableUInt16Local();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToNullableUInt16LocalWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        object @this = "foo";

        // Act
        ushort? actual = @this.ToNullableUInt16Local();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToNullableUInt16LocalWhenInputOverflownThenResultIsNull()
    {
        // Arrange
        object @this = $"{ushort.MaxValue}{ushort.MaxValue}";

        // Act
        ushort? actual = @this.ToNullableUInt16Local();

        // Assert
        actual.Should().BeNull();
    }
}
