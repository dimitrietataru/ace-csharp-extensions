namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToNullableBooleanTests
{
    [Fact]
    internal void GivenToNullableBooleanWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = true.ToString(CultureInfo.CurrentCulture);
        bool expected = true;

        // Act
        bool? actual = @this.ToNullableBoolean(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToNullableBooleanWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        string @this = "foo";

        // Act
        bool? actual = @this.ToNullableBoolean(provider: default);

        // Assert
        actual.Should().BeNull();
    }

    [Theory]
    [InlineData(null, null)]
    [InlineData("", null)]
    [InlineData(" ", null)]
    internal void GivenToNullableBooleanWhenInputIsNullOrWhiteSpaceThenResultIsExpected(string input, bool? expected)
    {
        // Act
        bool? actual = input.ToNullableBoolean(null);

        // Assert
        actual.Should().Be(expected);
    }
}
