using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birds
{
    public class Kiwi : Birds
    {
        public Kiwi(string s1, string s2, int i) : base(s1, s2, i) { }

        private string food;
        public string Food
        {
            get { return food; }
            set
            {
                if (value == "")
                {
                    throw new ArgumentNullException();
                }
                else { food = value; }
            }
        }

        public void Eat()
        {
            Console.WriteLine("{0} кушают {1}",Species, food);
        }
    }

}
