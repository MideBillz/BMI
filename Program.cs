using System;
using System.Collections;
using System.Collections.Generic;

namespace BMI_PROJECT
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int value;
            double bmi1=0.00, bmi2=0.00, weight=0.00, height=0.00, weight2=0.00, height2=0.00;
            Writetitle();
            Console.WriteLine("Enter 1 for Metric(Kg & m) or 2 for Standard(Pound & ft) ");
            value = Int32.Parse(Console.ReadLine());
           if (value== 1)
            {
                Calculation.Metric(weight,height,bmi1);
            }
           else if (value==2)
            {
                Calculation.Standard(weight2,height2,bmi2);
            }
           else
            {
                Console.WriteLine("Enter a valid input\n");
            }
        }
        
        static void Writetitle()
        {
            Console.WriteLine("--||--||--||--||--||--||--||--||--||--||--||--\n");
            Console.WriteLine(" BMI CALCULATOR PROJECT BY OLUMIDE AKINSOLA.\n");
            Console.WriteLine("--||--||--||--||--||--||--||--||--||--||--||--\n");
        }

        
        class Calculation
        {
            public static double Metric(double weight, double height,double bmi1)
            {
                
                Console.WriteLine("Enter your Weight in Kg.");
                weight = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter your Height in Meters");
                height = Convert.ToDouble(Console.ReadLine());

                bmi1 = weight / (Math.Pow(height,2)); //* height);
                if (bmi1>=0.00 && bmi1<=18.4)
                {
                    Console.WriteLine("You are Underweight... YOU NEED LOTS AND LOTS OF PIZZA (According to Gabriel!!)...but WITHOUT PINEAPPLE!!\n");
                }
                else if (bmi1 >= 18.5 && bmi1 <= 24.9)
                {
                    Console.WriteLine("You are Normal Weight.. You're Safe!!\n");
                }
                else if (bmi1 >= 25 && bmi1 <= 25.9)
                {
                    Console.WriteLine("You are Overweight... You need to get to the GYM..Like right now!!\n");
                }
                else if (bmi1 >= 30 )
                {
                    Console.WriteLine("OBESITY!!!!!  CRITICAL!!!... GET TO THE DOCTOR!!\n");
                }
                return bmi1;

            }

            public static double Standard (double weight2,double height2,double bmi2)
            {
                Console.WriteLine("Enter your Weight in Pounds");
                weight2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter your Height in Ft");
                height2 = Convert.ToDouble(Console.ReadLine());

                bmi2 = weight2 / (Math.Pow(height2, 2));
                if (bmi2 >= 0.00 && bmi2 <= 18.4)
                {
                    Console.WriteLine("You are Underweight... YOU NEED LOTS AND LOTS OF PIZZA (According to Gabriel!!)...but WITHOUT PINEAPPLE!!\n");
                }
                else if (bmi2 >= 18.5 && bmi2 <= 24.9)
                {
                    Console.WriteLine("You are Normal Weight.. You are safe!\n");
                }
                else if (bmi2 >= 25 && bmi2 <= 25.9)
                {
                    Console.WriteLine("You are Overweight... You need to get to the GYM..Like right now!!\n");
                }
                else if (bmi2 >= 30)
                {
                    Console.WriteLine("OBESITY!!!!!  CRITICAL!!!... GET TO THE DOCTOR!!\n");
                }
                return bmi2;

            }
           
            internal static void Metric()
            {
                throw new NotImplementedException();
            }

            internal static void Standard()
            {
                throw new NotImplementedException();
            }
        }
    }
}
