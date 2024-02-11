namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToNullableInt64InvariantTests
{
    [Fact]
    internal void GivenToNullableInt64InvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = long.MaxValue.ToString(CultureInfo.CurrentCulture);
        long expected = long.MaxValue;

        // Act
        long? actual = @this.ToNullableInt64Invariant();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToNullableInt64InvariantWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        string @this = "foo";

        // Act
        long? actual = @this.ToNullableInt64Invariant();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToNullableInt64InvariantWhenInputOverflownThenResultIsNull()
    {
        // Arrange
        string @this = $"{long.MaxValue}{long.MaxValue}";

        // Act
        long? actual = @this.ToNullableInt64Invariant();

        // Assert
        actual.Should().BeNull();
    }
}
