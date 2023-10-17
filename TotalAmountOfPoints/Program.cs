internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(TotalPoints(new string[] { "1:0", "2:0", "3:0", "4:0", "2:1", "3:1", "4:1", "3:2", "4:2", "4:3"}));
    }

    public static int TotalPoints(string[] games)
    {
        return games.Sum(sum => sum[0] > sum[2] ? 3 : sum[0] == sum[2] ? 1 : 0);
    }

    //public static int TotalPoints(string[] games)
    //{
    //    int totalPoints = 0;

    //    foreach (string game in games)
    //    {
    //        if (game[0] > game[2])
    //        {
    //            totalPoints += 3;
    //        }
    //        else if (game[0] == game[2])
    //        {
    //            totalPoints++;
    //        }
    //    }

    //    return totalPoints;
    //}
}