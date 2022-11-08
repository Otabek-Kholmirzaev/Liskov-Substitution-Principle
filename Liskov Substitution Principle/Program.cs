using System.Collections.Concurrent;
using System.Globalization;

public class Program
{
    public static void Main()
    {
        var nums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        SumClass sumClass1 = new AllSum(nums);
        Console.WriteLine(sumClass1.GetSum());
        SumClass sumClass2 = new EvenSum(nums);
        Console.WriteLine(sumClass2.GetSum());
    }
}

public abstract class SumClass
{
    protected readonly int[] numbers;
    public SumClass(int[] nums)
    {
        numbers = nums;
    }

    public abstract int GetSum();
} 

public class AllSum : SumClass
{
    public AllSum(int[] nums) : base(nums)
    {

    }

    public override int GetSum()
    {
        return numbers.Sum();
    }
}

public class EvenSum : SumClass
{
    public EvenSum(int[] nums) : base(nums)
    {

    }

    public override int GetSum()
    {
        return numbers.Where(x => x % 2 == 0).Sum();
    }
}