using System;
namespace Pets
{
    public class Cat : Pets
    {
        public Cat(string name, string owner, double weight) : base("cat", name, owner, weight)
        {
        }

        public string meow(int count)
        {
            string meows = "";
            int numMeow = 0;

            while (numMeow < count)
            {
                meows += "meow.";
                numMeow++;
            }
            return meows;
        }
    }
}
