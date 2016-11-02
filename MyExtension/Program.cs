using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MyExtension
{
    static class Program
    {
        static void Main(string[] args)
        {
            ArrayList monArrayList = new ArrayList();
            Console.WriteLine(monArrayList.filtre((a) => a % 7 == 0));
            

            ArrayList capitales = new ArrayList() { "Paris", "Madrid", "Londres" };
            filtre2(capitales, (e => e.StartsWith("P"))); 
            foreach(string capital in capitales)
            {
                Console.WriteLine(capital);
            }

            ArrayList capitales2 = new ArrayList() { "Paris", "Madrid", "Londres" };
            filtre2(capitales2, (e => e.Contains("a")));
            foreach (string capital in capitales2)
            {
                Console.WriteLine(capital);
            }
            Console.ReadLine();
        }

        public static string filtre(this ArrayList arr, Func<int, bool> a)
        {
            int i = 0;
            for (i = arr.Count - 1; i >= 0; i--)
            {
                if (!a((int)arr[i]))
                {
                    arr.RemoveAt(i);
                }
            }

            return arr.ToString(); 
        }

        public static void filtre2(ArrayList monTableau, Func<string, bool> expression)
        {
            int i = 0;
            for (i = monTableau.Count - 1; i >= 0; i--)
            {
                if (!expression((string)monTableau[i]))
                {
                    monTableau.RemoveAt(i);
                }
            }
        }

        public static void filtre3(this ArrayList arr, Func<object, bool> a)
        {
            int i = 0;
            for (i = arr.Count - 1; i >= 0; i--)
            {
                if (!a(arr[i]))
                {
                    arr.RemoveAt(i);
                }
            }
        }

        public static void filtre4(ArrayList monTableau, Func<object, bool> expression)
        {
            int i = 0;
            for (i = monTableau.Count - 1; i >= 0; i--)
            {
                if (!expression(monTableau[i]))
                {
                    monTableau.RemoveAt(i);
                }
            }
        }


    }
}
