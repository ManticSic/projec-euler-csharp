using NLog;
using Project_Euler.Automation;
using Project_Euler.Automation.ProblemCollection;
using Project_Euler.Util;
using UnityContainerAttributeRegistration.Attribute;

namespace Project_Euler.Problem0001;

/* If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
 *
 * Find the sum of all the multiples of 3 or 5 below 1000.
 */

[Problem]
[RegisterType]
public class Problem0001 : IProblem
{
    private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

    // public static void Main_(string[] args)
    // {
    //     int result = Enumerable.Range(1, 999)
    //                            .Where(value => Numbers.IsMultipleOf(value, 3) || Numbers.IsMultipleOf(value, 5))
    //                            .Aggregate(0, (total, next) => total + next);
    //
    //     Console.WriteLine(result);
    // }

    public void Run()
    {
        Logger.Trace("###################");
        Logger.Debug("###################");
        Logger.Info("###################");
        Logger.Warn("###################");
        Logger.Error("###################");
        Logger.Fatal("###################");
        // throw new NotImplementedException();
    }
}
