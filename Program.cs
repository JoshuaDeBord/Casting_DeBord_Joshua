using System;

namespace Casting_DeBord_Joshua //This tells you that i am big brain
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Could you please input a whole number? "); 
            //prompts the user to input a whole number
            
            int wholeNumber = Convert.ToInt32(Console.ReadLine()); 
            //gives the user a line to input their response
            
            Console.WriteLine($"The whole number that you have inputed is {wholeNumber}"); 
            //Tells thr users what their whole number is
           
            Console.WriteLine($"Do you like video games? (Please type \"True\" or \"False\" to answer the question!"); 
            //asks the user If they like video games
            
            bool isTrue = Convert.ToBoolean(Console.ReadLine()); 
            //makes the {isTrue} variable in the next line in the code to say if the user typed in true or false to the question "Do you like video games?"
            
            Console.WriteLine($"It is {isTrue} that you like video games"); 
            //Tells the user if they inputed true or false
            
        }
    }
}
