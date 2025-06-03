using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Text.RegularExpressions;

public class SmartTextLocker : ISmartTextReader
{
    private readonly SmartTextReader _reader;
    private readonly Regex _restrictionPattern;

    public SmartTextLocker(SmartTextReader reader, string pattern)
    {
        _reader = reader;
        _restrictionPattern = new Regex(pattern);
    }

    public char[][] ReadText(string sourceName)
    {
        if (_restrictionPattern.IsMatch(sourceName))
        {
            Console.WriteLine($"Access denied to {sourceName}!\n");
            return Array.Empty<char[]>();
        }

        return _reader.ReadText(sourceName);
    }
}
