using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace practice1
{
    class DupString
    {

        public void duplicateString()
        {
            string[] source = new string[]{"AHello", "India", "AHello", "Hello", "India", "hi"};
            var dups = from s in source
                       group s by s into g
                       let count = g.Count()
                       orderby source descending
                       where count > 1
                       select new { value = g.Key, Count = count };

            string newsource = "abnbnsbnbna,jhjhjh:hgyg.hjhj.hjhj,jhjhjh";
            string[] newar1 = newsource.Split(new char[] { ',', ';', ':', '.' }, StringSplitOptions.RemoveEmptyEntries);
            var dups1 = from s in newar1
                       group s by s into g
                       let count = g.Count()
                       orderby source descending
                       where count > 1
                       select new { value = g.Key, Count = count };

            foreach ( var i in dups)
            {
                Console.WriteLine("word {0} is occurred {1} times", i.value, i.Count);
                Console.ReadKey();
            }

            foreach (var i in dups1)
            {
                Console.WriteLine("charseq {0} is occurred {1} times", i.value, i.Count);
                Console.ReadKey();
            }

            // Check how many files exist with given extension
            string[] arr = { "aaa.txt", "bbb.TXT", "xyz.abc.pdf", "aaaa.PDF", "abc.xml", "ccc.txt", "zzz.txt" };
            var egrp = from x in arr.Select(file => Path.GetExtension(file).TrimStart('.').ToLower())
                       group x by x into g
                       select new { Count = g.Count(), Extension = g.Key };
                     

            foreach (var v in egrp)
                Console.WriteLine("{0} File(s) with {1} Extension ", v.Count, v.Extension);
            Console.ReadLine();

        }
    }
}
