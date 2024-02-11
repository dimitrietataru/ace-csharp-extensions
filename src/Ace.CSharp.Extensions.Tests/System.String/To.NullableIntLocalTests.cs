namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToNullableIntLocalTests
{
    [Fact]
    internal void GivenToNullableIntLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = int.MaxValue.ToString(CultureInfo.CurrentCulture);
        int expected = int.MaxValue;

        // Act
        int? actual = @this.ToNullableIntLocal();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToNullableIntLocalWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        string @this = "foo";

        // Act
        int? actual = @this.ToNullableIntLocal();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToNullableIntLocalWhenInputOverflownThenResultIsNull()
    {
        // Arrange
        string @this = $"{int.MaxValue}{int.MaxValue}";

        // Act
        int? actual = @this.ToNullableIntLocal();

        // Assert
        actual.Should().BeNull();
    }
}
