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

int total = 0;
int i = 0;
while (total + i < 11) {
    i++;
    total +=i;
    Console.WriteLine(total);
}
