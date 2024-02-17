namespace Ace.CSharp.Extensions.Tests.ObjectExtensions;

public sealed class ToUInt64InvariantTests
{
    [Fact]
    internal void GivenToUInt64InvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = ulong.MaxValue;
        ulong expected = ulong.MaxValue;

        // Act
        ulong actual = @this.ToUInt64Invariant();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToUInt64InvariantWhenInputIsNotValidThenFormatExceptionIsThrown()
    {
        // Arrange
        object @this = "foo";

        // Act
        var action = () => @this.ToUInt64Invariant();

        // Assert
        action.Should().Throw<FormatException>();
    }

    [Fact]
    internal void GivenToUInt64InvariantWhenInputIsNotValidThenInvalidCastExceptionIsThrown()
    {
        // Arrange
        object @this = new { Foo = "foo" };

        // Act
        var action = () => @this.ToUInt64Invariant();

        // Assert
        action.Should().Throw<InvalidCastException>();
    }

    [Fact]
    internal void GivenToUInt64InvariantWhenInputIsNotValidThenOverflowExceptionIsThrown()
    {
        // Arrange
        object @this = $"{ulong.MaxValue}{ulong.MaxValue}";

        // Act
        var action = () => @this.ToUInt64Invariant();

        // Assert
        action.Should().Throw<OverflowException>();
    }

    [Fact]
    internal void GivenToUInt64OrDefaultInvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = ulong.MaxValue;
        ulong expected = ulong.MaxValue;

        // Act
        ulong actual = @this.ToUInt64OrDefaultInvariant();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToUInt64OrDefaultInvariantWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        object @this = "foo";
        ulong expected = ulong.MaxValue;

        // Act
        ulong actual = @this.ToUInt64OrDefaultInvariant(@default: expected);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToUInt64OrNullInvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = ulong.MaxValue;
        ulong expected = ulong.MaxValue;

        // Act
        ulong? actual = @this.ToUInt64OrNullInvariant();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToUInt64OrNullInvariantWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        object @this = "foo";

        // Act
        ulong? actual = @this.ToUInt64OrNullInvariant();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToUInt64OrNullInvariantWhenInputIsNullThenResultIsNull()
    {
        // Arrange
        object? @this = null;

        // Act
        ulong? actual = @this.ToUInt64OrNullInvariant();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenTryConvertToUInt64InvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = ulong.MaxValue;
        ulong expected = ulong.MaxValue;

        // Act
        bool isUInt64 = @this.TryConvertToUInt64Invariant(out ulong actual);

        // Assert
        isUInt64.Should().BeTrue();
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToUInt64InvariantWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        object @this = "foo";

        // Act
        bool isUInt64 = @this.TryConvertToUInt64Invariant(out ulong actual);

        // Assert
        isUInt64.Should().BeFalse();
        actual.Should().Be(default);
    }
}
