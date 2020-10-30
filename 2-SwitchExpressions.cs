using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp8
{
    public enum MathType
    {
        Add,
        Substarct,
        Multiply,
        Divide
    }

    public class SwitchExpressions
    {
        public static double DoMath(double x, double y, MathType mathType)
        {
            var oldWay = false;

            // Old way
            if (oldWay)
            {
                switch (mathType)
                {
                    case MathType.Add:
                        return x + y;
                    case MathType.Substarct:
                        return x - y;
                    case MathType.Multiply:
                        return x * y;
                    case MathType.Divide:
                        return x / y;
                    default:
                        throw new Exception();
                }
            }
            else // New way
            {
                return mathType switch
                {
                    MathType.Add => x + y,
                    MathType.Substarct => x - y,
                    MathType.Multiply => x * y,
                    MathType.Divide => x / y,
                    _ => throw new Exception()
                };
            }
        }


    }
}
