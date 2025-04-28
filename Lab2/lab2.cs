// console.writeline("Hello, World")
// console.readkey();   //to hold the terminal where output is given/printed


// string input= console.readline(); //ya bata input lini vayo
// console.writeline("output" + input);
// console.readkey();


string num1= console.readline(); // direct data as string lini
int num2 = console.toint32(console.readline()); // string value lai interger ma conver garni
// using the toint32 with 32 bit

// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class Progress
{
    public static void Main(string[] args)
    {
        int a =5 ,b=9;
        int temp;
        temp =a;
        a=b;
        b=temp;
        Console.WriteLine("a="+a +"\n" +"b=" +b);

    }
}



// finding the largest data
public class Progress
{
    public static void Main(string[] args)
    {
        int a =5 ,b=9, c=12;
        
        if (a>b && a>c){
            Console.WriteLine("A is largest Value:" +  a);
        }
        
        else if (b>a && b>c){
            Console.WriteLine("B is the Largest one:" + b);
        }
        
        else{
            Console.WriteLine("C is the largest value:" + c);
        }

    }
}




using System;
//checking the odd or even with user input

public class Progress
{
    public static void Main(string[] args)
    {
        // int a =5 ,b=9, c=12;
        Console.WriteLine("Enter the number");
        int num1 = int.Parse(Console.ReadLine());
        // int num2 = Console.ReadLine();
        if (num1 % 2 == 0){
            Console.WriteLine("A is Even Value:" +  num1);
        }
        
        else{
            Console.WriteLine("A is odd value:" + num1);
        }

    }
}

// add natural numbar
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter the nth valur fo adding");
        int n = Convert.ToInt32(Console.ReadLine());
        int sum =0 ;

        for (int i = 1; i <= n; i++) {
            sum += i;
            
        }
        Console.WriteLine("the sum of natural number is:" + sum);
        Console.ReadKey();
    }
}

//    //leap year
//Console.WriteLine("Enter the Data for Leap year");
//int year = Convert.ToInt32(Console.ReadLine());

//if (year % 4 == 0 && year % 100 != 0)
//{
//    Console.WriteLine("Its the leap year");
//}
//else if (year % 4 == 0 && year % 100 == 0 && year % 400 == 0)
//{
//    Console.WriteLine("its the leap year");
//}
//else
//{
//    Console.WriteLine("Its not a Leap year");
//}


