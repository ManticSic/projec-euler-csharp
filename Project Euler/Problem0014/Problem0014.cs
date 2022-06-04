using Project_Euler.Util;

namespace Project_Euler.Problem0014;

public class Problem0014
{
    private readonly Numbers numbers;

    public Problem0014(Numbers numbers)
    {
        this.numbers = numbers;
    }

    public Result0014? Solve()
    {
        return Enumerable.Range(1, 1000000)
                  .Select(value =>
                          {
                              long NextCalculation()
                              {
                                  return ProcessValue(value);
                              }

                              return CreateCollatzSequence(NextCalculation)
                                     .Prepend(value)
                                     .ToList();
                          })
                  .Select(chain =>
                          {
                              return new Result0014(chain);
                          })
                  .MaxBy(obj => obj.Count);
    }

    private IEnumerable<long> CreateCollatzSequence(Func<long> calculation)
    {
        long value = calculation();

        if (value == 1)
        {
            return new List<long>() { value };
        }

        long NextCalculation()
        {
            return ProcessValue(value);
        }

        return CreateCollatzSequence(NextCalculation)
            .Prepend(value);
    }

    private long ProcessValue(long value)
    {
        return numbers.IsEven(value) ? ProcessEven(value) : ProcessOdd(value);
    }

    private long ProcessEven(long value)
    {
        return value / 2;
    }

    private long ProcessOdd(long value)
    {
        return 3 * value + 1;
    }
}
