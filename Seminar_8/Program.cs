/*
// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию
//  элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.WriteLine("Введите число");
int rows1 = Covert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число");
int rows2 = Covert.ToInt32(Console.ReadLine());

int [,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int [m,n]; 
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            result[i,j]= new Random().Next(min,max+1);
            
        }
        
    }
    result result;
}
void ChangeRouse(int[,]matrix)
{
    int rousCount = matrix.Length-1;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int temp = matrix[0,i];
        matrix[0,i]=matrix[rousCount,i];
        matrix[rousCount,i]=temp;
}

PrintArray(GetArray(rows1,rows2));
 */

 /*
// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов:
// 1 строка

Console.WriteLine("Введите число");
int rows = Covert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число");
int rows = Covert.ToInt32(Console.ReadLine());

int minValue = int.MaxValue;
int minIndexRows=0;
int minIndexCol=0;

int [,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int [i]; 
    for(int i = 0; i < m; i++)
        {
        for(int j = 0; j < n; j++)
        {
            result[i,j]= new Random().Next(min,max+1);
            
        }
        
    }
    result result;
}
void PrintArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; i < inputArray.GetLength(1); j++)
        {
            Console.WriteLine(iputArray[i,j]);
            if (minvalue>iputArray[i,j])
            {
                minvalue=iputArray[i,j]);
                minIndexRows=i;
                minIndexRows=j;
            }

        }
       Console.WriteLine(); 
    }

    int[,]ChangArray(int[,]array)
    {
      int[,] result = new int[array.GetLenght(0),array.GetLenght(1)]; 
        for (int i = 0; i < inputArray.GetLength(0); i++)
        {
        if(i!=minIndexRows);
        {
            for (int j = 0; i < inputArray.GetLength(1); j++) 
        }
        if(j!=minIndexCol)
        {
              result[j,i] = array[i,j];
        }
        Console.Write(array[i,j]);   
        }
        
}
Console.WriteLine();
/*
*/
// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Введите число");
int rows = Covert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число");
int rows = Covert.ToInt32(Console.ReadLine());

if (rows!=colums)
{
    Console.WriteLine(" в данной матрице нельзя заменить");
}    
return;

int [,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int [m,n]; 
    for(int i = 0; i < m; i++)
        {
        for(int j = 0; j < n; j++)
        {
            result[i,j]= new Random().Next(min,max+1);
            
        }
        
    }
    result result;
}
void PrintArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; i < inputArray.GetLength(1); j++)
        {
            Console.WriteLine(iputArray[i,j]);
            
            {
                
                 
       Console.WriteLine(); 
          }
  }

    int[,]ChangArray(int[,]array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; i < array.GetLength(1); j++)
        {
            array[i,j]=array[j,i];
            
            {
                
                 
       Console.WriteLine(); 
       }
       returne array;
        }
        int[,]array= GetArray(rows,colums);
         PrintArrayArray(array2);
         Console.WriteLine("_________________");
         ChangArray(array2);
         PrintArray(array2);
/*
*/
// .Сформируйте трёхмерный массив из неповторяющихся
 двузначных чисел. Напишите программу,
  которая будет построчно выводить массив, 
  добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
Console.WriteLine("Enter number of rows :");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number of colums :");
int n = Convert.ToInt32(Console.ReadLine());
 int[,] matrix = new int [m,n];

for(int i = 0; i < matrix.GetLenght(0); i++)
{
    for(int j = 0; j < matrix.GetLenght(1); j++)
    {
        matrix[i,j] = new Random().Next(0,11);
        Console.Write(matrix[i,j]+"\t");
}
    Console.Write();
}
double [] sum + new double[matrix.GetLenght(0)];
for (int j = 0; j < matrix.GetLenght(0); j++)
    {

    sum[j]=0;
    for (int i = 0; i < matrix.GetLenght(1); i ++)
    {
        sum[j]=0;
        for (int i=0; i < matrix.GetLenght(1); i++)
        {
            sum[j]+= matrix[i,j];
        }
        Console.WriteLine($"{j} avarage is : {sum[j]/m}");
 }
/*
*/
// Напишите программу, которая заполнит
//  спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
double [,] matrix = new double [3,4];

for(int i = 0;i < 3; i++)
{
    for(int j = 0; j < 4; j++)
   {
   matrix[i,j] = new Random(). Next(-9,10) + new Random().Nextdouble();
   matrix[i,j] = Math.Round(matrix[i,j], 1);

   Console.Write(matrix[i,j]+"\t");
   }
   Console.Write();
   */