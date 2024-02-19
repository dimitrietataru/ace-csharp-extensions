namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToSingleInvariantTests
{
    [Fact]
    internal void GivenToSingleInvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = float.MaxValue.ToString(CultureInfo.InvariantCulture);
        float expected = float.MaxValue;

        // Act
        float actual = @this.ToSingleInvariant();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToSingleInvariantWhenInputIsNotValidThenFormatExceptionIsThrown()
    {
        // Arrange
        string @this = "foo";

        // Act
        var action = () => @this.ToSingleInvariant();

        // Assert
        action.Should().Throw<FormatException>();
    }

    [Fact]
    internal void GivenToSingleInvariantWhenInputIsNotValidThenOverflowExceptionIsNotThrown()
    {
        // Arrange
        string @this = $"{int.MaxValue}{float.MaxValue}";

        // Act
        var action = () => @this.ToSingleInvariant();

        // Assert
        action.Should().NotThrow<OverflowException>();
        action().Should().Be(float.PositiveInfinity);
    }

    [Fact]
    internal void GivenToSingleOrDefaultInvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = float.MaxValue.ToString(CultureInfo.InvariantCulture);
        float expected = float.MaxValue;

        // Act
        float actual = @this.ToSingleOrDefaultInvariant();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToSingleOrDefaultInvariantWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        string @this = "foo";
        float expected = float.MaxValue;

        // Act
        float actual = @this.ToSingleOrDefaultInvariant(@default: expected);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToSingleOrNullInvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = float.MaxValue.ToString(CultureInfo.InvariantCulture);
        float expected = float.MaxValue;

        // Act
        float? actual = @this.ToSingleOrNullInvariant();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToSingleOrNullInvariantWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        string @this = "foo";

        // Act
        float? actual = @this.ToSingleOrNullInvariant();

        // Assert
        actual.Should().BeNull();
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData(" ")]
    internal void GivenToSingleOrNullInvariantWhenInputIsNullOrWhiteSpaceThenResultIsNull(string? @this)
    {
        // Arrange

        // Act
        float? actual = @this.ToSingleOrNullInvariant();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenTryConvertToSingleInvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = float.MaxValue.ToString(CultureInfo.InvariantCulture);
        float expected = float.MaxValue;

        // Act
        bool isSingle = @this.TryConvertToSingleInvariant(out float actual);

        // Assert
        isSingle.Should().BeTrue();
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToSingleInvariantWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        string @this = "foo";

        // Act
        bool isSingle = @this.TryConvertToSingleInvariant(out float actual);

        // Assert
        isSingle.Should().BeFalse();
        actual.Should().Be(default);
    }
}
