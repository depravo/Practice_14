using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birds
{
    public class Duck : Birds,ISwimming
    {
        public Duck(string s1, string s2, int i) : base(s1, s2, i) { }
        public void Swims()
        {
            Console.WriteLine("{0} умеет летать",this.Species);
        }
        private int weight;
        public int Weight
        {
            get { return weight; }
            set
            {
                if ((value < 0) || (value > 4))
                {
                    throw new ArgumentException();
                }
                else
                {
                    weight = value;
                }
            }
        }
    }

}
