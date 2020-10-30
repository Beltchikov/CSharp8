using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp8
{
    public class NullCoalescingAssignment
    {
        public static void Demo()
        {
            bool oldWay = false;
            var wrapper = new Wrapper();

            if (oldWay)
            {
                if (wrapper.Numbers == null)
                {
                    wrapper.Numbers = new List<int>();
                }
            }
            else // New way
            {
                wrapper.Numbers ??= new List<int>();
            }
        }
    }

    public class Wrapper
    {
        public List<int> Numbers { get; set; }
    }
}
