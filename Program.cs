using System.ComponentModel.DataAnnotations;
using System.Data.Common;
using System.Numerics;

namespace Homework5;

class Program
{
    static void Main(string[] args)
    {
       //Question 1
    //    Console.WriteLine("Please enter a number: ");
    //    int a = Convert.ToInt16(Console.ReadLine()); 
    //    Console.WriteLine("Please enter another number: ");
    //    int b = Convert.ToInt16(Console.ReadLine());  
    //    Console.WriteLine("Please enter a number: ");
    //    int c = Convert.ToInt16(Console.ReadLine()); 
    //    Console.WriteLine("Please enter another number: ");
    //    int d = Convert.ToInt16(Console.ReadLine());    
       

    //    LargestOne(a, b);
    //    LargestOne(c, d);
    //    LargestOne(max1, max2);

        //Q3

        createAccount();

    }
    // static void LargestOne(int a, int b){

    //     if(a > b) {
    //         Console.WriteLine("a = " + a + ";" + "b = " + b);
    //         Console.WriteLine(a + " is the bigger number");
    //         int max1 = a;
    //     }else {
    //         Console.WriteLine("a = " + a + ";" + "b = " + b);
    //         Console.WriteLine(b + " is the bigger number");
    //         int max1 = b;
    //     }
    // }
    // static void LargestOne(int c, int d){

    //     if(c > d) {
    //         Console.WriteLine("c = " + c + ";" + "d = " + d);
    //         Console.WriteLine(c + " is the bigger number");
    //         int max2 = c;
    //     }else {
    //         Console.WriteLine("c = " + c + ";" + "d = " + d);
    //         Console.WriteLine(d + " is the bigger number");
    //         int max2 = d;
    //     }
    // }

    //Q3 methods
    static bool checkAge(int birth_year){
        int current_Year = 2024;
        int age = current_Year - birth_year;
        
        if(age >= 18) {
            return true;
        } else {
            return false;
        }
    }
    static void createAccount(){
       Console.WriteLine("Please enter a username: ");
       string username = Console.ReadLine(); 
       Console.WriteLine("Please enter a password: ");
       string password = Console.ReadLine(); 
       Console.WriteLine("Please enter the password again: ");
       string passwordTwo = Console.ReadLine(); 
       Console.WriteLine("Please enter a birth year: ");
       int birth_year = Convert.ToInt16(Console.ReadLine()); 

       checkAge(birth_year);

       if (birth_year = true){
        if(password == passwordTwo){
            Console.WriteLine("Account Created");
        }else {
            Console.WriteLine("Incorrect Password");
        }
       }else {
        Console.WriteLine("Account not Created");
       }
    }
}
