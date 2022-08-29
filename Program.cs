using System;
using System.Linq;
using System.Collections.Generic;

namespace PracticeLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> videoGameNames = new List<string>
            {"Call Of Duty", "Madden", "Skyrim", "The Show", "Forza Horizions" };

            //order by name length

            videoGameNames.OrderBy(x => x.Length).ToList().ForEach(x => Console.WriteLine(x));

            
        }
    }
}

