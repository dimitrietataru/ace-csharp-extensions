namespace Ace.CSharp.Extensions.Tests.ObjectExtensions;

public sealed class ToDateTimeInvariantTests
{
    [Fact]
    internal void GivenToDateTimeInvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = DateTime.UnixEpoch;
        var expected = DateTime.UnixEpoch;

        // Act
        var actual = @this.ToDateTimeInvariant();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToDateTimeInvariantWhenInputIsNotValidThenFormatExceptionIsThrown()
    {
        // Arrange
        object @this = "foo";

        // Act
        var action = () => @this.ToDateTimeInvariant();

        // Assert
        action.Should().Throw<FormatException>();
    }

    [Fact]
    internal void GivenToDateTimeInvariantWhenInputIsNotValidThenInvalidCastExceptionIsThrown()
    {
        // Arrange
        object @this = new { Foo = "foo" };

        // Act
        var action = () => @this.ToDateTimeInvariant();

        // Assert
        action.Should().Throw<InvalidCastException>();
    }

    [Fact]
    internal void GivenToDateTimeOrDefaultInvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = DateTime.UnixEpoch;
        var expected = DateTime.UnixEpoch;

        // Act
        var actual = @this.ToDateTimeOrDefaultInvariant();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToDateTimeOrDefaultInvariantWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        object @this = "foo";
        var expected = DateTime.UnixEpoch;

        // Act
        var actual = @this.ToDateTimeOrDefaultInvariant(@default: expected);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToDateTimeOrNullInvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = DateTime.UnixEpoch;
        var expected = DateTime.UnixEpoch;

        // Act
        var actual = @this.ToDateTimeOrNullInvariant();

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToDateTimeOrNullInvariantWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        object @this = "foo";

        // Act
        var actual = @this.ToDateTimeOrNullInvariant();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToDateTimeOrNullInvariantWhenInputIsNullThenResultIsNull()
    {
        // Arrange
        object? @this = null;

        // Act
        var actual = @this.ToDateTimeOrNullInvariant();

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenTryConvertToDateTimeInvariantWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = DateTime.UnixEpoch;
        var expected = DateTime.UnixEpoch;

        // Act
        bool isDateTime = @this.TryConvertToDateTimeInvariant(out var actual);

        // Assert
        isDateTime.Should().BeTrue();
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToDateTimeInvariantWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        object @this = "foo";

        // Act
        bool isDateTime = @this.TryConvertToDateTimeInvariant(out var actual);

        // Assert
        isDateTime.Should().BeFalse();
        actual.Should().Be(default);
    }
}
