namespace XUnitTestProject1;
using dog;

public struct Dummy()
{
    [Theory]
    [InlineData(1,1)]
    public static void AddNumber(int a, int b)
    {
        Assert.Equal(2, a + b);
    }
}
