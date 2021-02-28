using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birds
{
    public class Budgerigar : Birds, IFlying
    {
        public Budgerigar(string s1, string s2, int i) : base(s1, s2, i) { }

        public void Flies()
        {
            Console.WriteLine("{0} умеет летать", Species);
        }
        private int body_length;
        public int Body_length
        {
            get { return body_length; }
            set
            {
                if ((value < 0) || (value > 23))
                {
                    throw new ArgumentException();
                }
                else
                {
                    body_length = value;

                }
            }
        }

        public void Speak(string s)
        {
            Console.WriteLine("Волнистый попугайчик сказал: {0}",s);
        }
    }

}