using Project_Euler.Automation.ProblemCollection;
using Project_Euler.Util;
using Unity;
using UnityContainerAttributeRegistration;

namespace Project_Euler;

public class Program
{
    public static void Main(string[] args)
    {
        IUnityContainer           container = new UnityContainerPopulator().Populate();
        IReadOnlyCollection<Type> problems  = new ProblemCollector().Collect();

        Type anyProblem = problems.First();

        IProblem problemToRun = (IProblem) container.Resolve(anyProblem);
        problemToRun.Run();
    }
}
