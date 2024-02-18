namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToUInt16Tests
{
    [Fact]
    internal void GivenToUInt16WhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = ushort.MaxValue.ToString(provider: default);
        ushort expected = ushort.MaxValue;

        // Act
        ushort actual = @this.ToUInt16(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToUInt16WhenInputIsNotValidThenFormatExceptionIsThrown()
    {
        // Arrange
        string @this = "foo";

        // Act
        var action = () => @this.ToUInt16(provider: default);

        // Assert
        action.Should().Throw<FormatException>();
    }

    [Fact]
    internal void GivenToUInt16WhenInputIsNotValidThenOverflowExceptionIsThrown()
    {
        // Arrange
        string @this = $"{ushort.MaxValue}{ushort.MaxValue}";

        // Act
        var action = () => @this.ToUInt16(provider: default);

        // Assert
        action.Should().Throw<OverflowException>();
    }

    [Fact]
    internal void GivenToUInt16OrDefaultWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = ushort.MaxValue.ToString(provider: default);
        ushort expected = ushort.MaxValue;

        // Act
        ushort actual = @this.ToUInt16OrDefault(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToUInt16OrDefaultWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        string @this = "foo";
        ushort expected = ushort.MaxValue;

        // Act
        ushort actual = @this.ToUInt16OrDefault(provider: default, @default: expected);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToUInt16OrNullWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = ushort.MaxValue.ToString(CultureInfo.CurrentCulture);
        ushort expected = ushort.MaxValue;

        // Act
        ushort? actual = @this.ToUInt16OrNull(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToUInt16OrNullWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        string @this = "foo";

        // Act
        ushort? actual = @this.ToUInt16OrNull(provider: default);

        // Assert
        actual.Should().BeNull();
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData(" ")]
    internal void GivenToUInt16OrNullWhenInputIsNullOrWhiteSpaceThenResultIsNull(string @this)
    {
        // Act
        ushort? actual = @this.ToUInt16OrNull(provider: default);

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenTryConvertToUInt16WhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = ushort.MaxValue.ToString(provider: default);
        ushort expected = ushort.MaxValue;

        // Act
        bool isUInt16 = @this.TryConvertToUInt16(provider: default, out ushort actual);

        // Assert
        isUInt16.Should().BeTrue();
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToUInt16WhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        string @this = "foo";

        // Act
        bool isUInt16 = @this.TryConvertToUInt16(provider: default, out ushort actual);

        // Assert
        isUInt16.Should().BeFalse();
        actual.Should().Be(default);
    }
}
