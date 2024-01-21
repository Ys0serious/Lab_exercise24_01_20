using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LabExcise
{
    internal class Questions
    {

    }



    internal class question1 
    {

        
        public void Q1()
        {
            Console.WriteLine("please enter your first name");
            string firstName = Console.ReadLine();
            Console.WriteLine("please enter your middle name");
            string middleName = Console.ReadLine();
            Console.WriteLine("please enter your last name");
            string lastName = Console.ReadLine(); 
            Console.WriteLine($"your name is {firstName}{lastName}");
            Console.WriteLine($"your name is {firstName}{middleName}{lastName}");
            Console.WriteLine($"your name is {lastName}{firstName}{middleName}");

        }
    }

    internal class question2
    {
        public void Q2()
        {
            Console.WriteLine("Enter count your sibling:");
            string number = Console.ReadLine();
            Console.WriteLine($"i also have {number} siblings");
        
        
        }

    }

    internal class question3
    {
        public void Q3()
        {
            Console.WriteLine("Enter first integer");
            int number_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second integer");
            int number_2 = Convert.ToInt32(Console.ReadLine());
            int number_3 = number_1 + number_2;
            int number_4 = number_1 - number_2;
            Console.WriteLine($"{number_1} + {number_2} = {number_3}");
            Console.WriteLine($"{number_1} - {number_2} = {number_4}");


        }
    }
    
    internal class question4
        {
            public void Q4()
            {
                Console.WriteLine("Enter your choice");
                char singleWord = Convert.ToChar(Console.ReadLine());
                Console.WriteLine($"your response was {singleWord}");
            }
        }


    internal class question5
    {
        public void Q5()
        {
            Console.WriteLine("Leap year contains 29 days for February");
            Console.WriteLine("Enter your answer true/false:");
            bool answer = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine($"Leap year contains 29 days for February is {answer}");
        }

    }
    

    internal class question6
    {
        public void Q6()
        {
            Console.WriteLine("Enter the value of radius :");
            double radius = Convert.ToDouble(Console.ReadLine());
            double Area = radius * 3.14;
            Console.WriteLine($"Area is :{Area:F2}");
        }
    }
    

    internal class question7
    {
        public void Q7()
        {
            Console.WriteLine("Enter the number :");
            double number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Number is {number:F2}:");
            Console.WriteLine($"Integer value: {Convert.ToInt32(number)}");
            Console.WriteLine($"Character value:{Convert.ToChar(Convert.ToInt32(number))}");
        }
    }
    

    internal class question8
    {
        public void Q8()
        {
            Console.Write("Enter the number adult tickets :");
            int adult = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Enter the number child tickets :");
            int child = Convert.ToInt32(Console.ReadLine());
            int total = child + adult;
            Console.WriteLine($"total number of tickets :{total}");
            double amount = adult * 3.75 + child * 2.25;
            Console.WriteLine($"total amount of tickets :{amount:C2}");

        }
    }
    






}   
