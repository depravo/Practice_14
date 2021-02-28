using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birds
{
    public abstract class Birds
    {
        public string Species { get;  set; }
        public string Habitat { get;  set; }
        public int Population { get;  set; }
        public Birds(string species, string habitat, int num)
        {
            Species = species;
            Habitat = habitat;
            if (num < 0)
            {
                throw new ArgumentException();
            }
            else
            { Population = num; }
        }
        public void GetInfo()

        {
            Console.WriteLine("Название вида: " + Species);
            Console.WriteLine("Место обитания: " + Habitat);
            Console.WriteLine("Количество особей данного вида:" + Population);

        }

    }
}

