using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SmartTextChecker : ISmartTextReader
{
    private readonly SmartTextReader _reader;

    public SmartTextChecker(SmartTextReader reader)
    {
        _reader = reader;
    }

    public char[][] ReadText(string sourceName)
    {
        Console.WriteLine($"Opening {sourceName}...");

        char[][] content = _reader.ReadText(sourceName);

        int totalLines = content.Length;
        int totalChars = content.Sum(line => line.Length);

        Console.WriteLine($"{sourceName} read successfully.");
        Console.WriteLine($"Total lines: {totalLines}, Total characters: {totalChars}");
        Console.WriteLine($"Closing {sourceName}...\n");

        return content;
    }
}