namespace Homework4;

class Program
{
    static void Main(string[] args)
    {
        //Call method for Q1
        Console.WriteLine("Please Enter a number: ");
        int numOne = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Please Enter another number: ");
        int numTwo = Convert.ToInt16(Console.ReadLine());

        LargestNum(numOne, numTwo);
        
        //Call method for Q2

        Console.WriteLine("Please Enter a number: ");
        int number = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Please Enter Left or Right: ");
        string direction = (Console.ReadLine());

        Shape(number, direction);
    }

    //method for Q1
    static void LargestNum(int numOne, int numTwo){
        if(numOne > numTwo){
            Console.WriteLine("The larger number is " + numOne);
        }else {
            Console.WriteLine("The larger number is " + numTwo);
        }
    }

    static void Shape(int number, string direction){

    Console.WriteLine("N is " + number + ";" + " Shape is " + direction);

    if (direction == "left") {
        for(int i = 0; i<number; i++){
            for(int k = 0; k < number; k++){
                if(i>=k)
                    Console.Write("*"); 
            }
            Console.WriteLine("");
        }
    } else if(direction == "right"){
        for(int i = 0; i < number; i++){ //row
            for(int k = number; k >= 0; k--){ //column
                if(i<k)
                    Console.Write("*"); 
            }
            Console.WriteLine("");
        }
    }
}
}
