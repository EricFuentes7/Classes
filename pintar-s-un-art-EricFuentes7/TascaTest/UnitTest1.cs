namespace Tasca;
public class UnitTest1
{
    /*[Fact]
    public void TestCalculaBePosicio()
    {
        int[] fanals = [1,3,7,10,13];
        var expected = 5;

        var resultat = Program.CalculFanals(fanals);

        Assert.Equal(expected, resultat);
    }
    */
    [Theory]
    [InlineData(5, 1, 3, 7, 10, 13)]
    [InlineData(10, 2, 5, 8, 12)]
    [InlineData(2, 3, 5, 7, 9, 10)]
    [InlineData(9, 12, 1, 6, 4, 3, 5)]
    [InlineData(5, 10)]

    
    public void TestCalculaBePosicio2(int expected, params int[] fanals)
    {
        var resultat = Program.CalculFanals(fanals);

        Assert.Equal(expected, resultat);
    }
}
