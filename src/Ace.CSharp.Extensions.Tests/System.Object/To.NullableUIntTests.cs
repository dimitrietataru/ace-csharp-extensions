namespace Ace.CSharp.Extensions.Tests.ObjectExtensions;

public sealed class ToNullableUIntTests
{
    [Fact]
    internal void GivenToNullableUIntWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object? @this = uint.MaxValue;
        uint expected = uint.MaxValue;

        // Act
        uint? actual = @this.ToNullableUInt(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToNullableUIntWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        object @this = "foo";

        // Act
        uint? actual = @this.ToNullableUInt(provider: default);

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToNullableUIntWhenInputOverflownThenResultIsNull()
    {
        // Arrange
        object @this = $"{uint.MaxValue}{uint.MaxValue}";

        // Act
        uint? actual = @this.ToNullableUInt(provider: default);

        // Assert
        actual.Should().BeNull();
    }
}
