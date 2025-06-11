using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Components.Strategies;

namespace Components
{
    public class LightImageNode : LightNode
    {
        private readonly IImageLoadingStrategy _loadingStrategy;
        public string Href { get; }
        public string AltText { get; }

        public LightImageNode(string href, string altText)
        {
            Href = href;
            AltText = altText;

          
            _loadingStrategy = href.StartsWith("http", StringComparison.OrdinalIgnoreCase)
                ? new NetworkImageStrategy()
                : new FileSystemImageStrategy();
        }

        public byte[] LoadImage()
        {
            try
            {
                return _loadingStrategy.LoadImage(Href);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка завантаження зображення: {ex.Message}");
                return null;
            }
        }

        public override string OuterHtml => $"<img src='{Href}' alt='{AltText}'>";
        public override string InnerHtml => string.Empty;
    }
}