using System;
using System.ComponentModel.Design;


namespace LabExcise
{
    internal class Program
    {
        static void Main(string[] args)
        {


            
            while (true)
            {
                Console.WriteLine("\n\nSelect the question number(1-8)");

                int methodNumber = Convert.ToInt32(Console.ReadLine());

                switch (methodNumber)
                {

                    case 1:
                        question1 q1 = new question1();
                        q1.Q1();
                        break;


                    case 2:
                        question2 q2 = new question2();
                        q2.Q2();
                        break;

                    case 3:
                        question3 q3 = new question3();
                        q3.Q3();
                        break;

                    case 4:
                        question4 q4 = new question4();
                        q4.Q4();
                        break;

                    case 5:
                        question5 q5 = new question5();
                        q5.Q5();
                        break;

                    case 6:
                        question6 q6 = new question6();
                        q6.Q6();
                        break;

                    case 7:
                        question7 q7 = new question7();
                        q7.Q7();
                        break;

                    case 8:
                        question8 q8 = new question8();
                        q8.Q8();
                        break;






                }
           









            }






        }
    }
}
