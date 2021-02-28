using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birds
{
    class Penguin : Birds,ISwimming
    {
        public Penguin(string s1, string s2, int i) : base(s1, s2, i) { }

        public void Swims()
        {
            Console.WriteLine("{0} умеет плавать", Species);
        }
        private int lifespan;
        public int Lifespan
        {
            get { return lifespan; }
            set
            {
                if ((value < 0) || (value > 20))
                {
                    throw new ArgumentException();
                }
                else
                {
                    lifespan = value;
                }
            }
        }

        public void Sit_on_eggs(int k)
        {
            Random r = new Random();
            int value = r.Next(0, k);
            if(value == 0)
                Console.WriteLine("Очень жаль, но ни один из птенцов не вылупился");
            else
            Console.WriteLine("Только {0} из {1} птенцов вылупились",value, k);
        }
    }


}