namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToNullableInt16LocalTests
{
    [Fact]
    internal void GivenToNullableInt16LocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = short.MaxValue.ToString(CultureInfo.CurrentCulture);
        short expected = short.MaxValue;

        // Act
        short? actual = @this.ToNullableInt16Local();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToNullableInt16LocalWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        string @this = "foo";

        // Act
        short? actual = @this.ToNullableInt16Local();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToNullableInt16LocalWhenInputOverflownThenResultIsNull()
    {
        // Arrange
        string @this = $"{short.MaxValue}{short.MaxValue}";

        // Act
        short? actual = @this.ToNullableInt16Local();

        // Assert
        actual.Should().BeNull();
    }
}
