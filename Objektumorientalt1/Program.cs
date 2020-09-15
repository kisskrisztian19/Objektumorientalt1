using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objektumorientalt1
{
    class Zember
    {
        public string nev;
        public int eletkor;

        public void bemutatkozas()
        {
            Console.WriteLine($"{nev} vagyok {eletkor} éves.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Zember Pisti = new Zember();
            Zember Eva = new Zember();

            Pisti.nev = "Lakatos János";
            Pisti.eletkor = 42;

            Eva.nev = "Csutka Éva";
            Eva.eletkor = 22;

            Pisti.bemutatkozas();

            Eva.bemutatkozas();

            Console.ReadKey();
        }
    }
}
