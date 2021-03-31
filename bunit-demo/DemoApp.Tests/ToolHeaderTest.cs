using Xunit;
using Bunit;

using DemoApp.Shared;

namespace DemoApp.Tests
{
  public class ToolHeaderTest
  {
    [Fact]
    public void ToolHeaderComponentRendersCorrectly()
    {
      // Arrange
      using var ctx = new TestContext();

      // Act
      var cut = ctx.RenderComponent<ToolHeader>(parameters => parameters.Add(p => p.HeaderText, "The Tool"));

      // Assert
      cut.MarkupMatches("<header><h1>The Tool</h1></header>");
    }
  }
}