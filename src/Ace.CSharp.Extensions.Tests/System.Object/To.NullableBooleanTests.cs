namespace Ace.CSharp.Extensions.Tests.ObjectExtensions;

public sealed class ToNullableBooleanTests
{
    [Fact]
    internal void GivenToNullableBooleanWhenInputIsValidThenResultIsExpected()
    {
        // Arrange
        object @this = true;
        bool expected = true;

        // Act
        bool? actual = @this.ToNullableBoolean(provider: default);

        // Assert
        actual.Should().Be(expected);
    }

    [Fact]
    internal void GivenToNullableBooleanWhenInputIsNotValidThenResultIsNull()
    {
        // Arrange
        object @this = "foo";

        // Act
        bool? actual = @this.ToNullableBoolean(provider: default);

        // Assert
        actual.Should().BeNull();
    }
}
