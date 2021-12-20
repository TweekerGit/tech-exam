using TechExam.sqrt.Services;
using Xunit;

namespace TechExam.sqrt.Tests;

public class Tests
{
    private readonly SqrtService _service;

    public Tests()
    {
        _service = new SqrtService();
    }

    [Fact]
    public void Test1()
    {
        var number = 9;
        var sqrt = _service.GetSqrt(9);
        Assert.NotNull(sqrt);
        Assert.IsType<int>(number);
        Assert.IsType<double>(sqrt);
        Assert.Equal(3, sqrt);
    }

    [Fact]
    public void Test2()
    {
        int number = 256;
        var sqrt = _service.GetSqrt(number);
        Assert.IsType<int>(number);
        Assert.IsType<double>(sqrt);
        Assert.Equal(16, sqrt);
    }
}