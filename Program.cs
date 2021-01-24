using System;
using System.Collections.Generic;
using System.Linq;

namespace DictionaryKavram
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> CustomerNameCustomerNumber = new Dictionary<string, int>();
          
            CustomerNameCustomerNumber.Add("Tuğba", 1995);
            CustomerNameCustomerNumber.Add("Tolgay", 1999);
            CustomerNameCustomerNumber.Add("Zeyt", 1997);
            CustomerNameCustomerNumber.Add("İdil", 1998);
            CustomerNameCustomerNumber.Add("Sefa", 2000);

            foreach (var DegerOku in CustomerNameCustomerNumber)
            {
                Console.WriteLine(DegerOku);
            }
            Console.ReadLine();
        }
    }
}