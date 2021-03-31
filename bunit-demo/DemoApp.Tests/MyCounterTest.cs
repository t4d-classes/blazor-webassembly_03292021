using Xunit;
using Bunit;

using DemoApp.Shared;

namespace DemoApp.Tests
{
  public class MyCounterTest
  {
    [Fact]
    public void MyCounterComponentRendersCorrectly()
    {
      // Arrange
      using var ctx = new TestContext();

      // Act
      var cut = ctx.RenderComponent<MyCounter>(
          parameters => parameters.Add(p => p.OnIncrement, counter => {
              Assert.Equal(1, counter);
          }));

      var buttonElement = cut.Find("button");
      buttonElement.Click();
    }
  }
}