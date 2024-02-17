namespace Ace.CSharp.Extensions.Tests.ObjectExtensions;

public sealed class ToUInt64LocalTests
{
    [Fact]
    internal void GivenToUInt64LocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = ulong.MaxValue;
        ulong expected = ulong.MaxValue;

        // Act
        ulong actual = @this.ToUInt64Local();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToUInt64LocalWhenInputIsNotValidThenFormatExceptionIsThrown()
    {
        // Arrange
        object @this = "foo";

        // Act
        var action = () => @this.ToUInt64Local();

        // Assert
        action.Should().Throw<FormatException>();
    }

    [Fact]
    internal void GivenToUInt64LocalWhenInputIsNotValidThenInvalidCastExceptionIsThrown()
    {
        // Arrange
        object @this = new { Foo = "foo" };

        // Act
        var action = () => @this.ToUInt64Local();

        // Assert
        action.Should().Throw<InvalidCastException>();
    }

    [Fact]
    internal void GivenToUInt64LocalWhenInputIsNotValidThenOverflowExceptionIsThrown()
    {
        // Arrange
        object @this = $"{ulong.MaxValue}{ulong.MaxValue}";

        // Act
        var action = () => @this.ToUInt64Local();

        // Assert
        action.Should().Throw<OverflowException>();
    }

    [Fact]
    internal void GivenToUInt64OrDefaultLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = ulong.MaxValue;
        ulong expected = ulong.MaxValue;

        // Act
        ulong actual = @this.ToUInt64OrDefaultLocal();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToUInt64OrDefaultLocalWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        object @this = "foo";
        ulong expected = ulong.MaxValue;

        // Act
        ulong actual = @this.ToUInt64OrDefaultLocal(@default: expected);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToUInt64OrNullLocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = ulong.MaxValue;
        ulong expected = ulong.MaxValue;

        // Act
        ulong? actual = @this.ToUInt64OrNullLocal();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToUInt64OrNullLocalWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        object @this = "foo";

        // Act
        ulong? actual = @this.ToUInt64OrNullLocal();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToUInt64OrNullLocalWhenInputIsNullThenResultIsNull()
    {
        // Arrange
        object? @this = null;

        // Act
        ulong? actual = @this.ToUInt64OrNullLocal();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenTryConvertToUInt64LocalWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = ulong.MaxValue;
        ulong expected = ulong.MaxValue;

        // Act
        bool isUInt64 = @this.TryConvertToUInt64Local(out ulong actual);

        // Assert
        isUInt64.Should().BeTrue();
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToUInt64LocalWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        object @this = "foo";

        // Act
        bool isUInt64 = @this.TryConvertToUInt64Local(out ulong actual);

        // Assert
        isUInt64.Should().BeFalse();
        actual.Should().Be(default);
    }
}
