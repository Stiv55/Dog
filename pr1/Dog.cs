using System;
using System.Collections.Generic;
using System.Text;

namespace pr1
{
    class Dog
    {
        private string name;
        private string breed;
        private float age;
        public Dog()
        {
            name = "";
            breed = "";
            age = 0;
        }
        public void ShowCost()
        {
            Console.WriteLine("The current stuff breed = {0}", breed);
        }
        public void ShowName()
        {
            Console.WriteLine("The current stuff name is {0}", name);
        }
        public void ShowAmount()
        {
            Console.WriteLine("The current stuff age = {0}", age);
        }
        public string NAME
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string BREED
        {
            get
            {
                return breed;
            }
            set
            {
                breed = value;
            }
        }
        public float AGE
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
    }
}
