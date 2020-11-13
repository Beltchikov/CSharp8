using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp8
{
    public class NullableReferenceTypes
    {
        public static void Demo()
        {
            // Provoke NPE
            string text = null;
            var length = text.Length;

            // Configure project file
            string newConfigurationBlock = "<LangVersion>8</LangVersion>";
            newConfigurationBlock += " < Nullable > enable </ Nullable >";
        }
    }
}
