// using System.Text.RegularExpressions;

// int[] recordBooks = { 1042, 1058, 1071, 1093, 1105 };
// int target = 1071;
// bool found = false;
// foreach (int number in recordBooks)
// {
//     if (number == target)
//     {
//         found = true;
//         break;
//     }
// }
// Console.WriteLine(found ? "Студент найден" : "Студент не найден")
// int variant = 17;
// bool isPrime = true;

// for (int divisor = 2; divisor < variant; divisor++)
// {
//     if (variant % divisor == 0)
//     {
//         isPrime = false;
//         break;
//     }
// }

// Console.WriteLine(isPrime ? "Номер варианта простой" : "Номер варианта составной");

// int[] pointsPerLab = { 8, -1, 10, 9, -1, 7 };
// int sum = 0;
// foreach (int points in pointsPerLab)
// {
//     if (points < 0)
//     {
//         continue;
//     }
//     sum += points;
// }

// Console.WriteLine($"Сумма баллов за сданные работы: {sum}");
// int[] groupIds = { 101, 104, 107, 104, 110 };
// bool hasDuplicates = false;
// for (int i = 0; i < groupIds.Length; i++)
// {
//     for (int j = j + 1; j < groupIds.Length; j++)
//     {
//         if (groupIds[i] == groupIds[j])
//         {
//             hasDuplicates = true;
//             break;
//         }
//     }
// }
// Console.WriteLine(hasDuplicates ? "Есть повторяющиеся номера" : "Все номера уникальны");

// int days = 5;
// int lessonsPerDay = 6;
// bool found = false;

// for (int day = 1; day <= days && !found; day++)
// {
//     for (int lesson = 1; lesson <= lessonsPerDay; lesson++)
//     {
//         bool isFree = (day == 3 && lesson == 4);
//         if (isFree)
//         {
//             Console.WriteLine($"Свободный слот: день {day}, урок {lesson}");
//             found = true;
//             break;
//         }
//     }
// }

// if (!found)
// {
//     Console.WriteLine("Свободных слотов нет");
// }

// int[] numbers = { 15, 42, 8, 23, 4 };
// int target = 23;
// bool found = false;
// int foundIndex = -1;
// for (int i = 0; i < numbers.Length; i++)
// {
//     if (numbers[i] == target)
//     {
//         found = true;
//         foundIndex = i;
//         break;
//     }
// }
// Console.WriteLine(found ? $"Число найдено на индексе: {foundIndex}" : "Числа в массиве нет");


// int number = 19;
// bool isPrime = true;
// if (number <= 1)
// {
//     isPrime = false;
// }
// else
// {
//     for (int divisor = 2; divisor < number; divisor++)
//     {
//         if (number % divisor == 0)
//         {
//             isPrime = false;
//             break;
//         }
//     }
// }
// Console.WriteLine(isPrime ? "Число простое" : "Число не является простым");


while (true)
{
    Console.Write("Введите число (0 для выхода): ");
    int number = int.Parse(Console.ReadLine());

    if (number == 0)
    {
        break;
    }

    bool isPrime = true;

    if (number <= 1)
    {
        isPrime = false;
    }
    else
    {
        for (int divisor = 2; divisor < number; divisor++)
        {
            if (number % divisor == 0)
            {
                isPrime = false;
                break;
            }
        }
    }

    Console.WriteLine(isPrime ? "Простое" : "Не простое");
}


int[] num1 = { 4, 12, 7, 19, 3 };
int[] num2 = { 9, 5, 19, 8 };
bool found = false;
for (int i = 0; i < num1.Length && !found; i++)
{
    for (int j = 0; j < num2.Length; j++)
    {
        if (num1[i] == num2[j])
        {
            Console.WriteLine($"Общий элемент найден: {num1[i]}");
            found = true;
            break;
        }
    }
}
if (!found)
{
    Console.WriteLine("Общих элементов нет");
}