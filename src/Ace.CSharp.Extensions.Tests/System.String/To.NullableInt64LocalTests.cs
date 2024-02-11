namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToNullableInt64LocalTests
{
    [Fact]
    internal void GivenToNullableInt64LocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = long.MaxValue.ToString(CultureInfo.CurrentCulture);
        long expected = long.MaxValue;

        // Act
        long? actual = @this.ToNullableInt64Local();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToNullableInt64LocalWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        string @this = "foo";

        // Act
        long? actual = @this.ToNullableInt64Local();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToNullableInt64LocalWhenInputOverflownThenResultIsNull()
    {
        // Arrange
        string @this = $"{long.MaxValue}{long.MaxValue}";

        // Act
        long? actual = @this.ToNullableInt64Local();

        // Assert
        actual.Should().BeNull();
    }
}
