// В прямоугольной матрице найти строку с наименьшей суммой элементов.
void FillMassiv(int[,] massiv)
{
    Random Arr = new Random();
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            massiv[i, j] = Arr.Next(-9, 9);
        }
    }
}

void PrintMass(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]} ");
        }
        Console.WriteLine();
    }
}

double[] SumLine(int[,] array)
{

    double[] summ = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        summ[i] = sum;
    }
    return summ;
}

void printSum(double[] array)
{
    foreach (double el in array)
    {
        Console.Write(el + " ");
    }
}

int SearchLessSum(double[] array)
{
    int indexLine = 0;
    for (int i = 0; i < array.Length; i++)
    {
        double min = array[0];
        if (array[i] < min)
        {
            min = array[i];
            indexLine = i;
        }
    }
    return indexLine;
}

Console.Write("Введите число (строк) m: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число (столбцов) n: ");
int n = int.Parse(Console.ReadLine() ?? "0");
int[,] array = new int[m, n];

FillMassiv(array);
PrintMass(array);

Console.WriteLine();

double[] sum = SumLine(array);
printSum(sum);

Console.WriteLine();

int LineNumber = SearchLessSum(sum) + 1;
Console.WriteLine($"Строка с наименьшей суммой {LineNumber}");         