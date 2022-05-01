namespace ProjectEuler.Test;

public abstract class AbstractTest<TSut>
{
    protected readonly TSut Sut = Scope.Default.Resolve<TSut>();
}
