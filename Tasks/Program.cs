using System.Threading.Tasks;

internal class Program
{
    private static int number;
    private static void Main(string[] args)
    {
        Tasks tasks = new Tasks();
        Console.Write("Введите номер задачи от 1 до 23: ");
        number = Convert.ToInt32(Console.ReadLine());
        switch (number)
        {
            case 1:
                tasks.task1();
                break;
            case 2:
                tasks.task2();
                break;
            case 3:
                tasks.task3();
                break;
            case 4:
                tasks.task4();
                break;
            case 5:
                tasks.task5();
                break;
            case 6:
                tasks.task6();
                break;
            case 7:
                tasks.task7();
                break;
            case 8:
                tasks.task8();
                break;
            case 9:
                tasks.task9();
                break;
            case 10:
                tasks.task10();
                break;
            case 11:
                tasks.task11();
                break;
            case 12:
                tasks.task12();
                break;
            case 13:
                tasks.task13();
                break;
            case 14:
                tasks.task14();
                break;
            case 15:
                tasks.task15();
                break;
            case 16:
                tasks.task16();
                break;
            case 17:
                tasks.task17();
                break;
            case 18:
                tasks.task18();
                break;
            case 19:
                tasks.task19();
                break;
            case 20:
                tasks.task20();
                break;
            case 21:
                tasks.task21();
                break;
            case 22:
                tasks.task22();
                break;
            case 23:
                tasks.task23();
                break;
            default:
                break;
        }
        tasks.task23();
    }
}