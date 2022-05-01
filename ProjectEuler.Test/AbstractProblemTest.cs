using System;
using System.Collections;
using System.Diagnostics;
using System.Linq;
using NLog;

namespace ProjectEuler.Test;

public abstract class AbstractProblemTest<TSut> : AbstractTest<TSut>
{
    private static readonly Logger _Logger = LogManager.GetLogger("Test", typeof(TSut));

    protected void Solve<TResult>(Func<TResult> action)
    {
        GC.Collect();
        Stopwatch sw     = Stopwatch.StartNew();
        TResult   result = action.Invoke();
        sw.Stop();

        PrintResult(result, sw.Elapsed);
    }

    private void PrintResult(object? result, TimeSpan timeNeeded)
    {
        Type? resultType = result?.GetType();

        if (resultType is { IsArray: true })
        {
            PrintArrayResult(result as IEnumerable ?? throw new InvalidOperationException(), timeNeeded);
        }
        else
        {
            PrintResultAsString(result?.ToString(), timeNeeded);
        }
    }

    private void PrintArrayResult(IEnumerable result, TimeSpan timeNeeded)
    {
        PrintResultAsString(String.Join(",", result.Cast<object>().ToArray()), timeNeeded);
    }

    private void PrintResultAsString(string? result, TimeSpan timeNeeded)
    {
        _Logger.Info("################");
        _Logger.Info($"# Problem {typeof(TSut).Name} was solved");
        _Logger.Info($"# Result: {result}");
        _Logger.Info($"Time needed: {timeNeeded}");
        _Logger.Info("################");
    }
}
