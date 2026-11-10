using System.Text.RegularExpressions;

int[] recordBooks = { 1042, 1058, 1071, 1093, 1105 };
int target = 1071;
bool found = false;
foreach (int number in recordBooks)
{
    if (number == target)
    {
        found = true;
        break;
    }
}
Console.WriteLine(found ? "Студент найден" : "Студент не найден")
int variant = 17;
bool isPrime = true;

for (int divisor = 2; divisor < variant; divisor++)
{
    if (variant % divisor == 0)
    {
        isPrime = false;
        break;
    }
}

Console.WriteLine(isPrime ? "Номер варианта простой" : "Номер варианта составной");

int[] pointsPerLab = { 8, -1, 10, 9, -1, 7 };
int sum = 0;
foreach (int points in pointsPerLab)
{
    if (points < 0)
    {
        continue;
    }
    sum += points;
}

Console.WriteLine($"Сумма баллов за сданные работы: {sum}");
int[] groupIds = { 101, 104, 107, 104, 110 };
bool hasDuplicates = false;
for (int i = 0; i < groupIds.Length; i++)
{
    for (int j = j + 1; j < groupIds.Length; j++)
    {
        if (groupIds[i] == groupIds[j])
        {
            hasDuplicates = true;
            break;
        }
    }
}
Console.WriteLine(hasDuplicates ? "Есть повторяющиеся номера" : "Все номера уникальны");
