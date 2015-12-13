using System;
using System.Linq;

internal class Bob
{
    public static string Hey(string text)
    {
        if (Nothing(text))
        {
            return "Fine. Be that way!";
        }
        if (Question(text))
        {
            return "Sure.";
        }
        if (Yelling(text))
        {
            return "Whoa, chill out!";
        }

        return "Whatever.";
    }

    private static bool Nothing(string text)
    {
        return string.IsNullOrWhiteSpace(text);
    }

    private static bool Yelling(string text)
    {
        return text.Trim().Any(char.IsLetter) && string.CompareOrdinal(text.ToUpper(), text) == 0;
    }

    private static bool Question(string text)
    {
        text = text.Trim();

        if (text.Substring(text.Length - 1, 1) != "?") return false;
        if (!text.Any(char.IsLetter)) return text.Any(x => !char.IsLetter(x));
        return string.CompareOrdinal(text.ToUpper(), text) != 0 && text.Any(x => !char.IsLetter(x));
    }
}