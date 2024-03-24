using System;

// Q1
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello World, I am student of Bsc. CSIT");
    }
}
//Uncomment the program to run 
// Q2
// public class Program
// {
//     public static void Main(string[] args)
//     {
//         Console.WriteLine("Enter a year :");
//         int year = Convert.ToInt32(Console.ReadLine());
//         if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
//         {
//             Console.WriteLine("{0} is a leap year", year);
//             
//         }
//         else
//         {
//             Console.WriteLine("{0} is not a leap year. ", year);
//         }
//     }
// }
// Q3
// namespace program3
// {
//     internal class Program
//     {
//         public static void Main(string[] args)
//         {
//             Console.Write("Enter your age :");
//             int age = Convert.ToInt32(Console.ReadLine());
//             if (age >= 18)
//             {
//                 Console.WriteLine("You can get citizenship and vote");
//
//             }
//             else if (age >= 16)
//             {
//                 Console.WriteLine("You can get citizenship but cannot vote");
//
//             }
//             else
//                 Console.WriteLine("Person cannot get citizenship");
//             {
//             }
//         }
//     }
// }

//Q4
//
// class NumberOperations
// {
//     public int Factorial(int num)
//     {
//         if (num == 0)
//             return 1;
//         else
//             return num * Factorial(num - 1);
//     }
//
//     public int SumOfNaruralNum(int n)
//     {
//         int sum = 0;
//         for (int i = 1; i <= n; i++)
//         {
//             sum += i;
//         }
//         return sum;
//     }
//
//     public int ReverseNumber(int num)
//     {
//         int reversedNum = 0;
//         while (num > 0)
//         {
//             int remainder = num % 10;
//             reversedNum = (reversedNum * 10) + remainder;
//             num /= 10;
//         }
//         return reversedNum;
//     }
// }
//
// class Program
// {
//     static void Main(string[] args)
//     {
//         NumberOperations operations = new NumberOperations();
//
//         
//         int n = 5;
//         int sumOfFactorial = operations.SumOfNaruralNum(n);
//         Console.WriteLine("Sum of natural number's up to " + n + " : " + sumOfFactorial);
//
//         int factnum = 4;
//         Console.WriteLine("Factorial of " + n + " : " + factnum);
//         
//         int numberToReverse = 12345;
//         int reversedNumber = operations.ReverseNumber(numberToReverse);
//         Console.WriteLine($"Reversed of {numberToReverse} : " + reversedNumber);
//
//     }
// }

//q5
//
//
// public class Program {
//     public static void Main(string[] args) {
//         Program obj = new Program();
//         int n = Convert.ToInt32(Console.ReadLine());
//         obj.Sum(n);
//     }
//
//     public void Sum(int n) {
//         int evenSum = 0, oddSum = 0, rem;
//
//         while (n != 0) {
//             rem = n % 10;
//             if (rem % 2 == 0) {
//                 evenSum = evenSum + rem;
//             } else {
//                 oddSum = oddSum + rem;
//             }
//             n /= 10; // Update n to move to the next digit
//         }
//
//         Console.WriteLine("Even sum: " + evenSum); // Corrected variable names
//         Console.WriteLine("Odd sum: " + oddSum); // Corrected variable names
//     }
// }
//


// q6

//
// public class ArrayOperations {
//     public void Smallest(int[] arr) {
//         int smallest = arr[0];
//         for (int i = 1; i < arr.Length; i++) {
//             if (smallest > arr[i]) {
//                 smallest = arr[i];
//             }
//         }
//         Console.WriteLine("Smallest: " + smallest);
//     }
//
//     public void SearchElement(int[] arr, int e) {
//         int found = 0;
//         for (int i = 0; i < arr.Length; i++) {
//             if (e == arr[i]) {
//                 found = 1;
//                 break;
//             }
//         }
//         if (found == 1) {
//             Console.WriteLine("Element found");
//         } else {
//             Console.WriteLine("Element not found");
//         }
//     }
//
//     public static void Main(string[] args) {
//         int[] arr = { 10, 12, 5, 6, 7 }; // Corrected array initialization
//         ArrayOperations objArr = new ArrayOperations(); // Renamed the object and class
//         objArr.Smallest(arr); // Corrected method invocation
//         int searchElement = 6;
//         objArr.SearchElement(arr, searchElement); // Corrected method invocation
//     }
// }

// Q7
// public class Vehicle {
//     private double distanceTravelled;
//     private double fuelUsed;
//     public int NumSeats { get; set; }
//     protected string steerAction;
//
//     public Vehicle() {
//         NumSeats = 0;
//         steerAction = " ";
//     }
//
//     public void Travel(double distance, double fuel) {
//         distanceTravelled += distance;
//         fuelUsed += fuel;
//     }
//
//     public double KmPerLiter() {
//         if (fuelUsed == 0) {
//             return 0;
//         }
//         return distanceTravelled / fuelUsed;
//     }
//
//     public double FuelPer100Km() {
//         if (distanceTravelled == 0) {
//             return 0;
//         }
//         return (fuelUsed / distanceTravelled) * 100;
//     }
//
//     public void Steering(string direction) {
//         steerAction = direction;
//     }
//
//     public static void Main(string[] args) {
//         Vehicle vehicle = new Vehicle();
//         vehicle.Travel(100, 10); // Travel 100 km using 10 liters of fuel
//         Console.WriteLine($"Kilometers per liter: {vehicle.KmPerLiter()}"); // Output the fuel efficiency
//         Console.WriteLine($"Fuel per 100 km: {vehicle.FuelPer100Km()} liters"); // Output the fuel consumption per 100 km
//     }
// }

