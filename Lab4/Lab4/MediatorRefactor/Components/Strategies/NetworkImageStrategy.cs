
using System;
using System.Net;

namespace Components.Strategies
{
    public class NetworkImageStrategy : IImageLoadingStrategy
    {
        public byte[] LoadImage(string href)
        {
            using (var webClient = new WebClient())
            {
                return webClient.DownloadData(href);
            }
        }
    }
}
