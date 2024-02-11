namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToNullableUInt16InvariantTests
{
    [Fact]
    internal void GivenToNullableUInt16InvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = ushort.MaxValue.ToString(CultureInfo.CurrentCulture);
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
        string @this = "foo";

        // Act
        ushort? actual = @this.ToNullableUInt16Invariant();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToNullableUInt16InvariantWhenInputOverflownThenResultIsNull()
    {
        // Arrange
        string @this = $"{ushort.MaxValue}{ushort.MaxValue}";

        // Act
        ushort? actual = @this.ToNullableUInt16Invariant();

        // Assert
        actual.Should().BeNull();
    }
}
