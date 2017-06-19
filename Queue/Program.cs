using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Specialized;
using System.Globalization;

namespace SortingCollection
{
    class Program
    {
        static void Main(string[] args)
        {

            QueueThis();
            StackThis();
            LookupThis();
            DictionaryThis();
            RandomThis();
        }

        public static void QueueThis()
        {
            Console.WriteLine("Queue:");
            Queue queue = new Queue();
            queue.Enqueue("First");
            queue.Enqueue("Second");
            queue.Enqueue("Third");
            queue.Enqueue("Fourth");

            while (queue.Count > 0)
            {
                object obj = queue.Dequeue();

                Console.WriteLine("From Queue: {0}", obj);
            }
        }


        public static void StackThis()
        {

            Console.WriteLine("Stack:");
            Stack stack = new Stack();
            stack.Push("First");
            stack.Push("Second");
            stack.Push("Third");
            stack.Push("Fourth");

            while (stack.Count > 0)
            {
                object obj = stack.Pop();
                Console.WriteLine("From Stack: {0}", obj);
            }

        }

        public static void LookupThis()
        {
            Console.WriteLine("Lookup: ");   
            Hashtable lookup = new Hashtable();
            lookup["0"] = "Zero";
            lookup["1"] = "One";
            lookup["2"] = "Two";
            lookup["3"] = "Three";
            lookup["4"] = "Four";
            lookup["5"] = "Five";
            lookup["6"] = "Six";
            lookup["7"] = "Seven";
            lookup["8"] = "Eight";
            lookup["9"] = "Nine";

            string ourNumber = "888-555-1212";

            foreach (char c in ourNumber)
            {
                string digit = c.ToString();
                if (lookup.ContainsKey(digit))
                {
                    Console.WriteLine(lookup[digit]);
                }
            }
        }

        public static void DictionaryThis()
        {
            Console.WriteLine("Dictionary:");
            // Make the dictionary case insensitive 
            ListDictionary list = new ListDictionary(new CaseInsensitiveComparer(CultureInfo.InvariantCulture));

            // Add some items
            list["Estados Unidos"] = "United States of America";
            list["Canadá"] = "Canada";
            list["España"] = "Spain";

            // Show the results 
            Console.WriteLine(list["españa"]);
            Console.WriteLine(list["CANADÁ"]);
        }

        public static void RandomThis()
        {
            Console.WriteLine("dictionary");   
            Dictionary<int,String> countryLookup = new Dictionary<int, string>();

            countryLookup[44] = "United Kingdom";
            countryLookup[33] = "France";
            countryLookup[31] = "Netherlands";
            countryLookup[55] = "Brazil";

            Console.WriteLine("The 33 Code is for: {0}", countryLookup[33]);

            foreach (KeyValuePair<int,String> item in countryLookup)
            {
                int code = item.Key;
                string country = item.Value;
                Console.WriteLine("Code {0} = {1}", code, country);
            }

        }
    }
}
