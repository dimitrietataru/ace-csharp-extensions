namespace Ace.CSharp.Extensions.Tests.ObjectExtensions;

public sealed class ToDateTimeTests
{
    [Fact]
    internal void GivenToDateTimeWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = DateTime.UnixEpoch;
        var expected = DateTime.UnixEpoch;

        // Act
        var actual = @this.ToDateTime(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToDateTimeWhenInputIsNotValidThenFormatExceptionIsThrown()
    {
        // Arrange
        object @this = "foo";

        // Act
        var action = () => @this.ToDateTime(provider: default);

        // Assert
        action.Should().Throw<FormatException>();
    }

    [Fact]
    internal void GivenToDateTimeWhenInputIsNotValidThenInvalidCastExceptionIsThrown()
    {
        // Arrange
        object @this = new { Foo = "foo" };

        // Act
        var action = () => @this.ToDateTime(provider: default);

        // Assert
        action.Should().Throw<InvalidCastException>();
    }

    [Fact]
    internal void GivenToDateTimeOrDefaultWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = DateTime.UnixEpoch;
        var expected = DateTime.UnixEpoch;

        // Act
        var actual = @this.ToDateTimeOrDefault(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToDateTimeOrDefaultWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        object @this = "foo";
        var expected = DateTime.UnixEpoch;

        // Act
        var actual = @this.ToDateTimeOrDefault(provider: default, @default: expected);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToDateTimeOrNullWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = DateTime.UnixEpoch;
        DateTime expected = DateTime.UnixEpoch;

        // Act
        DateTime? actual = @this.ToDateTimeOrNull(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToDateTimeOrNullWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        object @this = "foo";

        // Act
        DateTime? actual = @this.ToDateTimeOrNull(provider: default);

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenToDateTimeOrNullWhenInputIsNullThenResultIsNull()
    {
        // Arrange
        object? @this = null;

        // Act
        DateTime? actual = @this.ToDateTimeOrNull(provider: default);

        // Assert
        actual.Should().BeNull();
    }

    [Fact]
    internal void GivenTryConvertToDateTimeWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = DateTime.UnixEpoch;
        var expected = DateTime.UnixEpoch;

        // Act
        bool isDateTime = @this.TryConvertToDateTime(provider: default, out var actual);

        // Assert
        isDateTime.Should().BeTrue();
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenTryConvertToDateTimeWhenInputIsNotValidThenResultIsDefault()
    {
        // Arrange
        object @this = "foo";

        // Act
        bool isDateTime = @this.TryConvertToDateTime(provider: default, out var actual);

        // Assert
        isDateTime.Should().BeFalse();
        actual.Should().Be(default);
    }
}
