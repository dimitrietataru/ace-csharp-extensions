namespace Ace.CSharp.Extensions.Tests.ObjectExtensions;

public sealed class ToNullableInt16LocalTests
{
    [Fact]
    internal void GivenToNullableInt16LocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object? @this = short.MaxValue;
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
        object @this = "foo";

        // Act
        short? actual = @this.ToNullableInt16Local();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToNullableInt16LocalWhenInputOverflownThenResultIsNull()
    {
        // Arrange
        object @this = $"{short.MaxValue}{short.MaxValue}";

        // Act
        short? actual = @this.ToNullableInt16Local();

        // Assert
        actual.Should().BeNull();
    }
}
