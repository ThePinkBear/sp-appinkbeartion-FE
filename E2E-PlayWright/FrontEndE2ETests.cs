using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;

namespace BlazorApp.End2End;

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class FrontEndE2ETests : PageTest
{
    [Test]
    public async Task Testing_RSI_Should_See_Pledge_Store()
    {
      // Arrange
      var testName = "Pledge Store";

      // Act
      await Page.GotoAsync($"https://robertsspaceindustries.com");
      var result = Page.GetByText(new Regex($"{testName}.*"));

      // Asseert
      await Expect(result).ToBeVisibleAsync();
    }
}