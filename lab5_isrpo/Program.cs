Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
    Console.WriteLine("Число положительное");
}
else if (number < 0)
{
    Console.WriteLine("Число отрицательное");
}
else
{
    Console.WriteLine("Число равно нулю");
}

Console.Write("Введите количество посещений (из 19): ");
int attendance = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите средний балл по практике: ");
double practiceGpa = Convert.ToDouble(Console.ReadLine());
bool goodAttendance = attendance >= 14;
bool goodPracticeGpa = practiceGpa >= 3.0;

if (goodAttendance && goodPracticeGpa)
{
    Console.WriteLine("Допуск к экзамену разрешен.");
}
else if (!goodAttendance && goodPracticeGpa)
{
    Console.WriteLine("Допуск к экзамену запрещен. Нужно отработать пропуски.");
}
else if (goodAttendance && !goodPracticeGpa)
{
    Console.WriteLine("Низкий балл по практике. Нужно пересдать работы.");
}
else
{
    Console.WriteLine("Проблемы и с посещаемостью и с оценками.");
}