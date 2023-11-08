using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skeleton;

public static class ModuleDI
{
    public static IServiceCollection AddLogic(this IServiceCollection services)
    {
        services.AddSingleton<ISkeletonLogic, SkeletonLogic>();    
        return services;
    }
}
