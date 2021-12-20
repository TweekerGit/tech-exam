using TechExam.Services;
using Xunit;

namespace TechExam.Tests;

public class UnitTests
{
    private readonly ProgressionService _progressionService;

    public UnitTests()
    {
        _progressionService = new ProgressionService();
    }

    [Fact]
    public void ServiceTests()
    {
        var n = 19;
        var result = _progressionService.GetNElement(n);
        Assert.Equal(41, result);
        Assert.IsType<long>(result);
        Assert.NotNull(result);
        Assert.NotNull(n);
    }
}