using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp8
{
    public class IndicesAndRanges
    {
        public static void Demo()
        {
            var places = new string[] { "first", "second", "third", "forth", "fifth" };

            var lastElenment = places[places.Length - 1];
            Console.WriteLine(lastElenment);
            
            // New way - Last Element
            lastElenment = places[^1];
            Console.WriteLine(lastElenment);

            // New Ranges. Upper Bound not inklusive!
            Console.WriteLine(places[2..4].Aggregate((r, n) => r + " " + n));
        }
    }
}
