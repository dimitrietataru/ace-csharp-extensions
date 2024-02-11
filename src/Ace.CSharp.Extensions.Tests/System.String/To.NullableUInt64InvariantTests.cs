namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToNullableUInt64InvariantTests
{
    [Fact]
    internal void GivenToNullableUInt64InvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = ulong.MaxValue.ToString(CultureInfo.CurrentCulture);
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
        string @this = "foo";

        // Act
        ulong? actual = @this.ToNullableUInt64Invariant();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToNullableUInt64InvariantWhenInputOverflownThenResultIsNull()
    {
        // Arrange
        string @this = $"{ulong.MaxValue}{ulong.MaxValue}";

        // Act
        ulong? actual = @this.ToNullableUInt64Invariant();

        // Assert
        actual.Should().BeNull();
    }
}
