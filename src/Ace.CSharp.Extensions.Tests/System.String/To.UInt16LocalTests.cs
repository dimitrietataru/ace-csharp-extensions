namespace Ace.CSharp.Extensions.Tests.StringExtensions;

public sealed class ToUInt16LocalTests
{
    [Fact]
    internal void GivenToUInt16LocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = ((ushort)1024).ToString(CultureInfo.CurrentCulture);
        ushort expected = 1024;

        // Act
        ushort actual = @this.ToUInt16Local();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToUInt16LocalWhenInputIsNotValidThenFormatExceptionIsThrown()
    {
        // Arrange
        string @this = "foo";

        // Act
        var action = () => @this.ToUInt16Local();

        // Assert
        action.Should().Throw<FormatException>();
    }

    [Fact]
    internal void GivenToUInt16LocalWhenInputIsNotValidThenOverflowExceptionIsThrown()
    {
        // Arrange
        string @this = $"{ushort.MaxValue}{ushort.MaxValue}";

        // Act
        var action = () => @this.ToUInt16Local();

        // Assert
        action.Should().Throw<OverflowException>();
    }

    [Fact]
    internal void GivenToUInt16OrDefaultLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = ((ushort)1024).ToString(CultureInfo.CurrentCulture);
        ushort expected = 1024;

        // Act
        ushort actual = @this.ToUInt16OrDefaultLocal();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToUInt16OrDefaultLocalWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        string @this = "foo";
        ushort expected = 1024;

        // Act
        ushort actual = @this.ToUInt16OrDefaultLocal(@default: expected);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToUInt16LocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        string @this = ((ushort)1024).ToString(CultureInfo.CurrentCulture);
        ushort expected = 1024;

        // Act
        bool isUInt16 = @this.TryConvertToUInt16Local(out ushort actual);

        // Assert
        isUInt16.Should().BeTrue();
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToUInt16LocalWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        string @this = "foo";

        // Act
        bool isUInt16 = @this.TryConvertToUInt16Local(out ushort actual);

        // Assert
        isUInt16.Should().BeFalse();
        actual.Should().Be(default);
    }
}
