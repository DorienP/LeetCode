using Xunit;
using Solutions;

namespace Solutions.Tests;

public class UnitTest1
{
    [Fact]
    public void MinOperations_Test()
    {
        string input = "1111";
        var MinOperations = new MinOperations();
        int result = MinOperations.Run(input);
        
        Assert.Equal(2, result);
    }
}