using Oop_Concept;


internal class Program
{
    private static void Main(string[] args)
    {
        MathOperation mathoperation = new MathOperation();
        int addvalue = mathoperation.add(9,9);
        double addedvlaue = mathoperation.add(10,10);
        int multiply = mathoperation.Multiplier(5, 5);
        double doub_multiply = mathoperation.Multiplier(7.1, 10);
        Console.WriteLine("Addition of two integer value is : " + addvalue);
        Console.WriteLine("Addition of two double value is : " + addedvlaue);   
        Console.WriteLine("Multiplication of two integer value is : " + multiply);
        Console.WriteLine("Multiplication of two double value is : " + doub_multiply);


        MathOperation1 mathoperation1 = new MathOperation1();
        int addvalue1 = mathoperation1.add(9, 9);
        int subtractvalue = mathoperation1.subtract(9, 9);
        int multiply1 = mathoperation1.Multiplier(5, 5);
        int division = mathoperation1.Division(10, 5);
        Console.WriteLine("Added Value=" + addvalue1);
        Console.WriteLine("Subtracted Value=" + subtractvalue);
        Console.WriteLine("Multiplied Value=" + multiply1);
        Console.WriteLine("Divided Value=" + division);
    }
}