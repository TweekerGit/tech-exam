using TechExam.Services;
using Xunit;

namespace TechExam.Tests;

public class UnitTests
{
    private readonly TestService _testService;

    public UnitTests(TestService testService)
    {
        _testService = testService;
    }

    [Fact]
    public void ServiceTests()
    {
        
    }
}