namespace Project_Euler.Automation.ProblemCollection;

public sealed class ProblemCollector : IProblemCollector
{
    public IReadOnlyCollection<Type> Collect()
    {
        return AppDomain.CurrentDomain.GetAssemblies()
                               .SelectMany(assembly => assembly.GetTypes())
                               .Where(classType => classType.IsDefined(typeof(ProblemAttribute), true))
                               .ToList()
                               .AsReadOnly();
    }
}
