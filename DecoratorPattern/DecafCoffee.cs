using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class DecafCoffee : ICoffee
    {
        public decimal Cost()
        {
            return 1;
        }

        public string GetDescription()
        {
            return "Decaf Coffee";
        }
    }
}
