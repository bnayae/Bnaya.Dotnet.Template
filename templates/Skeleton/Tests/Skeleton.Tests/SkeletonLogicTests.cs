using Skeleton;
namespace Skeleton.Tests;

public class SkeletonLogicTests
{
    [Theory]
    [InlineData(2, "**")]
    [InlineData(0, "")]
    [InlineData(-3, "***")]
    public async Task GetStarsAsyncTest(int count, string expected )
    {
        ISkeletonLogic logic = new SkeletonLogic();
        string result = await logic.GetStarsAsync( count, CancellationToken.None);
        Assert.Equal(expected, result);
    }
}