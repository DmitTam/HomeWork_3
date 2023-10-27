// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNaturalNumbersBetweenMN(int numM, int numN)
{
    if(numM < numN)
    {
        return numM + SumNaturalNumbersBetweenMN(numM + 1, numN);
    }
    else if (numM > numN)
    {
        return numM + SumNaturalNumbersBetweenMN(numM - 1, numN);
    }
    else return numM;
}

Console.WriteLine("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
if(numberM < 1 || numberN < 1)
    {
    Console.WriteLine("Некорректный ввод!");
    return;
    }

Console.Write("-> ");
Console.Write(SumNaturalNumbersBetweenMN(numberM, numberN));

