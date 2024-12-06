using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static List<string> FindAbbreviations(string text, string pattern)
    {
        MatchCollection matches = Regex.Matches(text, pattern);
        return matches.Select(m => m.Value).ToList();
    }

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        string text =
            "У сучасному веб-розробці часто використовуються технології, такі як HTML, " +
            "CSS, JavaScript, а також різноманітні фреймворки, як React, Angular, та бібліотеки, як jQuery. " +
            "Багато програм для розробки також підтримують мови баз даних, такі як SQL, NoSQL, а також інші формати, наприклад, JSON, XML, YAML. " +
            "У сучасному програмуванні часто застосовують такі інструменти, як Git, Docker, Kubernetes. " +
            "Інші популярні технології включають C++, C#, Swift, Rust.\r\n";

        string pattern = @"\b[A-Z0-9]+[#\+]*\b";

        var abbreviations = FindAbbreviations(text, pattern);

        if (abbreviations.Any())
        {
            Console.WriteLine("Знайдені абревіатури:");
            abbreviations.ForEach(Console.WriteLine);
        }
        else
        {
            Console.WriteLine("Абревіатур не знайдено.");
        }
    }
}
