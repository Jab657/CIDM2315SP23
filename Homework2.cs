namespace Homework2;

class Program
{
    static void Main(string[] args)
    {
        //First Question
        string letter;
    
        Console.WriteLine("Please input a letter grade.");
        letter = Console.ReadLine();
       
        if(letter == "A"){
            Console.WriteLine("GPA Point: 4");
        }else if (letter == "B"){
            Console.WriteLine("GPA Point: 3");
        }else if (letter == "C") {
            Console.WriteLine("GPA Point: 2");
        }else if (letter == "D") {
            Console.WriteLine("GPA Point: 1");
        }else if (letter == "F") {
            Console.WriteLine("GPA Point: 0");
        } else {
            Console.WriteLine("Wrong Letter Grade");
        }

        //Start of Question 2
        Console.WriteLine("Please enter the 1st number");
        string firstInput = Console.ReadLine();
        Console.WriteLine("Please enter the 2nd number");
        string secondInput = Console.ReadLine();
        Console.WriteLine("Please enter the 3rd number");
        string thirdInput = Console.ReadLine();

        int firstNumber = Convert.ToInt16(firstInput);
        int secondNumber = Convert.ToInt16(secondInput);
        int thirdNumber = Convert.ToInt16(thirdInput);

        if (firstNumber < secondNumber) {
            if(firstNumber < thirdNumber) {
                Console.WriteLine("The smallest number is " + firstNumber);
            }
        }
        if (secondNumber < firstNumber) {
            if(secondNumber < thirdNumber) {
                Console.WriteLine("The smallest number is " + secondNumber);
            }
        }
        if (thirdNumber < firstNumber) {
            if(thirdNumber < secondNumber) {
                Console.WriteLine("The smallest number is " + thirdNumber);
            }
        }

    }
}
