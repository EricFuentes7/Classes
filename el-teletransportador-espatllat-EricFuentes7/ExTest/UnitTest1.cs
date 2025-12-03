namespace exercici;

public class UnitTest1
{

    //No sabia com afegir un [,] a test, tema MemberData ha ajudat la IA.
   public static IEnumerable<object[]> Datos =>
        new List<object[]>
        {
            new object[] { new int[,] { {1, 3}, {3, 7} }, "[1..7]" },
            new object[] { new int[,] { {1, 5}, {5, 9}, {7, 12} }, "[1..12]" },
            new object[] { new int[,] { {4, 6}, {5, 7}, {5, 6}, {1, 2} }, "[1..2][4..7]" },
            new object[] { new int[,] { {15, 25}, {30, 33}, {31, 36}, {1, 12}, {8, 16}}, "[1..25][30..36]" },
            new object[] { new int[,] { {1, 2}, {3, 4}, {6, 6} }, "[1..4][6..6]" },
            new object[] { new int[,] { {10, 12}, {11, 15} }, "[10..15]" },
            new object[] { new int[,] { }, "" },
            new object[] { new int[,] { {-4, 5}, {-2, 7} }, "[-4..7]" }, //OUT RANGE
            new object[] { new int[,] { {7, 2}, {4, 1} }, "[1..7]" },
            new object[] { new int[,] { {1, 12} }, "[1..12]" },



        };

    [Theory]
    [MemberData(nameof(Datos))]
    public void TestCalculMolecular(int[,] numeros, string expected)
    {
        var resultat = Program.CalculMolecular(numeros);
        Assert.Equal(expected, string.Join("", expected));
    }
}
