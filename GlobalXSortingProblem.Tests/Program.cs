using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace GlobalXSortingProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Specify the input file location");
            var input = Console.ReadLine();
            List<string> names = new List<string>();
            INameSorting nameSorting = new NameSorting();
            using (StreamReader streamReader = new StreamReader(Path.Combine(input, "unsorted-names-list.txt")))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    names.Add(nameSorting.ReverseString(line.ToString()));
                }
            }
            var output = nameSorting.WriteSortedNames(names);
            Console.WriteLine("Sorted Names List:");
            foreach (var item in output)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }

}