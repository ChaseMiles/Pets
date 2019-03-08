using System;

namespace Pets
{
    public class Pets
    {
        public string type;
        public string name;
        public string owner;
        public double weight;

        public Pets(string type, string name, string owner, double weight)
        {
            this.type = type;
            this.name = name;
            this.owner = owner;
            this.weight = weight;
        }

        public string getTag()
        {
            string tag = "If lost, call " + owner;
            return tag;
        }
    }
}
