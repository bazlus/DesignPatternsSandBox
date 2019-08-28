using System;
using System.Collections.Generic;

namespace DecoratorPattern
{
    public interface ICoffee
    {
        decimal Cost();

        string GetDescription();
    }
}
