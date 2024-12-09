Console.WriteLine(stockSummary(new string[] { "ROXANNE 102", "RHODODE 123", "BKWRKAA 125", "BTSQZFG 239", "DRTYMKH 060" }, new string[] { }));

string stockSummary(String[] lstOfArt, String[] lstOf1stLetter)
{
    List<string> arts = new List<string>();

    if (lstOfArt.Length == 0 || lstOf1stLetter.Length == 0)
    {
        return string.Empty;
    }

    foreach (string letter in lstOf1stLetter)
    {
        int sum = lstOfArt.Where(art => art.StartsWith(letter)).Select(art => int.Parse(art.Split(' ')[1])).Sum();
        arts.Add($"({letter} : {sum})");
    }

    return string.Join(" - ", arts.ToArray());
}