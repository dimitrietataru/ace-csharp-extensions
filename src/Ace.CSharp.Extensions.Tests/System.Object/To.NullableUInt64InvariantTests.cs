namespace Ace.CSharp.Extensions.Tests.ObjectExtensions;

public sealed class ToNullableUInt64InvariantTests
{
    [Fact]
    internal void GivenToNullableUInt64InvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object? @this = ulong.MaxValue;
        ulong expected = ulong.MaxValue;

        // Act
        ulong? actual = @this.ToNullableUInt64Invariant();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToNullableUInt64InvariantWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        object @this = "foo";

        // Act
        ulong? actual = @this.ToNullableUInt64Invariant();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToNullableUInt64InvariantWhenInputOverflownThenResultIsNull()
    {
        // Arrange
        object @this = $"{ulong.MaxValue}{ulong.MaxValue}";

        // Act
        ulong? actual = @this.ToNullableUInt64Invariant();

        // Assert
        actual.Should().BeNull();
    }
}
