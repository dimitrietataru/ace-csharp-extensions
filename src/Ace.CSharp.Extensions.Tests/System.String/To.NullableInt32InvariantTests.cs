namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToNullableInt32InvariantTests
{
    [Fact]
    internal void GivenToNullableInt32InvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = int.MaxValue.ToString(CultureInfo.CurrentCulture);
        int expected = int.MaxValue;

        // Act
        int? actual = @this.ToNullableInt32Invariant();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToNullableInt32InvariantWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        string @this = "foo";

        // Act
        int? actual = @this.ToNullableInt32Invariant();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToNullableInt32InvariantWhenInputOverflownThenResultIsNull()
    {
        // Arrange
        string @this = $"{int.MaxValue}{int.MaxValue}";

        // Act
        int? actual = @this.ToNullableInt32Invariant();

        // Assert
        actual.Should().BeNull();
    }
}
