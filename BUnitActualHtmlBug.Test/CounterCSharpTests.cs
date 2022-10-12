using System.Threading.Tasks;
using BUnitActualHtmlBug.Pages;

namespace BUnitActualHtmlBug.Test;

/// <summary>
/// These tests are written entirely in C#.
/// Learn more at https://bunit.dev/docs/getting-started/writing-tests.html#creating-basic-tests-in-cs-files
/// </summary>
public class CounterCSharpTests : BunitTestContext
{

    [Test]
    public async Task ClickingButtonIncrementsCounter()
    {
        // Arrange
        var cut = RenderComponent<Counter>();

        // Act - click button to increment counter
        cut.Find("button").Click();

        // await Task.Delay(100);
        // Assert that the counter was incremented
        cut.Find("p").MarkupMatches("<p diff:ignoreAttributes>Current count: 1</p>");
    }
}
