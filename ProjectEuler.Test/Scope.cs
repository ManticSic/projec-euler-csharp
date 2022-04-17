using System;
using Unity;
using UnityContainerAttributeRegistration;

namespace ProjectEuler.Test;

public class Scope
{
    private static readonly Lazy<Scope> instance = new(CreateInstance);

    private readonly IUnityContainer container;

    private Scope(IUnityContainer container)
    {
        this.container = container;
    }

    public static Scope Default => instance.Value;

    public T Resolve<T>()
    {
        return container.Resolve<T>();
    }

    private static Scope CreateInstance()
    {
        IUnityContainer container = new UnityContainerPopulator().Populate();

        return new Scope(container);
    }
}
