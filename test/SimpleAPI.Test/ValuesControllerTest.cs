namespace SimpleAPI.Test;
public class ValuesControllerTest
{
    private ValuesController _controller;

    public ValuesControllerTest()
    {
        _controller = new ValuesController();
    }

    [Fact]
    public void GetValues()
    {
        var returnValue = _controller.get().Value;

        Assert.Equal(4, returnValue.Count());
    }

    

    [Fact]
    public void GetReturnsMyName()
    {
        var returnValue = _controller.get(1);

        Assert.Equal("Les Jackson", returnValue.Value);
    }
}
