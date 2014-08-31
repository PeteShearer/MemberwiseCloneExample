using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberwiseCloneExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ShallowClone();
            DeepClone();
        }

        static void ShallowClone()
        {
            Console.WriteLine("Shallow Clone Example: {0}{0}", Environment.NewLine);

            Person bigBoss = new Person() { Name = "Tony", Boss = null };
            Person boss = new Person() { Name = "Silvio", Boss = bigBoss };
            Person worker = new Person() { Name = "Paulie", Boss = boss };

            Person cloneWorker = worker.ShallowCopy();
            Console.WriteLine("Are the workers the same? {0}", worker.Equals(cloneWorker));
            Console.WriteLine("Are the bosses the same? {0}", worker.Boss.Equals(cloneWorker.Boss));

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("Since the bosses are the same, if I change a property of the original boss, it changes in both places");
            worker.Boss.Name = "Chuck";
            Console.WriteLine("Worker's Boss' Name: {0}.", worker.Boss.Name);
            Console.WriteLine("Clone Worker's Boss' Name: {0}.", cloneWorker.Boss.Name);
            Console.WriteLine(Environment.NewLine);
        }

        static void DeepClone()
        {
            Console.WriteLine("Deep Clone Example: {0}{0}", Environment.NewLine);

            Person bigBoss = new Person() { Name = "Tony", Boss = null };
            Person boss = new Person() { Name = "Silvio", Boss = bigBoss };
            Person worker = new Person() { Name = "Paulie", Boss = boss };

            Person cloneWorker = worker.DeepCopy();
            Console.WriteLine("Are the workers the same? {0}", worker.Equals(cloneWorker));
            Console.WriteLine("Are the bosses the same? {0}", worker.Boss.Equals(cloneWorker.Boss));

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("Since the bosses are NOT the same, if I change a property of the original boss, it does not change in both places");
            worker.Boss.Name = "Chuck";
            Console.WriteLine("Worker's Boss' Name: {0}.", worker.Boss.Name);
            Console.WriteLine("Clone Worker's Boss' Name: {0}.", cloneWorker.Boss.Name);
            Console.WriteLine(Environment.NewLine);
        }
    }
}
