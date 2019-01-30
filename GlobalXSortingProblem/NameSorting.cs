using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GlobalXSortingProblem
{
    public class NameSorting : INameSorting
    {
        private string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public NameSorting()
        {

        }

        public List<string> GetSortedNames(List<string> names)
        {
            try
            {
                if (names.Count == 0) Console.WriteLine("Please Enter some names to sort in txt file");
                var list = new List<string>();
                names.Sort();
                using (StreamWriter streamWriter = new StreamWriter(Path.Combine(docPath, "sorted-names-list.txt"), false))
                {
                    foreach (string line in names)
                    {
                        streamWriter.WriteLine(ReverseString(line));
                        list.Add(ReverseString(line));
                    }
                }
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception("There is an exception" + ex.InnerException.ToString());
            }
        }

        public string ReverseString(string s)
        {
            string[] arr = s.Split(' ');
            Array.Reverse(arr);
            return string.Join(" ", arr);
        }

    }

}