// See https://aka.ms/new-console-template for more information

//Task1
//int power(int num)
//   => num * num;
//Console.WriteLine(power(5));

//Task2


//class Program
//{
//    public static void Main()
//    {
//        decimal pi = 3.14m;
//        Console.WriteLine(Area(3, 4d));
//    }


//    public static int Area(int a, int b)
//    {
//        return a * b;
//    }

//    public static double Area(int r, double pi=3.14) 
//    {
//        return r * r * pi;
//    }
//    public static int Area(int r, int a, int b ,int c)
//    {
//        return ((a+b+c)/2)*r;
//    }

//TASK3


//int total = 0;
//for (int i = 1; total < 11; i++)
//{
//    if (total + i > 11)
//    {
//        break;
//    }
//    total += i;
//    Console.WriteLine(total);
//}

//Task3_1

//int total = 0;
//int i = 0;
//while (total + i < 11) {
//    i++;
//    total +=i;
//    Console.WriteLine(total);
//}


//int[] numbers = { 0, 2, 3, 4, 5, 6 };
//int x = 5;
//func(x,numbers);

//int func(int x,int [] array)
//{
//    int index = 0;
//    foreach (var item in array)
//    {
//        while (index < array.Length)
//        {
//            if (item == x)
//            {
//                return index;
//            }
//            index++;
//        }

//        return x;
//    }
//    return index;
//}

//LabTask_1
//string result=compareFunc(5, 3);
//Console.WriteLine(result);

//string compareFunc (int num1, int num2)
//{
//    if (num1 == num2)
//    {
//        return $"{num1} {num2} - true";
//    }
//    else 
//    {
//        return $"{num1} {num2} - false";
//    }
//}

//LabTask2
//string result=func30(15, 30);
//Console.WriteLine(result);
//string func30 (int num, int num1)
//{
//    if (num == 30 || num1==30 || (num+num1)==30)
//    {
//        return $"true";
//    }
//    else
//    {
//        return $"false";
//    }
//}

//LabTask3

//string Result = divide7(15);
//Console.WriteLine(Result);

//string divide7 (int num1)
//{
//    if ((num1 % 7) == 0 || (num1 % 3) == 0) 
//    {
//        return $"true";
//    }
//    else
//    {
//        return $"false";
//    }
//}

//LabTask4

//int result = nearToHundred(45,16);
//Console.WriteLine(result);

//int nearToHundred(int num1, int num2)
//{
//    int diff1 = 100 - num1;
//    int diff2 = 100 - num2;
//    if (diff1 > diff2)
//    {
//        return num2;
//    }
//    else 
//    {
//        return num1;
//    }
//} 

//LabTask5

//int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

//int result = sumOfOddNum(arr1);
//Console.WriteLine(result);
//int sumOfOddNum(int[] numbers)
//{
//    int sum = 0;
//    foreach (int num in numbers)
//    {
//        if(num%2 == 0)
//        {
//            sum += num;
//        }

//    }
//    return sum;
//}




using System;

// Custom Exception
public class IncorrectPasswordException : Exception
{
    public IncorrectPasswordException(string message) : base(message)
    {
    }
}

// Abstract class
public abstract class Account
{
    public abstract void PasswordChecker(string password);
    public abstract void ShowInfo();
}

// Concrete class (inherits from Account)
public class User : Account
{
    // Properties
    public int Id { get; }
    public string Fullname { get; set; }
    public string Email { get; set; }

    private string _password;

    // Constructor
    public User(int id, string fullname, string email, string password)
    {
        Id = id;
        Fullname = fullname;
        Email = email;

        // Password checking during initialization
        PasswordChecker(password);
    }

    // PasswordChecker method implementation
    public override void PasswordChecker(string password)
    {
        if (password.Length < 8 ||
            !password.Any(char.IsUpper) ||
            !password.Any(char.IsLower) ||
            !password.Any(char.IsDigit))
        {
            throw new IncorrectPasswordException("Password does not meet the requirements.");
        }

        _password = password;
    }

    // ShowInfo method implementation
    public override void ShowInfo()
    {
        Console.WriteLine($"User ID: {Id}");
        Console.WriteLine($"Fullname: {Fullname}");
        Console.WriteLine($"Email: {Email}");
    }
}

class Program
{
    static void Main()
    {
        try
        {
            // Test creating a User object with a valid password
            User user1 = new User(1, "John Doe", "john@example.com", "Password123");

            // Test creating a User object with an invalid password
            // This should throw an IncorrectPasswordException
            User user2 = new User(2, "Jane Doe", "jane@example.com", "pass");
        }
        catch (IncorrectPasswordException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
