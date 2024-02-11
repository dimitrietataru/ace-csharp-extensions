namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToNullableUInt16LocalTests
{
    [Fact]
    internal void GivenToNullableUInt16LocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = ushort.MaxValue.ToString(CultureInfo.CurrentCulture);
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
        string @this = "foo";

        // Act
        ushort? actual = @this.ToNullableUInt16Local();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToNullableUInt16LocalWhenInputOverflownThenResultIsNull()
    {
        // Arrange
        string @this = $"{ushort.MaxValue}{ushort.MaxValue}";

        // Act
        ushort? actual = @this.ToNullableUInt16Local();

        // Assert
        actual.Should().BeNull();
    }
}
