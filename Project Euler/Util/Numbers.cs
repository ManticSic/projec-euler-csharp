namespace Project_Euler.Util;

public static class Numbers
{
    public static bool IsMultipleOf(int multiple, int value)
    {
        return value % multiple == 0;
    }
}
