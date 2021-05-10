using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Rescue.Tests
{
    public class GenArray<TItems> // int, string, bool, func, genarray<int>
    {
        protected TItems[] array;

        public void lol()
        {
            GenArray<GenArray<GenArray<int>>> xD = new GenArray<GenArray<GenArray<int>>>();
        }
    }

    public struct genArrayxD<TItems>
    {
        
    }
}
