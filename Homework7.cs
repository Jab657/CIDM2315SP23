using System.Data.Common;
using System.Security.Cryptography;

namespace Homework7;

class Program
{
    static void Main(string[] args)
    {

        //Answer to question 1 
        //Sets new customer Alice
        Customer Alice = new Customer(Cus_ID:110, Cus_Age:28, Cus_Name:"Alice");
        //Prints Alices info
        Alice.PrintCusInfo();
        //Sets new customer Bob
        Customer Bob = new Customer(Cus_ID:111, Cus_Age:30, Cus_Name:"Bob");
        //Prints Bobs info
        Bob.PrintCusInfo();
        //Changes Alices ID to 210 
        Alice.ChangeID(210);
        //Changes Bob's ID
        Bob.ChangeID(211);
        //Reprints the new info
        Alice.PrintCusInfo();
        Bob.PrintCusInfo();
        //Comapares Bob and Alices age
        Bob.CompareAge(Alice);
    }
}
//Code for customer class
class Customer {
    private int Cus_ID {get;set;} = 0;
    public string Cus_Name {get;set;} = string.Empty;
    public int Cus_Age {get;set;} = 0;
    public Customer(int Cus_ID, string Cus_Name, int Cus_Age){
        this.Cus_ID = Cus_ID;
        this.Cus_Name = Cus_Name;
        this.Cus_Age = Cus_Age;
    }
    public void ChangeID(int new_ID){
        Cus_ID = new_ID;
    }
    public void PrintCusInfo(){
        //Sets the info to be printed
        Console.WriteLine($"Customer: {Cus_ID}, Name: {Cus_Name}, Age: {Cus_Age}");
    }
    public void CompareAge(Customer objCustomer){
        if(this.Cus_Age > objCustomer.Cus_Age){
            Console.WriteLine($"Customer {this.Cus_Name} is older");
        }else {
            Console.WriteLine($"Customer {objCustomer.Cus_Name} is older");
        }
    }

}
