namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToSingleTests
{
    [Fact]
    internal void GivenToSingleWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = float.MaxValue.ToString(provider: default);
        float expected = float.MaxValue;

        // Act
        float actual = @this.ToSingle(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToSingleWhenInputIsNotValidThenFormatExceptionIsThrown()
    {
        // Arrange
        string @this = "foo";

        // Act
        var action = () => @this.ToSingle(provider: default);

        // Assert
        action.Should().Throw<FormatException>();
    }

    [Fact]
    internal void GivenToSingleWhenInputIsNotValidThenOverflowExceptionIsNotThrown()
    {
        // Arrange
        string @this = $"{int.MaxValue}{float.MaxValue}";

        // Act
        var action = () => @this.ToSingle(provider: default);

        // Assert
        action.Should().NotThrow<OverflowException>();
        action().Should().Be(float.PositiveInfinity);
    }

    [Fact]
    internal void GivenToSingleOrDefaultWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = float.MaxValue.ToString(provider: default);
        float expected = float.MaxValue;

        // Act
        float actual = @this.ToSingleOrDefault(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToSingleOrDefaultWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        string @this = "foo";
        float expected = float.MaxValue;

        // Act
        float actual = @this.ToSingleOrDefault(provider: default, @default: expected);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToSingleOrNullWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = float.MaxValue.ToString(CultureInfo.CurrentCulture);
        float expected = float.MaxValue;

        // Act
        float? actual = @this.ToSingleOrNull(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToSingleOrNullWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        string @this = "foo";

        // Act
        float? actual = @this.ToSingleOrNull(provider: default);

        // Assert
        actual.Should().BeNull();
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData(" ")]
    internal void GivenToSingleOrNullWhenInputIsNullOrWhiteSpaceThenResultIsNull(string @this)
    {
        // Act
        float? actual = @this.ToSingleOrNull(provider: default);

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenTryConvertToSingleWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = float.MaxValue.ToString(provider: default);
        float expected = float.MaxValue;

        // Act
        bool isSingle = @this.TryConvertToSingle(provider: default, out float actual);

        // Assert
        isSingle.Should().BeTrue();
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToSingleWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        string @this = "foo";

        // Act
        bool isSingle = @this.TryConvertToSingle(provider: default, out float actual);

        // Assert
        isSingle.Should().BeFalse();
        actual.Should().Be(default);
    }
}
