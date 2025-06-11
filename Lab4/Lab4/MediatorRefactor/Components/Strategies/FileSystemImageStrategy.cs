using System;
using System.IO;

namespace Components.Strategies
{
    public class FileSystemImageStrategy : IImageLoadingStrategy
    {
        public byte[] LoadImage(string href)
        {
            if (!File.Exists(href))
                throw new FileNotFoundException($"Файл не знайдено: {href}");

            return File.ReadAllBytes(href);
        }
    }
}
