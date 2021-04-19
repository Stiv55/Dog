using System;

namespace pr1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog Dog1 = new Dog();
            Dog1.NAME = "Apple";
            Dog1.BREED = "Taksa";
            Dog1.AGE = 24.99F;
            Dog1.ShowName();
            Dog1.ShowAmount();
            Dog1.ShowCost();
        }
    }
}

