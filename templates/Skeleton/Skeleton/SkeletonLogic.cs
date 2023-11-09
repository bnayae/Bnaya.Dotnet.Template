namespace Skeleton;

using static System.Math;

internal class SkeletonLogic: ISkeletonLogic
{
    async Task<string> ISkeletonLogic.GetStarsAsync(int count, CancellationToken cancellation) 
    {
        int stars = Abs(count);
        TimeSpan delay = TimeSpan.FromSeconds(stars % 5);
        await Task.Delay(delay, cancellation);
        return new string('*', stars);
    }
}