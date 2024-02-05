using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3pt2
{
    public interface IAnimal
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public double Height { get; set; }
        public int Age { get; set; }

        public abstract void Eat();
        public string Cry();

    }
}
