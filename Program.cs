using System.Collections.Generic;

namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<string>list=new List<string>();
            add(list);
            
          foreach(string s in list)
            {
                Console.WriteLine(s);
            }
        }
        static void add(List<string> list )
        {
            string name =Console.ReadLine();
            list.Add(name);
        }
    }
}