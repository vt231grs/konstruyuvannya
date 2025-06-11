using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Strategies
{
    public interface IImageLoadingStrategy
    {
        byte[] LoadImage(string href);
    }
}
