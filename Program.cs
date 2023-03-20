using System.Collections.Concurrent;

namespace thready2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Citac c1 = new Citac();
            //public static ConcurrentBag<int> cb = new ConcurrentBag<int>();
            //public static List<Task> bagAddTasks = new List<Task>();


            System.Console.WriteLine("---start---");
            // prvni zadani
            /*Thread th1 = new(new ThreadStart(c1.Zvys));
            Thread th2 = new(new ThreadStart(c1.Sniz));

            th1.Start();
            th2.Start();
            th1.Join();
            th2.Join();*/

            // druhe zadani
            Thread th3 = new Thread(new ThreadStart(generate));
            Thread th4 = new Thread(new ThreadStart(generate));

            th3.Start();
            th4.Start();
            th3.Join();
            th4.Join();

            System.Console.WriteLine("pocet vygenerovanych " + l1.Count());
            System.Console.WriteLine("stredni hodnota " + l1.Average());

            System.Console.WriteLine("---finish---");
        }
        public static List<int> l1 = new List<int>();
        public static object _lock = new object();
        public static void generate()
        {
            Random rnd = new Random();
            for (int i = 0; i < 1000 * 1000; i++)
            {
                lock (_lock)
                {
                    int num = rnd.Next(1, 1000);
                    l1.Add(num);
                }
            }
        }
        /*public static void generate2()
        {
            Random rnd = new Random();
            for (int i = 0; i < 1000 * 1000; i++)
            {
                lock (_lock)
                {
                    int num = rnd.Next(1, 1000);
                    bagAddTasks.Add(Task.Run(() => cb.Add(num)));
                    
                    l1.Add(num);
                }
            }
        }*/
    }
}