// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Наталия Меньшова! Trust that you are fine  ");
//Задача 54: Задайте двумерный массив. 
//Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2
//
// Метод создания массива, размер задается в программе 
Console.WriteLine("Задача N54");
int[,] myArray = new int[3,4];
void Matrix(int[,] arr)
{
		Console.WriteLine();
		int numRows=myArray.GetLength(0);
		Console.Write(" Количество строк="+numRows);
		int numColumns=myArray.GetLength(1);
		Console.Write(" Количество столбцов="+numColumns);
		
   //	for (int i=0; i<numRows; i++)
		//{
		//Console.WriteLine();
		//Console.Write("i="+i+" |   ");	
	 	//		for (int j=0; j<numColumns; j++)
		//		{ 
    //  		Console.Write("j="+j+" ");
		// 		}
}		
// Печать массива
void PrintArray(int[,] array)
{
	Console.WriteLine();	
	for (int i=0; i<myArray.GetLength(0); i++)
	{
    Console.WriteLine(); 
		for(int j=0; j<myArray.GetLength(1); j++)
		{	
       Console.Write(myArray[i,j]+"    ");
		}
	}
Console.WriteLine();
}		
//Заполнение массива случайными числами
void FillArray(int[,] array)
{
	for (int i=0; i<myArray.GetLength(0); i++)
	{
    Console.WriteLine(); 
		for(int j=0; j<myArray.GetLength(1); j++)
		{	
       myArray[i,j]=new Random().Next(0,10);
			 Console.Write(myArray[i,j]+"    ");
		}
	}
}		
// Сортировка строк массива 
void SortArray(int[,] array)
{
	for (int i=0; i<myArray.GetLength(0); i++)
	{
		for(int j=0; j<myArray.GetLength(1); j++)
		{	
			int maxPosition=0;
      for (int checkRow=maxPosition+1; checkRow<myArray.GetLength(1); checkRow++)
			{
					if (myArray[i,maxPosition]>myArray[i,checkRow])
					     maxPosition=checkRow;

  	  	  int temporary=myArray[i,maxPosition];
					myArray[i,maxPosition]=myArray[i,checkRow];
					myArray[i,checkRow]=temporary;
			}
		 //Console.WriteLine(myArray[i,j]);
		} 
	}
}
Matrix(myArray);
PrintArray(myArray);
Console.WriteLine();
Console.WriteLine("Заполнение массива случайными числами:");
FillArray(myArray);
Console.WriteLine("Сортировка строк массива по убыванию:");
SortArray(myArray);
PrintArray(myArray);
Console.ReadLine();
//___________________________________________________________________________________________
//Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
Console.WriteLine("Задача N56");
int[,] mmyArray=new int[3,3];
int[] newArray=new int[mmyArray.GetLength(0)];
//Заполнение массива случайными числами
void FilllArray(int[,] array)
{
	for (int i=0; i<mmyArray.GetLength(0); i++)
	{
   Console.WriteLine(); 
		for(int j=0; j<mmyArray.GetLength(1); j++)
		{	
		   mmyArray[i,j]=new Random().Next(0,10);
			 Console.Write(mmyArray[i,j]+"    ");
		}
	}
	Console.WriteLine();
}		
//  Метод подсчета сум строк массива 
int[] SumsRaws(int[,] array)
{
	for (int i=0; i<mmyArray.GetLength(0); i++)
	{
		int summ=0;
		for(int j=0; j<mmyArray.GetLength(1); j++)
		{	
       summ+=mmyArray[i,j];
		}
		newArray[i]=summ;
		Console.Write(newArray[i]+" ");
	}	
	return newArray;	
}	
// Number of string with max sum of its elements
int StringNum(int[] adrr)
{
	int stringNum=0;
	int min = Int32.MaxValue;
	for (int i = 0; i < newArray.Length; i++)
	{
  	 if (newArray[i] < min)
	 	{
    	 min = newArray[i];
		 	 stringNum=i;
   }
	} 
	Console.WriteLine(" -> минимальная сумма элементов в строке "+(stringNum+1));
	return stringNum;
}
FilllArray(mmyArray);
SumsRaws(mmyArray);
StringNum(newArray);
Console.ReadLine();
//___________________________________________________________________________________
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
//  2 4 | 3 4
//  3 2 | 3 3
//  Результирующая матрица будет:
//  18 20
//  15 18
Console.WriteLine();
Console.WriteLine("Задача N58");
int[,] array1=new int[2,2];
int[,] array2=new int[2,2]; 
int[,] resultArray=new int[2,2];
//Заполнение массива случайными числами
void FillArrray(int[,] array)
{
	for (int i=0; i<array.GetLength(0); i++)
	{ 
		for(int j=0; j<array.GetLength(1); j++)
		{	
       array[i,j]=new Random().Next(0,10);
			 //Console.Write(array[i,j]+"    ");
		}
	}
}	
// Печать массива
void PrintArrray(int[,] arr)
{
	for (int i=0; i<arr.GetLength(0); i++)
	{
    Console.WriteLine(); 
		for(int j=0; j<arr.GetLength(1); j++)
		{	
       Console.Write(arr[i,j]+"    ");
		}
	}
}			
void Lines(int linesAmount)
{
  for (int i=0; i<linesAmount; i++)
	   {
			Console.WriteLine();
		 }
}
// Перемножение двух массивов
 void MultTwoMatrix(int[,] matrix1, int[,] matrix2, int[,] result)
 {
  int strings=matrix1.GetLength(0);
	for (int i = 0; i < strings; i++)
 	{
     for (int j = 0; j < matrix1.GetLength(1); j++)
		    {
						result[i, j] = matrix1[i, j] * matrix2[i, j];
			   }
	}
Console.WriteLine("Умножение двух заданных выше массивов:");	
PrintArrray(resultArray);
}
FillArrray(array1);
FillArrray(array2);
PrintArrray(array1);
Lines(1);
PrintArrray(array2);
Lines(1);
//Console.ReadLine();
MultTwoMatrix(array1, array2, resultArray);
Console.ReadLine();
//_______________________________________________________________________________
// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
Console.WriteLine();
Console.WriteLine("Задача N60");
int [,,] myArray3 = new int[2 , 2 , 2];
//Заполнение 3-х мерного массива случайными числами
void FillArray3(int[,,] array)
{
	Console.WriteLine("Это элементы трехмерного массива 2x2x2");
	for (int i=0; i<array.GetLength(0); i++)
	{ 
		for(int j=0; j<array.GetLength(1); j++)
		{	
      for (int k=0; k<array.GetLength(2); k++)
			{
			   array[i,j,k]=new Random().Next(0,100);
				 Console.Write(array[i,j,k]+"  ");
			}
		}
   }
}	 	
//Печать массива с координатами элементов в массиве
void PrintArray3(int[,,] arr)
{
	for (int i=0; i<arr.GetLength(0); i++)
	{
		for(int j=0; j<arr.GetLength(1); j++)
 		{	
       Console.WriteLine();
			 for (int k=0; k<arr.GetLength(2); k++)
			 {
            Console.Write(arr[i,j,k]+"("+i+","+j+","+k+")  "); 
			 }		
     }
  }
 }			
