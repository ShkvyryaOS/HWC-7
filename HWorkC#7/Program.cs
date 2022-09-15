// ДОМАШНЕЕ  ЗАДАНИЕ 7 СЕМИНАР
//Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double [,] Random2dRealNumberArray()
{
    Console.Write("Input numbers of rows: ");
    int rows=Convert.ToInt32(Console.ReadLine());
    Console.Write("Input numbers of colomns: ");
    int colomns=Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min possible value: ");
    int minValue=Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max possible value: ");
    int maxValue=Convert.ToInt32(Console.ReadLine());


double [,] newArray=new double[rows, colomns];
    for (int i=0; i< rows; i++)
        for (int j=0; j<colomns; j++)
            newArray [i,j]=new Random().Next(minValue, maxValue);
 
 double [,] array=new double[rows, colomns];
    for(int i=0; i<rows; i++)
        for (int j=0; j<colomns; j++)
            array[i,j]=new Random().NextDouble();
    
double [,] SumArr= new double[rows,colomns];
    for (int i=0; i<rows; i++)
    for (int j=0; j<colomns; j++)
        SumArr[i,j]=Math.Round (newArray[i,j]+array[i,j], 2);
   
 return SumArr;
  
}  

void Show2darray(double[,] array)
{
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
               Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
Console.WriteLine();
}

double [,] RealNumArray=Random2dRealNumberArray();
Show2darray(RealNumArray);



/*
//Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int [,] CreateRandom2dArray()
{
    Console.Write("Input numbers of rows: ");
    int rows=Convert.ToInt32(Console.ReadLine());
    Console.Write("Input numbers of colomns: ");
    int colomns=Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min possible value: ");
    int minValue=Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max possible value: ");
    int maxValue=Convert.ToInt32(Console.ReadLine());


    int [,] newArray=new int[rows, colomns];
    for (int i=0; i< rows; i++)
        for (int j=0; j<colomns; j++)
            newArray [i,j]=new Random().Next(minValue, maxValue+1);
    return newArray;
}  
void Show2darray(int[,] array)
{
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
               Console.Write(array[i,j] + " ");
        Console.WriteLine();
       
    }
Console.WriteLine();
}



void ShowArrayNumber (int [,] array )
{
    Console.Write("Input number of row: ");
    int row=Convert.ToInt32(Console.ReadLine());
    Console.Write("Input number of colomn: ");
    int colomn=Convert.ToInt32(Console.ReadLine());
    int number=0;
    if (row<array.GetLength(0)&& colomn<array.GetLength(1))
    {
        number=array[row,colomn];
    Console.WriteLine($"Value of pozition with an index [{row},{colomn}] is {number}");
    }
    else 
    Console.WriteLine($"There is no position with an index[{row},{colomn}]");
}

int [,] NewArr=CreateRandom2dArray();
Show2darray(NewArr);
ShowArrayNumber(NewArr);

*/

/*
// Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int [,] CreateRandom2dArray()
{
    Console.Write("Input numbers of rows: ");
    int rows=Convert.ToInt32(Console.ReadLine());
    Console.Write("Input numbers of colomns: ");
    int colomns=Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min possible value: ");
    int minValue=Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max possible value: ");
    int maxValue=Convert.ToInt32(Console.ReadLine());


    int [,] newArray=new int[rows, colomns];
    for (int i=0; i< rows; i++)
        for (int j=0; j<colomns; j++)
            newArray [i,j]=new Random().Next(minValue, maxValue+1);
    return newArray;
}  

void Show2darray(int[,] array)
{
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
               Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
Console.WriteLine();
}


void AverageValueColomns (int [,] array)
{       
    for(int j=0; j<array.GetLength(1); j++) 
    {   
        double sum=0;
        double averSum=0;
        for (int i=0; i<array.GetLength(0); i++)  
                sum=(sum+array[i,j]);
        averSum=Math.Round(sum/array.GetLength(0),2);            
        Console.Write (averSum +" ");
    }
}
int [,] NewArr=CreateRandom2dArray();
Show2darray(NewArr);
AverageValueColomns(NewArr);
*/