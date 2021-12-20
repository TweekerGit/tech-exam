namespace TechExam.Services;

public class ProgressionService
{
    public long GetNElement(int n, int a = 5, int difference = 2)
    {
        long b = a;
        for (var i = 1; i < n; i++) b += difference;
        return b;
    }
}