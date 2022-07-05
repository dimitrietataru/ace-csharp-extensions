namespace Ace.CSharp.Extensions.Tests.DateTimeExtensions;

public sealed class ToStringLocalTests
{
    [Fact]
    internal void GivenToStringLocalWhenThreadCultureIsSpecifiedThenLocalShouldEqualToString()
    {
        // Arrange
        string input = "31/12/1999 15:30:45";
        var dateTime = DateTime.Parse(input, CultureFactory.GetByName(Cultures.RoRO));
        string expectedLocal = "31.12.1999 15:30:45";

        // Act
        Thread.CurrentThread.CurrentCulture = CultureFactory.GetByName(Cultures.RoRO);
        string actualLocal = dateTime.ToStringLocal();
#pragma warning disable CA1305 // Specify IFormatProvider
        string actualToString = dateTime.ToString();
#pragma warning restore CA1305 // Specify IFormatProvider

        // Assert
        actualLocal.Should().NotBeNullOrEmpty().And.BeEquivalentTo(expectedLocal);
        actualToString.Should().NotBeNullOrEmpty();
        actualLocal.Should().BeEquivalentTo(actualToString);
    }

    [Fact]
    internal void GivenToStringLocalWhenFormatAndThreadCultureIsSpecifiedThenLocalShouldEqualToString()
    {
        // Arrange
        string input = "31/12/1999 15:30:45";
        string format = "dddd, dd MMMM yyyy HH:mm:ss";
        var dateTime = DateTime.Parse(input, CultureFactory.GetByName(Cultures.RoRO));
        string expectedLocal = "vineri, 31 decembrie 1999 15:30:45";

        // Act
        Thread.CurrentThread.CurrentCulture = CultureFactory.GetByName(Cultures.RoRO);
        string actualLocal = dateTime.ToStringLocal(format);
#pragma warning disable CA1305 // Specify IFormatProvider
        string actualToString = dateTime.ToString(format);
#pragma warning restore CA1305 // Specify IFormatProvider

        // Assert
        actualLocal.Should().NotBeNullOrEmpty().And.BeEquivalentTo(expectedLocal);
        actualToString.Should().NotBeNullOrEmpty();
        actualLocal.Should().BeEquivalentTo(actualToString);
    }
}
