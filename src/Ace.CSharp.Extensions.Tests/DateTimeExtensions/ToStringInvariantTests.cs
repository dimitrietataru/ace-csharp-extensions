namespace Ace.CSharp.Extensions.Tests.DateTimeExtensions;

public sealed class ToStringInvariantTests
{
    [Fact]
    internal void GivenToStringInvariantWhenThreadCultureIsSpecifiedThenInvariantShouldNotEqualLocal()
    {
        // Arrange
        string input = "12/31/1999 15:30:45";
        var dateTime = DateTime.Parse(input, CultureFactory.GetByName(Cultures.EnUS));
        string expectedInvariant = "12/31/1999 15:30:45";
        string expectedLocal = "31.12.1999 15:30:45";

        // Act
        Thread.CurrentThread.CurrentCulture = CultureFactory.GetByName(Cultures.RoRO);
        string actualInvariant = dateTime.ToStringInvariant();
        string actualLocal = dateTime.ToStringLocal();

        // Assert
        actualInvariant.Should().NotBeNullOrEmpty().And.BeEquivalentTo(expectedInvariant);
        actualLocal.Should().NotBeNullOrEmpty().And.BeEquivalentTo(expectedLocal);
        actualInvariant.Should().NotBeEquivalentTo(actualLocal);
    }

    [Fact]
    internal void GivenToStringInvariantWhenFormatAndThreadCultureIsSpecifiedThenInvariantShouldNotEqualLocal()
    {
        // Arrange
        string input = "12/31/1999 15:30:45";
        string format = "dddd, dd MMMM yyyy HH:mm:ss";
        var dateTime = DateTime.Parse(input, CultureFactory.GetByName(Cultures.EnUS));
        string expectedInvariant = "Friday, 31 December 1999 15:30:45";
        string expectedLocal = "vineri, 31 decembrie 1999 15:30:45";

        // Act
        Thread.CurrentThread.CurrentCulture = CultureFactory.GetByName(Cultures.RoRO);
        string actualInvariant = dateTime.ToStringInvariant(format);
        string actualLocal = dateTime.ToStringLocal(format);

        // Assert
        actualInvariant.Should().NotBeNullOrEmpty().And.BeEquivalentTo(expectedInvariant);
        actualLocal.Should().NotBeNullOrEmpty().And.BeEquivalentTo(expectedLocal);
        actualInvariant.Should().NotBeEquivalentTo(actualLocal);
    }
}
