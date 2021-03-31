using Xunit;
using Bunit;

using DemoApp.Shared;

namespace DemoApp.Tests
{
  public class HelloWorldTest
  {
    [Fact]
    public void HelloWorldComponentRendersCorrectly()
    {
      // Arrange
      using var ctx = new TestContext();

      // Act
      var cut = ctx.RenderComponent<HelloWorld>();

      // Assert
      cut.MarkupMatches("<h1>Hello world from Blazor</h1>");
    }
  }
}