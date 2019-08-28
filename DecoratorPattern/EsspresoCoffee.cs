using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class EsspresoCoffee : ICoffee
    {
        public decimal Cost()
        {
            return 1.5m;
        }

        public string GetDescription()
        {
            return "Esspreso Coffee";
        }
    }
}
