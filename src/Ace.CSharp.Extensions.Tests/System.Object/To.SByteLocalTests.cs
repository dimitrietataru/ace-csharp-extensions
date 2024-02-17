namespace Ace.CSharp.Extensions.Tests.ObjectExtensions;

public sealed class ToSByteLocalTests
{
    [Fact]
    internal void GivenToSByteLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = sbyte.MaxValue;
        sbyte expected = sbyte.MaxValue;

        // Act
        sbyte actual = @this.ToSByteLocal();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToSByteLocalWhenInputIsNotValidThenFormatExceptionIsThrown()
    {
        // Arrange
        object @this = "foo";

        // Act
        var action = () => @this.ToSByteLocal();

        // Assert
        action.Should().Throw<FormatException>();
    }

    [Fact]
    internal void GivenToSByteLocalWhenInputIsNotValidThenInvalidCastExceptionIsThrown()
    {
        // Arrange
        object @this = new { Foo = "foo" };

        // Act
        var action = () => @this.ToSByteLocal();

        // Assert
        action.Should().Throw<InvalidCastException>();
    }

    [Fact]
    internal void GivenToSByteLocalWhenInputIsNotValidThenOverflowExceptionIsThrown()
    {
        // Arrange
        object @this = $"{sbyte.MaxValue}{sbyte.MaxValue}";

        // Act
        var action = () => @this.ToSByteLocal();

        // Assert
        action.Should().Throw<OverflowException>();
    }

    [Fact]
    internal void GivenToSByteOrDefaultLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = sbyte.MaxValue;
        sbyte expected = sbyte.MaxValue;

        // Act
        sbyte actual = @this.ToSByteOrDefaultLocal();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToSByteOrDefaultLocalWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        object @this = "foo";
        sbyte expected = sbyte.MaxValue;

        // Act
        sbyte actual = @this.ToSByteOrDefaultLocal(@default: expected);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToSByteOrNullLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = sbyte.MaxValue;
        sbyte expected = sbyte.MaxValue;

        // Act
        sbyte? actual = @this.ToSByteOrNullLocal();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToSByteOrNullLocalWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        object @this = "foo";

        // Act
        sbyte? actual = @this.ToSByteOrNullLocal();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToSByteOrNullLocalWhenInputIsNullThenResultIsNull()
    {
        // Arrange
        object? @this = null;

        // Act
        sbyte? actual = @this.ToSByteOrNullLocal();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenTryConvertToSByteLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = sbyte.MaxValue;
        sbyte expected = sbyte.MaxValue;

        // Act
        bool isSByte = @this.TryConvertToSByteLocal(out sbyte actual);

        // Assert
        isSByte.Should().BeTrue();
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToSByteLocalWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        object @this = "foo";

        // Act
        bool isSByte = @this.TryConvertToSByteLocal(out sbyte actual);

        // Assert
        isSByte.Should().BeFalse();
        actual.Should().Be(default);
    }
}
