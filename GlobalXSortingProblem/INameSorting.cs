using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalXSortingProblem
{
    public interface INameSorting
    {
        List<string> GetSortedNames(List<string> names);
        string ReverseString(string s);
    }
}
