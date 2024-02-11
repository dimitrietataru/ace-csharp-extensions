namespace Ace.CSharp.Extensions.Tests.ObjectExtensions;

public sealed class ToNullableUInt64Tests
{
    [Fact]
    internal void GivenToNullableUInt64WhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object? @this = ulong.MaxValue;
        ulong expected = ulong.MaxValue;

        // Act
        ulong? actual = @this.ToNullableUInt64(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToNullableUInt64WhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        object @this = "foo";

        // Act
        ulong? actual = @this.ToNullableUInt64(provider: default);

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToNullableUInt64WhenInputOverflownThenResultIsNull()
    {
        // Arrange
        object @this = $"{ulong.MaxValue}{ulong.MaxValue}";

        // Act
        ulong? actual = @this.ToNullableUInt64(provider: default);

        // Assert
        actual.Should().BeNull();
    }
}
