Console.WriteLine(IsValidIp("0.0.0.0"));

bool IsValidIp(string ipAddres)
{
    string[] parts = ipAddres.Split('.');

    if (parts.Length != 4)
    {
        return false;
    }

    foreach (string part in parts)
    {
        if (part.Length > 1 && part.StartsWith('0') || part.StartsWith(' ') || part.EndsWith(' '))
        {
            return false;
        }

        if (!int.TryParse(part, out int number))
        {
            return false;
        }

        if (number < 0 || number > 255)
        {
            return false;
        }
    }
    return true;
}

// Write an algorithm that will identify valid IPv4 addresses in dot-decimal format. IPs should be considered valid if they consist of four octets, with values between 0 and 255, inclusive.

// Valid inputs examples:
// Examples of valid inputs:
// 1.2.3.4
// 123.45.67.89
// Invalid input examples:
// 1.2.3
// 1.2.3.4.5
// 123.456.78.90
// 123.045.067.089
// Notes:
// Leading zeros(e.g. 01.02.03.04) are considered invalid
// Inputs are guaranteed to be a single string