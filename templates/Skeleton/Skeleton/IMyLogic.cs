namespace Skeleton;

public interface IMyLogic
{
    Task<string> GetStarsAsync(int count, CancellationToken cancellation = default);
}