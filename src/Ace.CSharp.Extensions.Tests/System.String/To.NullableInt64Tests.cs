namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToNullableInt64Tests
{
    [Fact]
    internal void GivenToNullableInt64WhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = long.MaxValue.ToString(CultureInfo.CurrentCulture);
        long expected = long.MaxValue;

        // Act
        long? actual = @this.ToNullableInt64(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToNullableInt64WhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        string @this = "foo";

        // Act
        long? actual = @this.ToNullableInt64(provider: default);

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToNullableInt64WhenInputOverflownThenResultIsNull()
    {
        // Arrange
        string @this = $"{long.MaxValue}{long.MaxValue}";

        // Act
        long? actual = @this.ToNullableInt64(provider: default);

        // Assert
        actual.Should().BeNull();
    }

    [Theory]
    [InlineData(null, null)]
    [InlineData("", null)]
    [InlineData(" ", null)]
    internal void GivenToNullableInt64WhenInputIsNullOrWhiteSpaceThenResultIsExpected(string input, long? expected)
    {
        // Act
        long? actual = input.ToNullableInt64(null);

        // Assert
        actual.Should().Be(expected);
    }
}
