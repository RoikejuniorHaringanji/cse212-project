using Xunit;

public class ProgramTest
{
    /// <summary>
    /// Test MysteryStack1.Run with palindromes and non-palindromes.
    /// Expected: "racecar" returns True, "stressed" returns False, "a nut for a jar of tuna" returns True.
    /// </summary>
    [Fact]
    public void TestMysteryStack1_Run()
    {
        Assert.True(MysteryStack1.Run("racecar"));
        Assert.False(MysteryStack1.Run("stressed"));
        Assert.True(MysteryStack1.Run("a nut for a jar of tuna"));
    }

    /// <summary>
    /// Test MysteryStack2.Run with valid postfix expressions.
    /// Expected: "5 3 7 + *" returns 50, "6 2 + 5 3 - /" returns 4.
    /// </summary>
    [Fact]
    public void TestMysteryStack2_Run_Valid()
    {
        Assert.Equal(50, MysteryStack2.Run("5 3 7 + *"));
        Assert.Equal(4, MysteryStack2.Run("6 2 + 5 3 - /"));
    }

    /// <summary>
    /// Test MysteryStack2.Run with invalid postfix expressions.
    /// Expected: "3 +" throws ApplicationException.
    /// </summary>
    [Fact]
    public void TestMysteryStack2_Run_InvalidCase1()
    {
        Assert.Throws<ApplicationException>(() => MysteryStack2.Run("3 +"));
    }

    /// <summary>
    /// Test MysteryStack2.Run with division by zero.
    /// Expected: "5 0 /" throws ApplicationException.
    /// </summary>
    [Fact]
    public void TestMysteryStack2_Run_InvalidCase2()
    {
        Assert.Throws<ApplicationException>(() => MysteryStack2.Run("5 0 /"));
    }

    /// <summary>
    /// Test MysteryStack2.Run with unsupported operator.
    /// Expected: "3 8 %" throws ApplicationException.
    /// </summary>
    [Fact]
    public void TestMysteryStack2_Run_InvalidCase3()
    {
        Assert.Throws<ApplicationException>(() => MysteryStack2.Run("3 8 %"));
    }

    /// <summary>
    /// Test MysteryStack2.Run with extra operands.
    /// Expected: "5 3 4 +" throws ApplicationException.
    /// </summary>
    [Fact]
    public void TestMysteryStack2_Run_InvalidCase4()
    {
        Assert.Throws<ApplicationException>(() => MysteryStack2.Run("5 3 4 +"));
    }
}