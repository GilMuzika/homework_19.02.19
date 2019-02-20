using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CSharp_Shell
{

    public static class Program 
    {
        public static void Main(string[] args) 
        {
            
            Console.WriteLine("Please enter some numbers. \nIf you desided that enought and want to stop \njust enter a negative one.\n");
            
            
            
            List<Int32> ls = new List<Int32>();
            int n;
            
            
            do {
                EnterNumber:
                if(Int32.TryParse(Console.ReadLine(), out n)) {ls.Add(n); Console.Beep(400, 20);}
                else {Console.WriteLine("Please enter only numbers. \nNow lets try enter a number again.\n"); goto EnterNumber;} 
                }
            while (n > 0);
            
            ls.RemoveAt(ls.Count-1); 
        
            
            
            Console.WriteLine("\n\n----------\n");
            Console.WriteLine("Now you had entered some numbers. The sum of those number is "+ls.Sum()+"\n");
            Console.WriteLine("Their average is "+ls.Average());
            
            
            
        }
    }
}