namespace Ace.CSharp.Extensions.Tests.ObjectExtensions;

public sealed class ToNullableUInt32LocalTests
{
    [Fact]
    internal void GivenToNullableUInt32LocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object? @this = uint.MaxValue;
        uint expected = uint.MaxValue;

        // Act
        uint? actual = @this.ToNullableUInt32Local();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToNullableUInt32LocalWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        object @this = "foo";

        // Act
        uint? actual = @this.ToNullableUInt32Local();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToNullableUInt32LocalWhenInputOverflownThenResultIsNull()
    {
        // Arrange
        object @this = $"{uint.MaxValue}{uint.MaxValue}";

        // Act
        uint? actual = @this.ToNullableUInt32Local();

        // Assert
        actual.Should().BeNull();
    }
}
