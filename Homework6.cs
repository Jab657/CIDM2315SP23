using System.Runtime.CompilerServices;

namespace Homework6;

class Program
{
    static void Main(string[] args)
    {
        //Answer for Q1 and Q2
        //Adding the 1st professor
        Professor p1 = new Professor();
        p1.profName = "Alice";
        p1.classTeach = "Java";
        p1.SetSalary(9000);
        p1.PrintProfInfo();

        //Adding the second professor
        Professor p2 = new Professor();
        p2.profName = "Bob";
        p2.classTeach = "Math";
        p2.SetSalary(8000);
        p2.PrintProfInfo();

        //Adding the 1st student
        Student s1 = new Student();
        s1.studentName = "Alice";
        s1.classEnroll = "Java";
        s1.SetGrade(90);
        s1.PrintStudInfo();

        //Adding the second student
        Student s2 = new Student();
        s2.studentName = "Tom";
        s2.classEnroll = "Math";
        s2.SetGrade(80);
        s2.PrintStudInfo();

        //Calculating the difference in salary
        double totalSal = p1.GetSalary() - p2.GetSalary();
        Console.WriteLine("The salary difference Alice and Bob is: " + totalSal);

        //Finding the sum of the 2 students Grades
        double totalGrade = s1.GetGrade() + s2.GetGrade();
        Console.WriteLine("The total grade of Lisa and Tom is: " + totalGrade);
    }
}

class Professor 
{
    //Code for Professor
    public string profName;
    public string classTeach;
    private double salary = 0;

    public void PrintProfInfo(){
        //Prints the Professors info
        Console.WriteLine($"Professor {profName} teaches {classTeach}, and has a salary of {salary}");
    }
    public void SetSalary(double salary_amount){
        salary = salary_amount;
    }
    public double GetSalary(){
        return salary;
    }

}
class Student
{
    //Code For the student
    public string studentName;
    public string classEnroll;
    private double studentGrade;

    public void PrintStudInfo(){
        Console.WriteLine($"Students name is {studentName} is enrolled in {classEnroll}, and has a grade of {studentGrade}");
    }

    public void SetGrade(double newGrade){
        studentGrade = newGrade;
    }
    public double GetGrade(){
        return studentGrade;
    }


}