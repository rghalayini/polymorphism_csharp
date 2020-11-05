using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Animal
    {
        public string Name { get; set; }
        public string FavouriteFood { get; set; }

        protected Animal (string name, string favouriteFood)
        {
            this.Name = name;
            this.FavouriteFood = favouriteFood;
        }
        public virtual string ExplainSelf()
        {
            return $"I am {this.Name} and my favourite food is {this.FavouriteFood}";
        }
    }

    class Cat :Animal
    {
        public Cat(string name, string favouriteFood) : base(name, favouriteFood)
        { }
        public override string ExplainSelf()
        {
            return base.ExplainSelf() + Environment.NewLine + "MEEOW";
        }
    }
    class Dog : Animal
    {
        public Dog (string name, string favouriteFood) : base(name, favouriteFood)
        { }
        public override string ExplainSelf()
        {
            return base.ExplainSelf() + Environment.NewLine + "WOUF";
        }

    }
}
