namespace Ace.CSharp.Extensions.Tests.ObjectExtensions;

public sealed class ToUInt32LocalTests
{
    [Fact]
    internal void GivenToUInt32LocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = uint.MaxValue;
        uint expected = uint.MaxValue;

        // Act
        uint actual = @this.ToUInt32Local();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToUInt32LocalWhenInputIsNotValidThenFormatExceptionIsThrown()
    {
        // Arrange
        object @this = "foo";

        // Act
        var action = () => @this.ToUInt32Local();

        // Assert
        action.Should().Throw<FormatException>();
    }

    [Fact]
    internal void GivenToUInt32LocalWhenInputIsNotValidThenInvalidCastExceptionIsThrown()
    {
        // Arrange
        object @this = new { Foo = "foo" };

        // Act
        var action = () => @this.ToUInt32Local();

        // Assert
        action.Should().Throw<InvalidCastException>();
    }

    [Fact]
    internal void GivenToUInt32LocalWhenInputIsNotValidThenOverflowExceptionIsThrown()
    {
        // Arrange
        object @this = $"{uint.MaxValue}{uint.MaxValue}";

        // Act
        var action = () => @this.ToUInt32Local();

        // Assert
        action.Should().Throw<OverflowException>();
    }

    [Fact]
    internal void GivenToUInt32OrDefaultLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = uint.MaxValue;
        uint expected = uint.MaxValue;

        // Act
        uint actual = @this.ToUInt32OrDefaultLocal();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToUInt32OrDefaultLocalWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        object @this = "foo";
        uint expected = uint.MaxValue;

        // Act
        uint actual = @this.ToUInt32OrDefaultLocal(@default: expected);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToUInt32OrNullLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = uint.MaxValue;
        uint expected = uint.MaxValue;

        // Act
        uint? actual = @this.ToUInt32OrNullLocal();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToUInt32OrNullLocalWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        object @this = "foo";

        // Act
        uint? actual = @this.ToUInt32OrNullLocal();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToUInt32OrNullLocalWhenInputIsNullThenResultIsNull()
    {
        // Arrange
        object? @this = null;

        // Act
        uint? actual = @this.ToUInt32OrNullLocal();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenTryConvertToUInt32LocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = uint.MaxValue;
        uint expected = uint.MaxValue;

        // Act
        bool isUInt32 = @this.TryConvertToUInt32Local(out uint actual);

        // Assert
        isUInt32.Should().BeTrue();
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToUInt32LocalWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        object @this = "foo";

        // Act
        bool isUInt32 = @this.TryConvertToUInt32Local(out uint actual);

        // Assert
        isUInt32.Should().BeFalse();
        actual.Should().Be(default);
    }
}
