using Xunit;
using Bunit;

using DemoApp.Shared;

namespace DemoApp.Tests
{
  public class MyInputTest
  {
    [Fact]
    public void MyInputComponentRendersCorrectly()
    {
      // Arrange
      using var ctx = new TestContext();

      // Act
      var cut = ctx.RenderComponent<MyInput>(
          parameters => parameters.Add(p => p.OnSubmit, someText => {
              Assert.Equal("hello", someText);
          }));

      var inputElement = cut.Find("input");
      inputElement.Change("hello");

      var buttonElement = cut.Find("button");
      buttonElement.Click();
    }
  }
}