namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToSingleLocalTests
{
    [Fact]
    internal void GivenToSingleLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = float.MaxValue.ToString(CultureInfo.CurrentCulture);
        float expected = float.MaxValue;

        // Act
        float actual = @this.ToSingleLocal();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToSingleLocalWhenInputIsNotValidThenFormatExceptionIsThrown()
    {
        // Arrange
        string @this = "foo";

        // Act
        var action = () => @this.ToSingleLocal();

        // Assert
        action.Should().Throw<FormatException>();
    }

    [Fact]
    internal void GivenToSingleLocalWhenInputIsNotValidThenOverflowExceptionIsNotThrown()
    {
        // Arrange
        string @this = $"{int.MaxValue}{float.MaxValue}";

        // Act
        var action = () => @this.ToSingleLocal();

        // Assert
        action.Should().NotThrow<OverflowException>();
        action().Should().Be(float.PositiveInfinity);
    }

    [Fact]
    internal void GivenToSingleOrDefaultLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = float.MaxValue.ToString(CultureInfo.CurrentCulture);
        float expected = float.MaxValue;

        // Act
        float actual = @this.ToSingleOrDefaultLocal();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToSingleOrDefaultLocalWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        string @this = "foo";
        float expected = float.MaxValue;

        // Act
        float actual = @this.ToSingleOrDefaultLocal(@default: expected);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToSingleOrNullLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = float.MaxValue.ToString(CultureInfo.CurrentCulture);
        float expected = float.MaxValue;

        // Act
        float? actual = @this.ToSingleOrNullLocal();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToSingleOrNullLocalWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        string @this = "foo";

        // Act
        float? actual = @this.ToSingleOrNullLocal();

        // Assert
        actual.Should().BeNull();
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData(" ")]
    internal void GivenToSingleOrNullLocalWhenInputIsNullOrWhiteSpaceThenResultIsNull(string? @this)
    {
        // Arrange

        // Act
        float? actual = @this.ToSingleOrNullLocal();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenTryConvertToSingleLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = float.MaxValue.ToString(CultureInfo.CurrentCulture);
        float expected = float.MaxValue;

        // Act
        bool isSingle = @this.TryConvertToSingleLocal(out float actual);

        // Assert
        isSingle.Should().BeTrue();
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToSingleLocalWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        string @this = "foo";

        // Act
        bool isSingle = @this.TryConvertToSingleLocal(out float actual);

        // Assert
        isSingle.Should().BeFalse();
        actual.Should().Be(default);
    }
}
