Console.WriteLine(StripComments("a \n b \nc ", new string[] { "#", "!", "%" }));


string StripComments(string text, string[] commentSymbols)
{
    string[] lines = text.Split(new[] { '\n' }, StringSplitOptions.None); // Разбиение на строки
    for (int i = 0; i < lines.Length; i++)
    {
        var parts = lines[i].Split(commentSymbols, StringSplitOptions.RemoveEmptyEntries);
        lines[i] = parts.FirstOrDefault()?.TrimEnd() ?? "";
    }

    return string.Join("\n", lines);
}

// не закончил
