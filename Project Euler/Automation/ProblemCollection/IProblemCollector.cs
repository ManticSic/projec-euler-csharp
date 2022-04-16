namespace Project_Euler.Automation.ProblemCollection;

public interface IProblemCollector
{
    IReadOnlyCollection<Type> Collect();
}
