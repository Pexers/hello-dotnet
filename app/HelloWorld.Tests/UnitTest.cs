namespace HelloWorld.Tests;
using HelloWorld;

public class UnitTest
{
    [Fact]
    public void Test1()
    {
        string response = App.GetMessage();
        Assert.Equal(response, "Hello, World!");
    }
}
