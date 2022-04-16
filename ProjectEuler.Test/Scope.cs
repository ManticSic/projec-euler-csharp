using System;
using Unity;
using UnityContainerAttributeRegistration;

namespace ProjectEuler.Test;

public static class Scope
{
    private static readonly Lazy<IUnityContainer> lazyContainer = new(CreateUnityContainer);

    public static T Resolve<T>()
    {
        return lazyContainer.Value.Resolve<T>();
    }

    private static IUnityContainer CreateUnityContainer()
    {
        return new UnityContainerPopulator().Populate();
    }
}