FillArray3(myArray3);
PrintArray3(myArray3);
Console.ReadLine();
//___________________________________________________________________________
// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
//  01 02 03 04
//  12 13 14 05
//  11 16 15 06
//  10 09 08 07
//int n = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Задача N62");
int[,] myMatrix = new int[4, 4];
int n=myMatrix.GetLength(0);
int row = 0;
int col = 0;
string direction = "right";
int maxRotations = n * n;
for (int i = 1; i <= maxRotations; i++)
    {
    if (direction == "right" && (col > n - 1 || myMatrix[row, col] != 0))
            {
                direction = "down";
                col--;
                row++;
            }
            if (direction == "down" && (row > n - 1 || myMatrix[row, col] != 0))
            {
                direction = "left";
                row--;
                col--;
            }
            if (direction == "left" && (col < 0 || myMatrix[row, col] != 0))
            {
                direction = "up";
                col++;
                row--;
            }
            if (direction == "up" && row < 0 || myMatrix[row, col] != 0)
            {
                direction = "right";
                row++;
                col++;
						}

            myMatrix[row, col] = i;

            if (direction == "right")
            {
                col++;
            }
            if (direction == "down")
            {
                row++;
            }
            if (direction == "left")
            {
                col--;
            }
            if (direction == "up")
            {
                row--;
            }
        }
// Печать маccива
void PprintArray(int[,] arr)
{
	for (int i=0; i<arr.GetLength(0); i++)
	{
    Console.WriteLine(); 
		for(int j=0; j<arr.GetLength(1); j++)
		{	
			  Console.Write("{0,4}", myMatrix[i, j]);
		}
	}
}			
PprintArray(myMatrix);
Console.ReadLine();
// ___________________________________________
// END


