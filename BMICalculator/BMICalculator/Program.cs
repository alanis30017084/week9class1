using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("<<< BMI Calculator >>>\nPlease enter your weight in kg: ");
            double w = double.Parse(Console.ReadLine());
            Console.Write("Please enter your height in meters: ");
            double h = double.Parse(Console.ReadLine());

            double result = Bmi(h,w);
            Console.WriteLine($"Your BMI is {result}. {Catagorize(result)}");
            Console.ReadLine();
        }

        static double Bmi(double h, double w)
        {
            return Math.Round(w / (h * h), 1);
        }
        
        static string Catagorize(double result)
        {
            if (result < 18.5)
            {
                return "You are underweight.";
            }
            else if (result >= 18.5 && result < 25)
            {
                return "Your weight is normal.";
            }
            else if (result >= 25 && result < 30)
            {
                return "You are overweight";
            }
            else
            {
                return "You are obese";
            }            
        }
        
    }
}
