using System;

namespace Pets
{
    public class Dog : Pets
    {
        public Dog(string name, string owner, double weight) : base("dog", name, owner, weight)
        {
        }

        public string bark(int count)
        {
            string barks = "";

            for (int b = 0; b < count; b++)
            {
                barks += "bark!";
            }
            return barks;
        }
    }
}