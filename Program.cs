using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Basics
{
    class Program
    {

        static int hoursWasted = 0;

        enum ProgrammerStereotypes
        {
            Nerd,
            CopyPasteGuy,
            LeetCoder,
            HackathonMonster,
            Pythoner,
            ChillPHPGuy,
            OneWhoThinksHeIsAProgrammer,
            Me,
            Stark,
            Rick,
            Musk
        }

        static ProgrammerStereotypes programmerStereotypes;
        static void Main(string[] args) {
            Console.WriteLine("Hello, World!");

            int year = 2008;
            float age = 15.1f;
            char firstLetter = 't';
            string firstName = "Taha";
            bool bestProgrammer = true;

            string statement = firstName + " is the best programmer!";
            Console.WriteLine(statement);

            Greet();

            int[] averageMonthlyBudgetsSpent = new int[12];
            int[] quarterAverageBudgetsSpent = new int[] { 4000, 3500, 7000 };

            List<int> weeklyBudgetsSpent = new List<int>() { 1200, 2000, 900, 1100 };
            weeklyBudgetsSpent.Add(1300);
            weeklyBudgetsSpent.Remove(1100);

            int taxRate = 8;
            List<float> taxesPaidPerWeeklyBudget = new List<float> ();

            foreach (int weeklyBudgetSpent in weeklyBudgetsSpent) {
                float taxPaid = (taxRate * weeklyBudgetSpent) / 100;
                taxesPaidPerWeeklyBudget.Add(taxPaid);
            }

            int lengthOfTaxesPaidPerWeeklyBudget = taxesPaidPerWeeklyBudget.Count;

            for (int iteration = 0; iteration < lengthOfTaxesPaidPerWeeklyBudget; iteration++)
            {
                int weekNumber = iteration + 1;
                string tax_statement = taxesPaidPerWeeklyBudget[iteration].ToString() + " USD was paid in week " + weekNumber.ToString() + ".";
                Console.WriteLine(tax_statement);
            }

            switch (firstName)
            {
                default:
                    Console.WriteLine("Whatever your personality is it suits you!");
                    break;
                case "Taha":
                    Console.WriteLine("You have a great personality!");
                    break;
                case "Nimra":
                    Console.WriteLine("You have a sickening personality!");
                    break;
            }

            AgeUserToDrive(firstName, age);

            int punchCount = 0;
            int combo = 4;
            do
            {
                Console.WriteLine("There Goes A Hit!");
                punchCount++;
                if (punchCount > 1)
                {
                    Console.WriteLine("That Has Been " + punchCount.ToString() + " Hits");
                }
            } while (punchCount < combo);

            // Particularly, This Practice Is Not Useless But Joyful

            /*
              * I Am The Taha Yaseen And I Apply Every Concept In A Fun Way To Retain It!
            */

            switch (programmerStereotypes)
            {
                default:
                    Console.WriteLine("You Are A Programmer So Welcome In The Family, Pal!");
                    break;
                case ProgrammerStereotypes.Pythoner:
                    Console.WriteLine("If Python Is Only What You Know, Explore Some Other Languages!");
                    break;
                case ProgrammerStereotypes.ChillPHPGuy:
                    Console.WriteLine("Really It Is Only Still In The Market Because It Is A Trivial Pain That Nobody Wants!");
                    break;
            }

            AI jarvis = new AI("Jarvis", "To assist The Taha Yaseen in his every day tasks!");
            jarvis.TellDetails();

            AddToHoursWasted();
            Console.WriteLine("Hours Wasted: " + hoursWasted.ToString());

            Console.ReadKey();
        }

        class AI
        {
            string name;
            string purpose;

            public AI(string name, string purpose)
            {
                this.name = name;
                this.purpose = purpose;
            }

            public void TellDetails ()
            {
                Console.WriteLine("I am " + name);
                Console.WriteLine("With the purpose: " + purpose);
            }
        }

        static void Greet()
        {
            Console.WriteLine("Hello, Dear!"); 
        }

        static bool IsOldEnoughToDrive(float age)
        {
            return age > 17;
        }

        static void AgeUserToDrive(string firstName, float age)
        {
            bool isOldEnoughToDrive = IsOldEnoughToDrive(age);
            if (isOldEnoughToDrive)
            {
                Console.WriteLine(firstName + " can drive!");
            }
            else
            {
                Console.WriteLine(firstName + " cannot drive!");
                while (age < 18)
                {
                    Console.WriteLine("Years Are Passing By!");
                    age++;
                }
                Console.WriteLine(firstName + " can drive!");
            }
        }

        static void AddToHoursWasted()
        {
            hoursWasted++;
        }
    }
}