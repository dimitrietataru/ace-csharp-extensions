namespace Ace.CSharp.Extensions.Tests.ObjectExtensions;

public sealed class ToNullableUInt32Tests
{
    [Fact]
    internal void GivenToNullableUInt32WhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object? @this = uint.MaxValue;
        uint expected = uint.MaxValue;

        // Act
        uint? actual = @this.ToNullableUInt32(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToNullableUInt32WhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        object @this = "foo";

        // Act
        uint? actual = @this.ToNullableUInt32(provider: default);

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToNullableUInt32WhenInputOverflownThenResultIsNull()
    {
        // Arrange
        object @this = $"{uint.MaxValue}{uint.MaxValue}";

        // Act
        uint? actual = @this.ToNullableUInt32(provider: default);

        // Assert
        actual.Should().BeNull();
    }
}
