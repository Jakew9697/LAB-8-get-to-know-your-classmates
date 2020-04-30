using System;
using System.Collections.Generic;

namespace LAB_8_Get_to_Know_Your_Assessments
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> studentDirectory = new List<string>();

            studentDirectory.Add("Jake");
            studentDirectory.Add("Sierra");
            studentDirectory.Add("Chris");
            studentDirectory.Add("Michael");
            studentDirectory.Add("Tommy");


            List<string> birthTown = new List<string>();

            birthTown.Add("Born in Boston");
            birthTown.Add("Born in Philly");
            birthTown.Add("Born in Detroit");
            birthTown.Add("Born in Lansing");
            birthTown.Add("Born in Denver............... Maybe.");


            List<string> favoriteFood = new List<string>();

            favoriteFood.Add("Hibachi! ");
            favoriteFood.Add("Baked Mac n Cheese! ");
            favoriteFood.Add("Burgers! ");
            favoriteFood.Add("Homemade Mac n Cheese. ");
            favoriteFood.Add("Pizza............ Maybe. ");

            bool cont = true;

            while (cont)
            {
                Console.WriteLine("GET TO KNOW YOUR CLASSMATES! ");

                Console.WriteLine();

                Console.WriteLine("Who would you like to find more information on? Jake (1), Sierra (2), Chris (3), Michael (4), or Tommy? (5) ");

                string input = Console.ReadLine().ToLower();

                try
                {
                    int studentID = int.Parse(input);

                    Console.WriteLine(studentDirectory[studentID - 1]);
                }

                catch (FormatException)
                {
                    for (int i = 0; i < studentDirectory.Count; i++)
                    {

                        if (studentDirectory[i].ToLower() == input)
                        {
                            Console.WriteLine(); //0$"{birthTown[i]} {studentDirectory[i]}");
                        }

                    }
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Invalid student ID number... try again. ");
                    Console.WriteLine();
                    continue;
                }

                for (int i = 0; i < studentDirectory.Count; i++)
                {
                    
                    if (studentDirectory[i].ToLower() == input)
                    {
                        Console.WriteLine($"Name: {studentDirectory[i]} Hometown: {birthTown[i]} Favorite Food: {favoriteFood[i]}");
                    }                   
                }

                Console.WriteLine("Would you like to discover more information on another person? y/n ");
                string input2 = Console.ReadLine().ToLower();

                if (input2 == "y")
                {
                    cont = true;
                }
                else
                {
                    cont = false;
                }
            }
        }
    }
}
//Task: Write a program that will recognize invalid user inputs when the user requests
//information about students in a class.
//What will the application do?

//● 2 Point: The application provides information about students in a class. X

//● 1 Point: The application prompts the user to ask about a particular student. X

//● 1 Point: The application gives proper responses according to user-submitted
//information. X

//● 1 Point: The application asks if the user would like to learn about another student.
//Build Specifications: X

//● 1 Point: Account for invalid user input with exceptions... use a try catch X

//● 1 Point: Try to incorporate IndexOutOfRangeException and FormatException.... entered a number but that student doesnt exist X


//Additional Requirements:

//● 1 Point: For answering Lab Summary when submitting to the LMS. X

//● -2 Points: if there are any syntax errors or if the program does not run (for example,
//in a Main method). X


//Extended Exercises:

//● 1 Point: Include more than two pieces of information about the student. X

//● 1 Point: Allow the user to search for a student by name as well as number. X
