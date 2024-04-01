int studentsCount = int.Parse(Console.ReadLine());

double sumGrades = 0;

for (int i = 0; i < studentsCount; i++)
{
    double grade = double.Parse(Console.ReadLine());

    sumGrades += grade;
}

Console.WriteLine($"{sumGrades / studentsCount:f2}");

