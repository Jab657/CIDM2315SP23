namespace Homework9;

class Program
{
    static void Main(string[] args)
    {
       Student stu1 = new Student(inputID: 111, inputName: "Alice");
       Student stu2 = new Student(inputID: 222, inputName: "Bob");
       Student stu3 = new Student(inputID: 333, inputName: "Cathy");
       Student stu4 = new Student(inputID: 444, inputName: "David");

       Dictionary<string, double> gradebook = new Dictionary<string, double>(); 
       gradebook.Add("Alice", 4.0);
       gradebook.Add("Bob", 3.6);
       gradebook.Add("Cathy", 2.5);
       gradebook.Add("David", 1.8);

       if(gradebook.ContainsKey("Tom")){
            gradebook.Add("Tom", 3.3);
       }

        double averageGPA = gradebook.Values.Average();

       Console.WriteLine($"Average GPA is: {averageGPA}");

       foreach(Student in){

       }
    }
    class Student {
        private int studentID {get; set;}
        private string studentName {get; set;}
        public void PrintInfo(){
            Console.WriteLine($"Student ID: {studentID}, Student Name: {studentName}");
        }
        public static List<Student> studentList = new List<Student>();
        public Student (int inputID, string inputName) {
            studentID = inputID;
            studentName = inputName;
            studentList.Add(this);
        }
    }
}
