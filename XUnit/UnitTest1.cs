//namespace XUnitTestProject1;
//using dog;

//public class UnitTest1
//{
//    [Fact]
//    public void XUnitTestMethod1()
//    {

//        Assert.StrictEqual(2, Hello.AddNumber(1, 1));
//    }

//    [Fact]
//    public void XUnitTestShouldFail()
//    {
//        Assert.True(false);
//    }

//    [Fact(Skip = "I Said So")]
//    public void XUnitTestShouldSkip()
//    {
//        Assert.True(false);
//    }

//    [Fact]
//    public void XUnitTestShouldError()
//    {
//        throw new Exception("This is an error");
//    }

//    [Theory]
//    [InlineData("This is a data test")]
//    [InlineData("This will return false")]
//    public void XUnitTestWithParams(string needed)
//    {
//        Assert.Equal("This is a data test", needed);
//    }

//}
