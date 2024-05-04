using System;

namespace Test
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("task1:Gonderilmis iki int parametrnin hasilini tapan method yazin.");
            Console.WriteLine(FindProduct(10, 30));
            Console.WriteLine("task2:Gonderilmis int parametrnin kvadratini tapan method yazin.");
            Console.WriteLine(FindSquare(10));
            Console.WriteLine("task3:.Gonderilmis bir olculu array parametrindeki elementlerin cemini tapan method yazin.");
            int[] array = { 1, 2, 3, 5 };
            Console.WriteLine(FindSum(array));
            Console.WriteLine("task4:Iki string (name, surname) parametrinin xosgelmisen mesajini qaytaran method yazin.");
            WriteWelcome("Nigar", "Shirinova");
            Console.WriteLine("task5:Gonderilmis bir string parametrni tersine qaytaran method yazin.");
            Console.WriteLine(ReverseString("salam"));
            Console.WriteLine("task6:Methoda bir int parametr oturulur, eger o variable 7e bolunurse print edilsin ki 7e bolunur,bolunmurse hemin variable en yaxin ededi qaytarsin.");
            DivideTo7(20);
            Console.WriteLine("task7:Overload - bir birine overload olan iki metod yazin hansi ki biri kvadratinb perimetrini digeri ise ucbucaqlinin perimetrini tapsin");
            Console.WriteLine(FindPerimeter(4));
            Console.WriteLine(FindPerimeter(4,5,6));
            Console.WriteLine("task8:Bir metod yazin hansi ki o string sentence gozleyir ve netice olaraq cumlede nece dene bosluq oldugunu qaytarir");
            Console.WriteLine(CountWhiteSpace("salam necesen          ?"));


        }

        public static int FindProduct(int num1, int num2)
        {
            return num1*num2;
        }

        public static int FindSquare(int num)
        {
            return num * num;
        }

        public static int FindSum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }

        public static void WriteWelcome(string name, string surname)
        {
            Console.WriteLine($"Welcome, {name} {surname}");
        }

        public static string ReverseString(string word)
        {
            string reversed = string.Empty;
            for (int i = word.Length -1 ;i >= 0;i--)
            {
                reversed += word[i];
            }
            return reversed;
        }

        public static void DivideTo7(int num)
        {
            int bolunen = 0;
            if(num %7 == 0)
            {
                Console.WriteLine("7-e bolunur");
            }
            else
            {
                for (int i = num; i > 0; i--)
                {
                    if(i % 7 == 0)
                    {
                        bolunen = i;
                        break;
                    }
                }
                if( num - bolunen > bolunen +7 - num)
                {
                    Console.WriteLine(bolunen +7 );
                }
                else
                {
                    Console.WriteLine(bolunen );
                }
            }
        }

        public static int FindPerimeter(int num)
        {
            return num * 4;
        }
        
        public static int FindPerimeter(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }

        public static int CountWhiteSpace(string sentence)
        {
            int count = 0;
            for (int i = 0; i < sentence.Length;i++)
            {
                if (sentence[i] == ' ')
                {
                    count++;
                }
            }
            return count;
        }

    }

}