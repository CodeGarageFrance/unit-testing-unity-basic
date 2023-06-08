using UnityEngine;
using System;
using System.Text.RegularExpressions;

public class RegexFunctions : MonoBehaviour
{
    public static bool IsAlphanumeric(string input)
    {
        return Regex.IsMatch(input, @"^[a-zA-Z0-9]+$");
    }

    // Function to validate an email address
    public static bool ValidateEmail(string email)
    {
        string emailRegex = @"^[^\s@]+@[^\s@]+\.[^\s@]+$";
        return Regex.IsMatch(email, emailRegex);
    }

    // Function to extract all URLs from a text
    public static string[] ExtractURLs(string text)
    {
        string urlRegex = @"(https?:\/\/[^\s]+)";
        MatchCollection matches = Regex.Matches(text, urlRegex);
        string[] urls = new string[matches.Count];
        for (int i = 0; i < matches.Count; i++)
        {
            urls[i] = matches[i].Value;
        }
        return urls;
    }
}
