namespace Skeleton;

public interface ISkeletonLogic
{
    Task<string> GetStarsAsync(int count, CancellationToken cancellation = default);
}