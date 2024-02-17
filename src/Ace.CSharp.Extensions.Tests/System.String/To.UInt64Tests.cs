namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToUInt64Tests
{
    [Fact]
    internal void GivenToUInt64WhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = ulong.MaxValue.ToString(provider: default);
        ulong expected = ulong.MaxValue;

        // Act
        ulong actual = @this.ToUInt64(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToUInt64WhenInputIsNotValidThenFormatExceptionIsThrown()
    {
        // Arrange
        string @this = "foo";

        // Act
        var action = () => @this.ToUInt64(provider: default);

        // Assert
        action.Should().Throw<FormatException>();
    }

    [Fact]
    internal void GivenToUInt64WhenInputIsNotValidThenOverflowExceptionIsThrown()
    {
        // Arrange
        string @this = $"{ulong.MaxValue}{ulong.MaxValue}";

        // Act
        var action = () => @this.ToUInt64(provider: default);

        // Assert
        action.Should().Throw<OverflowException>();
    }

    [Fact]
    internal void GivenToUInt64OrDefaultWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = ulong.MaxValue.ToString(provider: default);
        ulong expected = ulong.MaxValue;

        // Act
        ulong actual = @this.ToUInt64OrDefault(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToUInt64OrDefaultWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        string @this = "foo";
        ulong expected = ulong.MaxValue;

        // Act
        ulong actual = @this.ToUInt64OrDefault(provider: default, @default: expected);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToUInt64OrNullWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = ulong.MaxValue.ToString(CultureInfo.CurrentCulture);
        ulong expected = ulong.MaxValue;

        // Act
        ulong? actual = @this.ToUInt64OrNull(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToUInt64OrNullWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        string @this = "foo";

        // Act
        ulong? actual = @this.ToUInt64OrNull(provider: default);

        // Assert
        actual.Should().BeNull();
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData(" ")]
    internal void GivenToUInt64OrNullWhenInputIsNullOrWhiteSpaceThenResultIsNull(string @this)
    {
        // Act
        ulong? actual = @this.ToUInt64OrNull(provider: default);

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenTryConvertToUInt64WhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = ulong.MaxValue.ToString(provider: default);
        ulong expected = ulong.MaxValue;

        // Act
        bool isUInt64 = @this.TryConvertToUInt64(provider: default, out ulong actual);

        // Assert
        isUInt64.Should().BeTrue();
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToUInt64WhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        string @this = "foo";

        // Act
        bool isUInt64 = @this.TryConvertToUInt64(provider: default, out ulong actual);

        // Assert
        isUInt64.Should().BeFalse();
        actual.Should().Be(default);
    }
}
