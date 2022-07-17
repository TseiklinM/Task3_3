using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Задание 4
    Создайте приложение, которое производит операции над матрицами:
■■ Умножение матрицы на число;
■■ Сложение матриц;
■■ Произведение матриц.
*/

namespace Task3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int choose = 0;
            int row = 0, col = 0;
            int row2 = 0, col2 = 0;
            Random rand = new Random();
            do
            {
                Console.WriteLine("\n Программа \"Матрицы\" ");
                Console.WriteLine("1. Умножение матрицы на число");
                Console.WriteLine("2. Сложение двух матриц");
                Console.WriteLine("3. Произведение двух матриц");
                Console.WriteLine("0. Выход ");
                Console.Write(" Выберите пункт меню: ");
                choose = Convert.ToInt32(Console.ReadLine());

                if (choose < 0 || choose > 3)
                    continue;

                switch (choose)
                {
                    case 1:
                        Console.WriteLine("\n Введите размер матрицы: ");
                        Console.Write(" Количество строк: ");
                        row = Convert.ToInt32(Console.ReadLine());
                        Console.Write(" Количество столбцов: ");
                        col = Convert.ToInt32(Console.ReadLine());
                        Console.Write(" Введите число на которое необходимо умножить матрицу: ");
                        int number = Convert.ToInt32(Console.ReadLine());
                        
                        int[][] array = new int[row][];
                        for (int i = 0; i < array.Length; i++)
                        {
                            array[i] = new int[col];
                        }
                        Console.WriteLine("");
                                                
                        for (int i = 0; i < row; i++)
                        {
                            for (int j = 0; j < col; j++)
                            {
                                array[i][j] = rand.Next(-10, 11);
                                Console.Write($"{array[i][j]}\t");
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine($"\n Результат перемножения матрицы на число {number}");
                        for (int i = 0; i < row; i++)
                        {
                            for (int j = 0; j < col; j++)
                            {
                                array[i][j] *= number;
                                Console.Write($"{array[i][j]}\t");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 2: //Сложение двух матриц
                        Console.WriteLine("\n Введите размер матрицы: ");
                        Console.Write(" Количество строк: ");
                        row = Convert.ToInt32(Console.ReadLine());
                        Console.Write(" Количество столбцов: ");
                        col = Convert.ToInt32(Console.ReadLine());
                        //1.Создание матриц
                        int[][] arrSum1 = new int[row][];
                        int[][] arrSum2 = new int[row][];
                        int[][] sumArray = new int[row][];
                        for (int i = 0; i < arrSum1.Length; i++)
                        {
                            arrSum1[i] = new int[col];
                            arrSum2[i] = new int[col];
                            sumArray[i] = new int[col];
                        }
                        //2.Заполнение матриц и вывод их на экран
                        Console.WriteLine("\n Первая матрица: ");
                        for (int i = 0; i < row; i++)
                        {
                            for (int j = 0; j < col; j++)
                            {
                                arrSum1[i][j] = rand.Next(-10, 11);
                                Console.Write($"{arrSum1[i][j]}\t");
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine($"\n Вторая матрица: ");
                        for (int i = 0; i < row; i++)
                        {
                            for (int j = 0; j < col; j++)
                            {
                                arrSum2[i][j] = rand.Next(-10, 11);
                                Console.Write($"{arrSum2[i][j]}\t");
                            }
                            Console.WriteLine();
                        }
                        //3.Сложение матриц
                        for (int i = 0; i < row; i++)
                        {
                            for (int j = 0; j < col; j++)
                            {
                                sumArray[i][j] = arrSum1[i][j] + arrSum2[i][j];
                            }
                        }
                        //4.Вывод результата на экран
                        Console.WriteLine("\n Результирующая матрица: ");
                        foreach (var line in sumArray)
                        {
                            foreach (var item in line)
                            {
                                Console.Write($"{item}\t");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 3:
                        Console.WriteLine(" ВНИМАНИЕ! \n Правило умножение матриц: \n " +
                            "Две матрицы можно перемножить между собой тогда и только тогда, " +
                            "когда \nколичество столбцов первой матрицы равно количеству строк второй матрицы. ");
                        Console.WriteLine("\n Введите размер матрицы: ");
                        Console.Write(" Количество строк первой матрицы: ");
                        row = Convert.ToInt32(Console.ReadLine());
                        Console.Write(" Количество столбцов первой матрицы: ");
                        col = Convert.ToInt32(Console.ReadLine());
                        Console.Write(" Количество столбцов второй матрицы: ");
                        col2 = Convert.ToInt32(Console.ReadLine());
                        //1.Объявление и создание матриц
                        int[][] array1 = new int[row][];
                        int[][] array2 = new int[col][];
                        int[][] rezArray = new int[row][];
                        for (int i = 0; i < array1.Length; i++)
                        {
                            array1[i] = new int[col];
                        }
                        for (int i = 0; i < array2.Length; i++)
                        {
                            array2[i] = new int[col2];
                        }
                        for (int i = 0; i < rezArray.Length; i++)
                        {
                            rezArray[i] = new int[col2];
                        }
                        //2.Заполение матриц и вывод их на экран
                        Console.WriteLine("\n Первая матрица: ");
                        for (int i = 0; i < row; i++)
                        {
                            for (int j = 0; j < col; j++)
                            {
                                array1[i][j] = rand.Next(-5, 6);
                                Console.Write($"{array1[i][j]}\t");
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine($"\n Вторая матрица: ");
                        for (int i = 0; i < col; i++)
                        {
                            for (int j = 0; j < col2; j++)
                            {
                                array2[i][j] = rand.Next(-5, 6);
                                Console.Write($"{array2[i][j]}\t");
                            }
                            Console.WriteLine();
                        }
                        //3.Перемножение матриц
                        
                        int a, b;
                        for (int i = 0; i < row; i++)
                        {
                            int k = 0;
                            int temp = 0, m = 0;
                            while (m < col2)
                            {
                                for (int j = 0; j < col; j++)
                                {
                                    a = array1[i][j]; 
                                    b = array2[j][m];
                                    temp += a * b;
                                   
                                } 
                                m++;
                                rezArray[i][k] = temp;
                                k++;
                            }
                        }
                        //4.вывод на экран полученной матрицы
                        Console.WriteLine("\n Результирующая матрица: ");
                        foreach (var line in rezArray)
                        {
                            foreach (var item in line)
                            {
                                Console.Write($"{item}\t");
                            }
                            Console.WriteLine();
                        }
                        break;
                }
            } while (choose != 0);
            Console.WriteLine("\n Спасибо за использование нашей программы! \n Good Bay!\n\n");
        }
    }
}
