namespace exercici1;

public class UnitTest1
{
    [Theory]
    [InlineData("10", 1, 3, 7, 10, 13)]
    [InlineData("45", 4,7,2,10,53,3,45)]
    [InlineData("2", 2,1,4,4)]
    [InlineData("error", 1)]
    [InlineData("error")]
    [InlineData("8", 1, 5, 8, 10)]
    [InlineData("error", 5, 5, 5, 5)]
    [InlineData("3", 3, 7)]
    [InlineData("100", int.MinValue, int.MaxValue, 100, -50)]
    [InlineData("-1", -10, -1, 5)]
        

    public void ComprovaAgafaPenultim(string expected, params int[] array)
    {
        var resultat = Program.CalculNumeroPenultim(array);
        Assert.Equal(expected, resultat.ToString());
    }
}
