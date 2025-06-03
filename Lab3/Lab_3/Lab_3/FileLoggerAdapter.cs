using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class FileLoggerAdapter : Logger
{
    private FileWriter _fileWriter;

    public FileLoggerAdapter(string filePath)
    {
        _fileWriter = new FileWriter(filePath);
    }

    public new void Log(string message)
    {
        _fileWriter.WriteLine($"[LOG] {message}");
    }

    public new void Error(string message)
    {
        _fileWriter.WriteLine($"[ERROR] {message}");
    }

    public new void Warn(string message)
    {
        _fileWriter.WriteLine($"[WARN] {message}");
    }
}
