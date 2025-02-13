namespace Homework4;
using System;

class Program {
    static void Main(string[] args) {
       

        Console.WriteLine("The largest number is: " + Comp(3,5));

        Ladder("left", 7);
        Ladder("right", 7);


    }
/*
        //////////////////// Method 1
*/
                //Method takes two numbers and returns largest
    static int Comp(int a, int b) {

        Console.WriteLine("a = " + a + "; b = " + b);
        if(a>b) return a;
        else return b;
    }

/*
            /////////////// Method 2
*/

            // Method takes a string direction and number 
            // Then creates a stairs with stars in the console
    static void Ladder(string tem, int a) {

        Console.WriteLine("N is: " + a + "; Shape is " + tem);

        // ladder facing left    
        if(tem == "left") {
            for(int i = 0; i < a; i++) {
                for(int j = 0; j < i+1; j++)      
                    Console.Write("*");
                Console.Write("\n");
            }   
            return;
        }

        // ladder facing right
        else if(tem == "right") {
            for(int i = 1; i <= a; i++) {
                for(int j = 0; j < a - i; j++) Console.Write(" ");
            
                for(int k = 0; k < i; k++) Console.Write("*");
                    Console.Write("\n");
            }
            return;
        }
        else {
            Console.WriteLine("you screwed up.");
            return;
        }

    }


}