// Q8
//
// public class Program {
//     public void Compute(int a, int b) {
//         try {
//             int div = a / b;
//             Console.WriteLine("Division is: " + div);
//         }
//         catch (DivideByZeroException e) {
//             Console.WriteLine(e.Message);
//         }
//         catch (Exception e) {
//             Console.WriteLine("Base Exception");
//         }
//     }
//
//     public static void Main(string[] args) {
//         Program p = new Program();
//         p.Compute(10, 0);
//     }
// }

// Q9


// public class Student<T> {
//     public T Data;
//     
//     public Student(T data) {
//         this.Data = data;
//         Console.WriteLine("Data: " + data);
//     }
// }
//
// public class Test {
//     public static void Main(string[] args) {
//         Student<string> s = new Student<string>("sita");
//         Student<int> s1 = new Student<int>(1);
//     }
// }


// 10:
//
// using System.Collections.Generic;
//
// public class Student {
//     public int Age { get; set; }
//     public string GradeLevel { get; set; }
//     public string Name { get; set; }
//
//     public Student(string name, int age, string gradeLevel) {
//         Name = name;
//         Age = age;
//         GradeLevel = gradeLevel;
//     }
//
//     public void Display() {
//         Console.WriteLine("Name: " + Name);
//         Console.WriteLine("Age: " + Age);
//         Console.WriteLine("Grade Level: " + GradeLevel);
//     }
// }
//
// class Program {
//     public static void Main(string[] args) {
//         List<Student> students = new List<Student>();
//
//         while (true) {
//             Console.WriteLine("1. Add student");
//             Console.WriteLine("2. Display all students");
//             Console.WriteLine("3. Exit");
//             Console.WriteLine("Enter choice:");
//             string choice = Console.ReadLine();
//
//             switch (choice) {
//                 case "1":
//                     Console.WriteLine("Enter name:");
//                     string name = Console.ReadLine();
//                     Console.WriteLine("Enter age:");
//                     int age = Convert.ToInt32(Console.ReadLine());
//                     Console.WriteLine("Enter grade level:");
//                     string gradeLevel = Console.ReadLine();
//                     Student student = new Student(name, age, gradeLevel);
//                     students.Add(student);
//                     Console.WriteLine("Student added successfully.");
//                     break;
//                 case "2":
//                     if (students.Count == 0) {
//                         Console.WriteLine("No students added yet.");
//                     } else {
//                         Console.WriteLine("Student List:");
//                         foreach (Student s in students) {
//                             s.Display();
//                             Console.WriteLine();
//                         }
//                     }
//                     break;
//                 case "3":
//                     Console.WriteLine("Goodbye!");
//                     return;
//                 default:
//                     Console.WriteLine("Invalid choice, please try again.");
//                     break;
//             }
//             Console.WriteLine();
//         }
//     }
// }

// Q11

// using System.IO;
//
// namespace fileHandlingExample {
//     class Program {
//         public static void Main(string[] args) {
//             string fileName = "example.txt";
//             WriteToFile(fileName, "Hello World!");
//             if (FileExists(fileName)) {
//                 Console.WriteLine("File Exists");
//             } else {
//                 Console.WriteLine("File doesn't Exist");
//             }
//             string content = ReadFromFile(fileName);
//             Console.WriteLine($"File content: {content}");
//         }
//
//         static void WriteToFile(string fileName, string content) {
//             using (StreamWriter writer = File.CreateText(fileName)) {
//                 writer.WriteLine(content);
//             }
//             Console.WriteLine($"Content written to {fileName}");
//         }
//
//         static bool FileExists(string fileName) {
//             return File.Exists(fileName);
//         }
//
//         static string ReadFromFile(string fileName) {
//             using (StreamReader reader = File.OpenText(fileName)) {
//                 return reader.ReadToEnd();
//             }
//         }
//     }
// }

// Q12
// using System.Collections.Generic;
// using System.Linq;
//
// namespace SimpleLINQExample {
//     class Program {
//         public static void Main(string[] args) {
//             List<string> MyList = new List<string> { "Aryan", "apple", "banana", "cat", "dog" };
//             Console.WriteLine("Strings:");
//             foreach (string names in MyList) {
//                 Console.Write(names+" ");
//             }
//             string searchText = "an";
//             Console.WriteLine($"\n strings containing: '{searchText}':");
//             var matchingStrings = MyList.Where(name => name.Contains(searchText));
//             foreach (string names in matchingStrings) {
//                 Console.Write(names+" ");
//             }
//         }
//     }
// }

