using System.Reflection.Metadata;

namespace Homework8;

class Program
{
    static void Main(string[] args)
    {
        Customer cus1 = new Customer(customerName: "Alice", customerAge: 33, customerCity:"Amarillo", customerCredit: 198.5);
        Customer cus2 = new Customer(customerName: "Bob", customerAge: 23, customerCity:"Amarillo", customerCredit: 226);
        Customer cus3 = new Customer(customerName: "Cathy", customerAge: 45, customerCity:"Amarillo", customerCredit: 89.0);
        Customer cus4 = new Customer(customerName: "David", customerAge: 58, customerCity:"Amarillo", customerCredit: 198.5);
        Customer cus5 = new Customer(customerName: "Jack", customerAge: 28, customerCity:"Canyon", customerCredit: 561.6);
        Customer cus6 = new Customer(customerName: "Tom", customerAge: 36, customerCity:"Canyon", customerCredit: 98.4);
        Customer cus7 = new Customer(customerName: "Tony", customerAge: 24, customerCity:"Canyon", customerCredit: 18.5);
        Customer cus8= new Customer(customerName: "Sam", customerAge: 35, customerCity:"Canyon", customerCredit: 228.3);

        Customer[] customer_list = {cus1, cus2, cus3, cus4, cus5, cus6, cus7, cus8};

        //call Q1 method
        TotalCredits(customer_list);
        //Call Q2 method
        AmarilloAverageAge(customer_list);
        //Call Q3 method
        CanyonAge(customer_list);
    }

    public static void TotalCredits(Customer[] customer_list){
        double totalCredit = 0;

        foreach(Customer customerCredit in customer_list){
            totalCredit += customerCredit.customerCredit;
        }
        Console.WriteLine($"Q1: The total credit of all the customers is: {totalCredit}");
    }
    public static void AmarilloAverageAge(Customer[] customer_list){
        double amarilloAge = 0;
        double averageAge = 0;
        int amarilloCustomers = 0;

        foreach(Customer customerAge in customer_list){
            if(customerAge.customerCity == "Amarillo") {
                amarilloAge += customerAge.customerAge;
                amarilloCustomers++;
            }
            if(amarilloCustomers > 0) {
                averageAge = amarilloAge/amarilloCustomers;
            }
        }
        Console.WriteLine($"Q2: The average age of customers in Amarillo is: {averageAge}");
    }
    public static void CanyonAge(Customer[] customer_list) {
        string canyonName = "";
        // int canyonCustomerAge = 0;
        foreach(Customer customerAge in customer_list){
            foreach(Customer customerCity in customer_list){
                if (customerAge.customerAge > 30 && customerCity.customerCity == "Canyon") {
                    canyonName = customerAge.customerName;
                    // canyonCustomerAge++;
                    }
                }
            }
            Console.WriteLine($"Customers who live in Canyon and over 30 years old: {canyonName}, {canyonName}");
        }
    }

class Customer {
    public string customerName {get;set;} = string.Empty;
    public int customerAge {get;set;} = 0;
    public string customerCity {get;set;} = string.Empty;
    public double customerCredit {get;set;} = 0;

    public Customer(String customerName, int customerAge, string customerCity, double customerCredit){
        this.customerName = customerName;
        this.customerAge = customerAge;
        this.customerCity = customerCity;
        this.customerCredit = customerCredit;
    }
}
