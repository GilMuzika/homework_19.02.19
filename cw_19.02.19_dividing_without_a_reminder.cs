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
           Console.WriteLine("Please enter two numbers:");
           
           int n1;
           EnterNumber1:
           if(Int32.TryParse(Console.ReadLine(), out n1)) {Console.WriteLine("Good job! Your first number is "+n1+". Now lets enter the second:");} else {Console.WriteLine("Enter only numbers!\nNow please try again:"); goto EnterNumber1;}
           
           int n2;
           EnterNumber2:
           if(Int32.TryParse(Console.ReadLine(), out n2)) {Console.WriteLine("Your second number is "+n2+". Congratulations! You just had enter two numbers! Now lets check if each of them can ve divided by the other without a reminder. \n");} else {Console.WriteLine("Enter only numbers!\nNow please try again:"); goto EnterNumber2;}
           
           
           if(IfCanDivideWithoutAReminder(n1, n2)) {Console.WriteLine("\n Your first number "+n1+" CAN be divided by your second number "+n2+" without a reminder. \n");}
           else {Console.WriteLine("\n Your first number "+n1+" canNOT be divided by your second number "+n2+" without a reminder. \n");}
           
           Console.WriteLine("Now lets try vise versa!\n");
           
           if(IfCanDivideWithoutAReminder(n2, n1)) {Console.WriteLine("\n Your second number "+n2+" CAN be divided by your first number "+n1+" without a reminder. \n");}
           else {Console.WriteLine("\n Your second number "+n2+" canNOT be divided by your first number "+n1+" without a reminder. \n");}
           
        }
        
        
        static bool IfCanDivideWithoutAReminder(int n1, int n2)
        {
            if(n1 % n2 == 0) {return true;}
            else {return false;}
        }
    }
}