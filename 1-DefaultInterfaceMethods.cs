using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp8
{
    public interface IShoppingCart
    {
        void CalculateTotal();

        // Second method breaks class implementation
        void CalculateSubTotal()
        // To avoid the breaking default implementition can be used
        {

        }
    }

    public class ShoppingCart : IShoppingCart
    {
        public void CalculateTotal()
        {
            Console.WriteLine("CalculateTotal()");
        }
    }
}
