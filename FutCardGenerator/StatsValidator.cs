namespace FutCardGenerator;

public static class StatsValidator
{
    public static int StatLimiter(int stat)
    {
        return Math.Clamp(stat, 1, 99);
    }

    public static string NameLimiter(string name, int minLen, int maxLen)
    {
        name = name.Trim();

        if (name.Length > maxLen)
        {
            return name.Substring(0, maxLen);
        }

        if (name.Length < minLen)
        {
            name = "NaN";
            return name;
        }
        return name;
    }
}
