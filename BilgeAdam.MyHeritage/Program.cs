using BilgeAdam.MyHeritage.Concretes;
using System;

namespace BilgeAdam.MyHeritage
{
    class Program
    {
        //sonsuz => StackOverFlowException
        //public int Number { get { return Number; } set { Number = value; } }
        static string B()
        {
            var s = string.Empty;
            for (int i = 0; i < 10000; i++)
            {
                s += i;
            }
            return s;
        }
        static int A(int i)
        {
            if (i == 10)
            {
                return i;
            }
            return A(++i) * i;
        }
        static void Main(string[] args)
        {
            //var b = B();//01234567
            //var a = A(5);
            var grandfather = new Man("Ahmet", "Yıldız");
            var grandmother = new Woman("Leyla", "Kara");
            grandfather.Match(grandmother);
            var child1 = new Man("Tamer", "Yıldız");
            var child2 = new Woman("Yaren", "Yıldız");
            grandfather.AddChild(child1);
            grandmother.AddChild(child2);
            //grandmother.Match(grandfather);

            Console.ReadKey();
        }
    }
}
