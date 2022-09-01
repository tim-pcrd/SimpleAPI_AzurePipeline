namespace SimpleAPI.Test;
public class ValuesControllerTest
{
    private ValuesController _controller;

    public ValuesControllerTest()
    {
        _controller = new ValuesController();
    }

    

    [Fact]
    public void GetReturnsMyName()
    {
        var returnValue = _controller.get(1);

        Assert.Equal("Les Jackson", returnValue.Value);
    }
}
