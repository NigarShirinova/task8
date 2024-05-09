using System;
using System.Diagnostics;
using System.Globalization;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace Test
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Animal animal1 = new Animal("Mia", "british", " grey", 2);
            animal1.PrintDetails();
            



            Building building1 = new Building("Flame towers", 100, 5);
            building1.PrintDetails();
            //natamam



            Student student1 = new Student("Nigar", "Shirinova", 17, [100, 100, 100], [100, 100, 100],
                [100, 100, 100], 100, [true, true, true, true, true]);
            int finalResult = student1.FinalResult(); 
            if(finalResult >= 95) { Console.WriteLine("high honor"); }
            else if (finalResult >=85) { Console.WriteLine("honor"); }
            else if (finalResult >= 65) { Console.WriteLine("normal"); }
            else { Console.WriteLine("fail"); }
            

            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            signline: Console.WriteLine("isare daxil edin");
            string sign = Console.ReadLine();
            Calculator numbers = new Calculator(number1, number2);
            switch (sign) 
            {
                case "+":
                    Console.WriteLine(numbers.sum(number1 , number2));
                    break;
                case "-":
                    Console.WriteLine(numbers.difference(number1 , number2));
                    break;
                case "*":
                    Console.WriteLine(numbers.product(number1, number2));
                    break;
                case "/":
                    Console.WriteLine(numbers.division(number1,number2));
                    break;
                default:
                    goto signline;
                

            }

            
            Gun gun1 = new Gun("sniper1", 20, 15, 40, "sniper");
            gun1.Fire();
            gun1.Reload();
            gun1.ShowCase();
  



        }
    }

    public class Animal
    {
        public string name;
        public string breed;
        public string color;
        public int age;

        
        public Animal(string name, string breed, string color, int age)
        {
            this.name = name;
            this.breed = breed;
            this.color = color;
            this.age = age;
        }

        public void PrintDetails()
        {
            Console.WriteLine($"{name}, {breed}, {color}, {age}");
        }
    }



    public class Building
    {
        public string name;
        public int height;
        public int area;
        public string adress;


        public Building(string name, int height, int area, string adress)
        {
            this.name = name;
            this.height = height;
            this.area = area;
            this.adress = adress;

        }

        public Building(string name, int height, int area)
        {
            this.name = name;
            this.height = height;
            this.area = area;
        }
        public int FindVolume()
        {
            return area * height;
        }

        public void PrintDetails()
        {
            Console.WriteLine($"{name} , {height} , {area} , {adress} , {FindVolume()}");
        }

        
    }


    public class Student
    {
        public string name;
        public string surname;
        public int age;
        public int[] homeWorkGrades;
        public int[] projectGrades;
        public int[] quizGrades;
        int finalGrade;
        public bool[] continuity;


        public Student(string name, string surname, int age, int[] homeWorkGrades,
            int[] projectGrades, int[] quizGrades, int finalGrade, bool[] continuity)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.homeWorkGrades = homeWorkGrades;
            this.projectGrades = projectGrades;
            this.quizGrades = quizGrades;
            this.finalGrade = finalGrade;
            this.continuity = continuity;
        }


        public int FindAvarage(int[] grades)
        {
            int totalGrade = 0;
            foreach (int grade in grades)
            {
                totalGrade += grade;
            }
            return totalGrade/grades.Length;
        }

        public int FindCountinuity(bool[] continuity)
        {
            int count = 0;
            foreach (var participation in continuity)
            {
                if(participation)
                    count++;
            }
            
            return count*100/continuity.Length;
        }

        public int FinalResult()
        {
            int avarageHomeworkGrade = FindAvarage(homeWorkGrades);
            int avarageQuizGrade = FindAvarage(quizGrades);
            int avarageProjectGrade = FindAvarage(projectGrades);
            int continuityGrade = FindCountinuity(continuity);

            int finalResult = (avarageHomeworkGrade * 20) / 100 + avarageQuizGrade * 20 / 100 
                + avarageProjectGrade * 20 / 100 +
                continuityGrade * 10 / 100 + finalGrade * 30 / 100;
            return finalResult;
        }
    }


    public class Calculator
    {
        public int number1;
        public int number2;

        public Calculator(int number1, int number2)
        {
            this.number1 = number1;
            this.number2 = number2;
        }



        public int sum(int number1 , int number2)
        {
            return number1 + number2;
        }

        public int product(int number1 , int number2)
        {
            return number1 * number2;
        }

        public int difference(int number1 , int number2)
        {
            return number1 - number2;
        }

        public int division(int number1 , int number2)
        {
            return number1 / number2;
        }
    }

    
    public class Gun
    {
        public string name;
        public int maxCapacity;
        public int currentBullet;
        public int totalBullet;
        public string type;


        public Gun(string name, int maxCapacity, int currentBullet, int totalBullet, string type)
        {
            this.name = name;
            this.maxCapacity = maxCapacity;
            this.currentBullet = currentBullet;
            this.totalBullet = totalBullet;
            this.type = type;

            if( type != "sniper" && type!= "assault")
            {
                Console.WriteLine("error");
            }

            if( currentBullet > maxCapacity)
            {
                Console.WriteLine("error");
            }
        }

        public int Fire()
        {
            if(type == "sniper")
            {
                
                currentBullet--;
                return currentBullet;
            }
            else if(type == "assault")
            {
                
                currentBullet = 0;
                return currentBullet;
            }
            else
            {
                return 0;
            }
        }


        public void Reload()
        {
            totalBullet = totalBullet - maxCapacity + currentBullet;
            currentBullet = maxCapacity;
        }

        public void ShowCase()
        {
            Console.WriteLine(name);
            Console.WriteLine(currentBullet);
            Console.WriteLine(totalBullet);
            Console.WriteLine(type);
        }
    }


}