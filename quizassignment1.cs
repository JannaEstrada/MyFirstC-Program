// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        /*Multi Line Comment
        // calculator boi
        int number1 = Convert.ToInt32(Console.ReadLine());
        int number2 = Convert.ToInt32(Console.ReadLine());
        
        int sum = number1 + number2; 
       
        Console.WriteLine(sum);
        */
        
        //This is Single_Line Comment
        
        /*
        int water = 36;
        int degrees = 34;
        string color = "brown";
        
        if (water>degrees){
            Console.WriteLine("HOT HOT HOT HOT HOT!");
            if (color == "brown") {
                Console.WriteLine("EWWW! who dump their coffee in the bathtub?!");
            }
            
        } else if (water == degrees) {
            Console.WriteLine("meh");
        } else {
            Console.WriteLine("brrr");
        }
        */
        
        //Switch Statements
        
        String color = "red";
        
        switch(color){
            case "red":
            Console.WriteLine ("Stop");
            break;
        case "Orange":
        Console.WriteLine ("Ready");
        break;
            case "Green":
        Console.WriteLine ("Go");
        break;
        default: 
        Console.WriteLine("Color is Invalid");
        break;
        }
        
        //codes ...
    }
}