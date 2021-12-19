using TechExam.Services;
using Xunit;

namespace TechExam.Tests;

public class UnitTests
{
    private readonly TestService _testService;

    public UnitTests()
    {
        _testService = new TestService();
    }

    [Fact]
    public void ServiceTests()
    {
        
    }
}