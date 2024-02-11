namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToNullableIntTests
{
    [Fact]
    internal void GivenToNullableIntWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = int.MaxValue.ToString(CultureInfo.CurrentCulture);
        int expected = int.MaxValue;

        // Act
        int? actual = @this.ToNullableInt(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToNullableIntWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        string @this = "foo";

        // Act
        int? actual = @this.ToNullableInt(provider: default);

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToNullableIntWhenInputOverflownThenResultIsNull()
    {
        // Arrange
        string @this = $"{int.MaxValue}{int.MaxValue}";

        // Act
        int? actual = @this.ToNullableInt(provider: default);

        // Assert
        actual.Should().BeNull();
    }

    [Theory]
    [InlineData(null, null)]
    [InlineData("", null)]
    [InlineData(" ", null)]
    internal void GivenToNullableIntWhenInputIsNullOrWhiteSpaceThenResultIsExpected(string input, int? expected)
    {
        // Act
        int? actual = input.ToNullableInt(null);

        // Assert
        actual.Should().Be(expected);
    }
}
