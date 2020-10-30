using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CSharp8
{
    public class UsingDeclarations
    {
        public static void ConvertFiles()
        {
            bool oldWay = false;

            if (oldWay)
            {
                using (var inputFile = new StreamReader(@"C:\Temp\input.txt"))
                {
                    using (var ouputFile = new StreamWriter(@"C:\Temp\output.txt"))
                    {
                        string line;
                        while ((line = inputFile.ReadLine()) != null)
                        {
                            ouputFile.WriteLine(line);
                        }
                    }
                }
            }
            else // New way
            {
                using var inputFile = new StreamReader(@"C:\Temp\input.txt");
                using var outputFile = new StreamWriter(@"C:\Temp\output.txt");
                string line;
                while ((line = inputFile.ReadLine()) != null)
                {
                    outputFile.WriteLine(line);
                }
            }
        }
    }
}
