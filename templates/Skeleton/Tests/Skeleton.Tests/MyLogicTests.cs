using Skeleton;
namespace Skeleton.Tests;

public class MyLogicTests
{
    [Theory]
    [InlineData(2, "**")]
    [InlineData(0, "")]
    [InlineData(-3, "***")]
    public async Task GetStarsAsyncTest(int count, string expected )
    {
        IMyLogic logic = new MyLogic();
        string result = await logic.GetStarsAsync( count, CancellationToken.None);
        Assert.Equal(expected, result);
    }
}