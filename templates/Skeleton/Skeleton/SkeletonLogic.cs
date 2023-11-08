namespace Skeleton;

public class SkeletonLogic:ISkeletonLogic
{
    async Task<string> ISkeletonLogic.GetStarsAsync(int stars, CancellationToken cancellation) 
    {
        TimeSpan delay = TimeSpan.FromSeconds(stars % 5);
        await Task.Delay(delay, cancellation);
        return new string('*', stars);
    }
}