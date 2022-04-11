// See https://aka.ms/new-console-template for more information
public class Program
{
    public static void Main()
    {
        
        
        Console.WriteLine("Enter the length of the room.");
        double length = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the width of the room");
        double width = double.Parse(Console.ReadLine());
        Console.WriteLine("What is the height of your room?");
        double height = double.Parse(Console.ReadLine());
        int area = (int)(length * width);
        Console.WriteLine($"Your room is " +   area  +  " square feet");
        Console.WriteLine();
        int perimeter = (int)((length + width) * 2);
        Console.WriteLine($"your perimeter is " + perimeter + "feet");

        int volume = (int)(length * width * height);
        Console.WriteLine($"The volume of your room is " + volume);

        double surface = 2 *((width * height) + (height * length) + (height * width));

        Console.WriteLine();
        Console.WriteLine("Then your room has a surface area of " + surface + " square feet");

        { if (area <= 250)
                Console.WriteLine("This is a small room");
            if (area >= 251 && area <= 650) 
            Console.WriteLine("This is a medium room");
            else  Console.WriteLine("This is a big ol room");
                }
        

    }
        
                
}
