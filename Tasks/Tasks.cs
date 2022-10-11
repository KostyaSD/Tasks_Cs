using System;

internal class Tasks
{
    private static int num1;
    private static int num2;
    //private static int num3;

    public Tasks()
    {

    }

    /*Задача 1: Напишите программу, которая на вход принимает два числа и проверяет,
                является ли первое число квадратом второго

                a = 5; b = 25 -> Да
                a = 2 b = 10 -> Нет
                a = 9 b = -3 -> Нет
                a = -3 b = 9 -> Да */

    public void task1()
    {
        Console.WriteLine("Вы выбрали Задачу № 1\n\n" +
                          "Условие: Напишите программу, которая на вход принимает два числа и проверяет,\n" +
                          "является ли первое число квадратом второго.\n");
        Console.Write("Введите число a: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число b: ");
        num2 = Convert.ToInt32(Console.ReadLine());
        if (num2 == (num1 * num1)) Console.WriteLine("Ответ: Да");
        else Console.WriteLine("Ответ: Нет");
    }
    /*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
                какое число большее, а какое меньшее.

                a = 5; b = 7 -> max = 7
                a = 2 b = 10 -> max = 10
                a = -9 b = -3 -> max = -3*/

    public void task2()
    {
        Console.WriteLine("Вы выбрали Задачу № 2\n\n" +
                          "Условие: Напишите программу, которая на вход принимает два числа и выдаёт,\n" +
                          "какое число большее, а какое меньшее.\n");
        Console.Write("Введите число a: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число b: ");
        num2 = Convert.ToInt32(Console.ReadLine());
        if (num1 == num2) Console.WriteLine($"\nОтвет: Числа a и b равны");
        else if (num1 > num2) Console.WriteLine($"\nОтвет: Число а > числа b\n" +
                                                $"максимальное число: max = {num1}");
        else Console.WriteLine($"\nОтвет: Число а < числа b\n" +
                                                $"максимальное число: max = {num2}");
        return;
    }

    /*Задача 3: Напишите программу, которая будет выдавать название
                дня недели по заданномуномеру.

                3 -> max = Среда
                5 -> max = Пятница*/

