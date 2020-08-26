using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckConsoleApp
{
    public interface FlyMethods
    {
        void Fly();
    }
    public class Duck : FlyMethods
    {
        public void Fly()
        {
            Console.WriteLine("Flying");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            FlyMethods flyMethods = new Duck();
            flyMethods.Fly();
            
        }

    }
}
