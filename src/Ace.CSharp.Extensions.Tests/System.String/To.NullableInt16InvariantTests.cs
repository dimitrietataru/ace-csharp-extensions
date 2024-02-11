namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToNullableInt16InvariantTests
{
    [Fact]
    internal void GivenToNullableInt16InvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = short.MaxValue.ToString(CultureInfo.CurrentCulture);
        short expected = short.MaxValue;

        // Act
        short? actual = @this.ToNullableInt16Invariant();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToNullableInt16InvariantWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        string @this = "foo";

        // Act
        short? actual = @this.ToNullableInt16Invariant();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToNullableInt16InvariantWhenInputOverflownThenResultIsNull()
    {
        // Arrange
        string @this = $"{short.MaxValue}{short.MaxValue}";

        // Act
        short? actual = @this.ToNullableInt16Invariant();

        // Assert
        actual.Should().BeNull();
    }
}
