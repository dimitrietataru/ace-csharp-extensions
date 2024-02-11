namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToNullableInt32Tests
{
    [Fact]
    internal void GivenToNullableInt32WhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = int.MaxValue.ToString(CultureInfo.CurrentCulture);
        int expected = int.MaxValue;

        // Act
        int? actual = @this.ToNullableInt32(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToNullableInt32WhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        string @this = "foo";

        // Act
        int? actual = @this.ToNullableInt32(provider: default);

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToNullableInt32WhenInputOverflownThenResultIsNull()
    {
        // Arrange
        string @this = $"{int.MaxValue}{int.MaxValue}";

        // Act
        int? actual = @this.ToNullableInt32(provider: default);

        // Assert
        actual.Should().BeNull();
    }

    [Theory]
    [InlineData(null, null)]
    [InlineData("", null)]
    [InlineData(" ", null)]
    internal void GivenToNullableInt32WhenInputIsNullOrWhiteSpaceThenResultIsExpected(string input, int? expected)
    {
        // Act
        int? actual = input.ToNullableInt32(null);

        // Assert
        actual.Should().Be(expected);
    }
}
