
Console.WriteLine(GetReadableTime(59));
string GetReadableTime(int seconds)
{
    int hour = seconds / 3600;
    int minute = (seconds % 3600) / 60;
    int second = seconds % 60;

    return $"{hour:D2}:{minute:D2}:{second:D2}";
}
