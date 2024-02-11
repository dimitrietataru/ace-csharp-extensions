namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToNullableSingleLocalTests
{
    [Fact]
    internal void GivenToNullableSingleLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = float.MaxValue.ToString(CultureInfo.CurrentCulture);
        float expected = float.MaxValue;

        // Act
        float? actual = @this.ToNullableSingleLocal();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToNullableSingleLocalWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        string @this = "foo";

        // Act
        float? actual = @this.ToNullableSingleLocal();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToNullableSingleLocalWhenInputOverflownThenResultIsNull()
    {
        // Arrange
        string @this = $"{float.MaxValue}{float.MaxValue}";

        // Act
        float? actual = @this.ToNullableSingleLocal();

        // Assert
        actual.Should().BeNull();
    }
}
