using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

public class SmartTextReader : ISmartTextReader
{
    public virtual char[][] ReadText(string sourceName)
    {
        // Імітація читання файлу
        string[] sampleLines = new[] {
            "Hello world",
            "This is a test",
            "File content example"
        };

        char[][] result = new char[sampleLines.Length][];
        for (int i = 0; i < sampleLines.Length; i++)
        {
            result[i] = sampleLines[i].ToCharArray();
        }

        return result;
    }
}
