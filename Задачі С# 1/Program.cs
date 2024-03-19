using System;
using System.Reflection.Metadata;

namespace project
{//- 1)Напишіть програму, яка знаходить середнє значення елементів у масиві.
    class Program1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача 1");
            Random random = new Random();
            int[] arr = new int[10]; // Оголошення  масиву цілих чисел на 10 елементів


            // Заповнення масиву випадковими значеннями
            for (int i = 0; i < 10; i++)
            {
                for (int b = 0; b < 2; b++)
                {
                    arr[i] = random.Next(0, 100);
                }
            }
            Console.WriteLine("Масив");
            // Вивід масиву 
            for (int i = 0; i < 10; i++)
            {

                Console.Write(arr[i] + "  ");

            }
            Console.WriteLine("\t");
            float sum = 0; //Розрахунок суми всіх елементів масиву
            for (int i = 0; i < 10; i++)
            {

                sum += arr[i];

            }
            Console.WriteLine("\n" + "Сума = " + sum + "\n" + "Середнє значення = " + sum / 10 + "\n");//Вивід суми та середнього значення елементів масиву


            //////////////////////////////////////////////////////////////////////////////////////////////////
            {
                //- 2)Напишіть програму, яка транспонує заданий двовимірний масив.
                Console.WriteLine("\n" + "Задача 2");
                int[,] arr1 = new int[2, 10];//Оголошення двовимірного масиву цілих чисел на 20 елементів
                for (int i = 0; i < 2; i++)//Заповнення масиву випадковими значеннями у проміжку від [0, 100]
                {
                    for (int b = 0; b < 10; b++)
                    {
                        arr1[i, b] = random.Next(0, 100);
                    }
                }
                Console.WriteLine("Масив до транспонування" + "\n");
                for (int i = 0; i < 2; i++)//Вивід масиву до транспонування 
                {
                    for (int b = 0; b < 10; b++)
                    {
                        Console.Write(arr1[i, b] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine('\n');
                int[,] arr2 = new int[10, 2];
                for (int i = 0; i < 10; i++)//Транспонування
                {
                    for (int b = 0; b < 2; b++)
                    {
                        arr2[i, b] = arr1[b, i];
                    }
                }
                Console.WriteLine("Масив після транспонування" + "\n");
                for (int i = 0; i < 10; i++)//Вивід масиву пiсля транспонування 
                {
                    for (int b = 0; b < 2; b++)
                    {
                        Console.Write(arr2[i, b] + "\t");
                    }
                    Console.WriteLine();
                }

                ///////////////////////////////////////////////////////////////////////////////////////////////////
                //Задачі на арифметичні та логічні оператори

                //Напишіть програму, яка перевіряє, чи є введене користувачем число простим.
                //Використовуйте арифметичні операції для перевірки дільниківчисла.
                Console.WriteLine("\n"+"Задача 3" );
                Console.Write("Введіть число для перевірки: \n");
                int n = Convert.ToInt32(Console.ReadLine());//Введення числа для перевірки

                if (n == 1 || n == 2)//Перевіррка числа на простоту
                {
                    Console.WriteLine(n + " - просте число");
                }
                else
                {
                    int b1 = n - 1;
                    bool isPrime = true;

                    for (int i = 2; i < n; i++)
                    {
                        if (n % i == 0)
                        {
                            isPrime = false;
                            Console.WriteLine(n + " не просте число. " + i + " Його дільник");
                            break;
                        }
                    }

                    if (isPrime)
                    {
                        Console.WriteLine(n + " - просте число");
                    }
                }
                









            }
        }

    }
}