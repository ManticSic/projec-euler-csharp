using Project_Euler.Util;

namespace Project_Euler.Problem0001;

/* If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
 *
 * Find the sum of all the multiples of 3 or 5 below 1000.
 */

public class Run
{
    public static void Main(string[] args)
    {
        int result = Enumerable.Range(1, 999)
                               .Where(value => Numbers.IsMultipleOf(value, 3) || Numbers.IsMultipleOf(value, 5))
                               .Aggregate(0, (total, next) => total + next);

        Console.WriteLine(result);
    }
}
