using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW130319_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>
            {
                "Layehudim", "Hayta", "Ora", "Vesimcha"
            };

            MyProtectedUniqueList BigList = new MyProtectedUniqueList(words, "123 Ani Achashverosh");

            BigList.Add()
        }
    }
}
