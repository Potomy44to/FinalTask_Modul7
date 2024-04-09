using System;
namespace FinalTask7
{
    abstract internal class Delivery
    {
        internal string Address { get; set; }

        internal abstract void Deliver();
    }
}

