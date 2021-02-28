using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birds
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck dk = new Duck("Желтоносая кряква", "Водоёмы", 200000);
            dk.GetInfo();
            dk.Swims();
            try
            {
                dk.Weight = 34;
            }
            catch (Exception)
            {
                Console.WriteLine("Утки столько не весят!");
            }
            Kiwi kw = new Kiwi("Южный киви", "тропики", 70000);
            kw.Food = "зерна";
            kw.Eat();
            Penguin pg = new Penguin("Императорский пингвин", "Антарктика", 150000);
            try
            {
                pg.Lifespan = 300;
            }
            catch (Exception)
            {
                Console.WriteLine("Пингвины столько не живут!");
            }
            pg.Sit_on_eggs(5);
            pg.Swims();
            Budgerigar br = new Budgerigar("Волнистый попугайчик", "Австралия", 45000);
            br.Body_length = 10;
            Console.WriteLine("Длины тела волнистого попугайчика - {0}",br.Body_length);
            br.Speak("Дарова, отец!");
            Console.ReadKey();
        }
    }
}
