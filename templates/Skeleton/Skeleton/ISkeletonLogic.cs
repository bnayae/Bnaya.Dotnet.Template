namespace Skeleton;

public interface ISkeletonLogic
{
    Task<string> GetStarsAsync(int stars, CancellationToken cancellation = default);
}