    public void task3()
    {
        Console.WriteLine("Вы выбрали Задачу № 3\n\n" +
                          "Условие: Напишите программу, которая будет выдавать название\n" +
                          "дня недели по заданному номеру.\n");
        Console.Write("Введите номер дня недели: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        switch (num1)
        {
            case 1:
                Console.WriteLine("Ответ: Понедельник");
                break;
            case 2:
                Console.WriteLine("Ответ: Вторник");
                break;
            case 3:
                Console.WriteLine("Ответ: Среда");
                break;
            case 4:
                Console.WriteLine("Ответ: Четверг");
                break;
            case 5:
                Console.WriteLine("Ответ: Пятница");
                break;
            case 6:
                Console.WriteLine("Ответ: Суббота");
                break;
            case 7:
                Console.WriteLine("Ответ: Воскресенье");
                break;
            default:
                Console.WriteLine("Такого дня недели нет!");
                break;
        }
    }

    /*Задача 4: Напишите программу, которая принимает на вход три числа и
                выдаёт максимальное из этих чисел.

                2, 3, 7 -> 7
                44 5 78 -> 78
                22 3 9 -> 22*/

    public void task4()
    {
        Console.WriteLine("Вы выбрали Задачу № 4\n\n" +
                          "Условие: Напишите программу, которая принимает на вход три числа и\n" +
                          "выдаёт максимальное из этих чисел.\n");
        Console.Write("Введите первое число: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите второе число: ");
        num2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите третье число: ");
        int num3 = Convert.ToInt32(Console.ReadLine());
        int max = num1;
        if (num2 > max) max = num2;
        else if (num3 > max) max = num3;
        Console.Write($"Ответ: максимально число: {max}");
    }

    /*Задача 5: Напишите программу, которая на вход принимает одно число (N),
                а на выходе показывает все целые числа в промежутке от -N до N.

                4 -> "-4 -3 -2 -1 0 1 2 3 4"
                2 -> "-2 -1 0 1 2"*/

    public void task5()
    {
        Console.WriteLine("Вы выбрали Задачу № 5\n\n" +
                          "Условие: Напишите программу, которая на вход принимает одно число (N),\n" +
                          "а на выходе показывает все целые числа в промежутке от -N до N.\n");
        Console.Write("Введите число N: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ответ: ");
        num1 = Math.Abs(num1);
        for (int i = -num1; i <= num1; i++)
        {
            if (num1 == 0 || num1 == 1)
            {
                Console.Write($"Из целых чисел осталься только {0}");
                break;
            }
            else if (i % 2 == 0)
            {
                if (i != num1 && i != num1 - 1)
                {
                    Console.Write($"{i}, ");
                } else Console.Write($"{i}.");
            } 
        }
    }

    /*Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
                является ли число чётным(делится ли оно на два без остатка).

                4 -> да
                -3 -> нет
                7 -> нет*/

    public void task6()
    {
        Console.WriteLine("Вы выбрали Задачу № 6\n\n" +
                          "Условие: Напишите программу, которая на вход принимает число и выдаёт,\n" +
                          "является ли число чётным(делится ли оно на два без остатка).\n");
        Console.Write("Введите число: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        num1 = Math.Abs(num1);
        if (num1 % 2 == 0)
        {
            Console.Write($"Ответ: Да, число четное");
        } else Console.Write($"Ответ: Нет, число не четное");
    }

    /*Задача 7: Напишите программу, которая на принимает на вход трёхзначное число
                и на выходе показывает последнюю цифру этого числа.

                456 -> 6
                782 -> 2
                918 -> 8*/

    public void task7()
    {
        Console.Write("Задача еще не готова! ожидайте решения :D");
    }

    /*Задача 8: Напишите программу, которая на вход принимает число(N),
                а на выходе показывает все чётные числа от 1 до N.

                5 -> 2, 4
                8 -> 2, 4, 6, 8*/

    public void task8()
    {
        Console.Write("Задача еще не готова! ожидайте решения :D");
    }

    /*Задача 9: Здесь будет условие.

                5 -> 2, 4
                8 -> 2, 4, 6, 8*/

    public void task9()
    {
        Console.Write("Задача еще не готова! ожидайте решения :D");
    }

    /*Задача 10: Напишите программу, которая принимает на вход трёхзначное число
                 и на выходе показывает вторую цифру этого числа.

                456 -> 5
                782 -> 8
                918 -> 1*/

    public void task10()
    {
        Console.Write("Задача еще не готова! ожидайте решения :D");
    }

    /*Задача 11: Здесь будет условие.

                    5 -> 2, 4
                    8 -> 2, 4, 6, 8*/

    public void task11()
    {
        Console.Write("Задача еще не готова! ожидайте решения :D");
    }

    /*Задача 12: Здесь будет условие.

                5 -> 2, 4
                8 -> 2, 4, 6, 8*/

    public void task12()
    {
        Console.Write("Задача еще не готова! ожидайте решения :D");
    }

    /*Задача 13: Напишите программу, которая выводит третью цифру заданного числа
                 или сообщает, что третьей цифры нет.

                 645 -> 5
                 78 -> третьей цифры нет
                 32679 -> 6*/

    public void task13()
    {
        bool two = true;
        Console.WriteLine("Вы выбрали 13 задачу");
        Console.WriteLine("Условие: Напишите программу, которая выводит третью цифру заданного числа");
        Console.WriteLine("или сообщает, что третьей цифры нет.");
        while (two)
        {
            try
            {
                Console.Write("Решение:\nВведите число: ");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num > 99 || num < -99)
                {
                    num = Math.Abs(num);
                    string textNumber = num.ToString();
                    int lenght = textNumber.Length; //int lenght = (int)Math.Log10(num) + 1;
                    num = num / (int)Math.Pow(10, lenght - 3) % 10;
                    Console.WriteLine("Ответ: Третья цифра числа: " + num);
                    two = false;
                }
                else
                {
                    Console.WriteLine("Ответ: Третьей цифры нет");
                    two = false;
                }
            }
            catch
            {
                Console.WriteLine("Ошибка ввода, попробуйте еще раз: ");
            }
        }
    }

    /*Задача 14: Здесь будет условие.

                5 -> 2, 4
                8 -> 2, 4, 6, 8*/

    public void task14()
    {
        Console.Write("Задача еще не готова! ожидайте решения :D");
    }

    /*Задача 15: Напишите программу, которая принимает на вход цифру,
                 обозначающую день недели, и проверяет, является ли этот день выходным.

                 6 -> да
                 7 -> да
                 1 -> нет*/

    public void task15()
    {
        Console.Write("Задача еще не готова! ожидайте решения :D");
    }

    /*Задача 16: Здесь будет условие.

                5 -> 2, 4
                8 -> 2, 4, 6, 8*/

    public void task16()
    {
        Console.Write("Задача еще не готова! ожидайте решения :D");
    }

    /*Задача 17: Здесь будет условие.

                5 -> 2, 4
                8 -> 2, 4, 6, 8*/

    public void task17()
    {
        Console.Write("Задача еще не готова! ожидайте решения :D");
    }

    /*Задача 18: Здесь будет условие.

                5 -> 2, 4
                8 -> 2, 4, 6, 8*/

    public void task18()
    {
        Console.Write("Задача еще не готова! ожидайте решения :D");
    }

    /*Задача 19: Напишите программу, которая принимает на вход пятизначное число
                 и проверяет, является ли оно палиндромом.

                 14212 -> нет
                 12821 -> да
                 23432 -> да*/

    public void task19()
    {
        Console.Write("Вы выбрали Задачу 19.\n" +
                                      "чтобы узнать является ли число полиндромом\n" +
                                      "Введите число: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        string textNumber = num1.ToString();
        int lenght = textNumber.Length;
        int result = 0;
        for (int i = 0; i <= lenght / 2; i++)
        {
            if (textNumber[i] == textNumber[lenght - 1 - i])
            {
                //Console.WriteLine($"цифры {textNumber[i]} и {textNumber[lenght - 1 - i]} совпали");
            }
            else
            {
                //Console.WriteLine($"цифры {textNumber[i]} и {textNumber[lenght - 1 - i]} не совпали - число не полиндром");
                result = 1;
                break;
            }
        }
        if (result == 0) Console.WriteLine("Число полиндром");
        else Console.WriteLine("Число не полиндром");
        return;
    }

    /*Задача 20: Здесь будет условие.

                5 -> 2, 4
                8 -> 2, 4, 6, 8*/

    public void task20()
    {
        Console.Write("Задача еще не готова! ожидайте решения :D");
    }

    /*Задача 21: Напишите программу, которая принимает на вход координаты двух точек 
                 и находит расстояние между ними в 3D пространстве.

                 A (3,6,8); B (2,1,-7), -> 15.84
                 A (7,-5, 0); B (1,-1,9) -> 11.53*/

    public void task21()
    {
        Console.WriteLine("Вы выбрали Задачу 21.\n" +
                                      "для определения расстояния между двумя точками\n" +
                                      "введите координаты точки" +
                                      " A (x1,y1,z1) и B(x2, y2, z2).");
        Console.Write("Введите координату x1: ");
        int x1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите координату y1: ");
        int y1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите координату z1: ");
        int z1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите координату x2: ");
        int x2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите координату y2: ");
        int y2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите координату z2: ");
        int z2 = Convert.ToInt32(Console.ReadLine());
        double d = Math.Pow((Math.Pow(x2 - x1, 2) +
                             Math.Pow(y2 - y1, 2) +
                             Math.Pow(z2 - z1, 2)), 0.5);
        d = Math.Round(d, 2);
        Console.WriteLine("Растояние между точками А и В" +
                          " в 3D пространстве = " + d);
        return;
    }

    /*Задача 22: Здесь будет условие.

                5 -> 2, 4
                8 -> 2, 4, 6, 8*/

    public void task22()
    {
        Console.Write("Задача еще не готова! ожидайте решения :D");
    }

    /*Задача 23: Напишите программу, которая принимает на вход число (N)
                 и выдаёт таблицу кубов чисел от 1 до N.

                 3 -> 1, 8, 27
                 5 -> 1, 8, 27, 64, 125*/

    public void task23()
    {
        Console.Write("Вы выбрали Задачу 23.\n" +
                                      "Чтобы задать таблицу кубов от 1 до N " +
                                      "\nВведите число N: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        if (num1 > 0)
        {
            Console.WriteLine($"Таблица кубов чисел от 1 до {num1}:");
            for (int i = 1; i <= num1; i++)
            {
                Console.WriteLine($"{i}^3 = {Math.Pow(i, 3)} ");
            }
        }
        else Console.WriteLine($"Число {num1} не попало в интервал от 1");
    }
}