internal class Tasks
{
    public Tasks()
    {
    }

    public void task1(int num1, int num2)
    {
        if (num1 == num2) Console.WriteLine($"Число а = {num1} равно числу b = {num2}");
        else if (num1 > num2) Console.WriteLine($"Число а = {num1} > числа b = {num2}");
        else Console.WriteLine($"Число а = {num1} < числа b = {num2}");
    }
}