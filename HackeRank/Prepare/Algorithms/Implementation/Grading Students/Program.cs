// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;

    /*
     * Complete the 'gradingStudents' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY grades as parameter.
     */

        // User input for the number of students (n)
        Console.Write("Enter the number of students (n): ");
        int gradesCount = Convert.ToInt32(Console.ReadLine()?.Trim());

        List<int> grades = new List<int>();

        // User input for each student's grade
        for (int i = 0; i < gradesCount; i++)
        {
            Console.Write("Enter the grade for student " + (i + 1) + ": ");
            int gradesItem = Convert.ToInt32(Console.ReadLine()?.Trim());
            grades.Add(gradesItem);
        }

        // Calculate the rounded grades using the gradingStudents function
        List<int> result = gradingStudents(grades);

        // Print the final rounded grades
        Console.WriteLine("Final rounded grades:");
        foreach (int roundedGrade in result)
        {
            Console.WriteLine(roundedGrade);
        }

    static List<int> gradingStudents(List<int> grades)
    {
        List<int> roundedGrades = new List<int>();

        foreach (int grade in grades)
        {
            int roundedGrade = RoundGrade(grade);
            roundedGrades.Add(roundedGrade);
        }

        return roundedGrades;
    }

    static int RoundGrade(int grade)
    {
        if (grade < 38)
            return grade;

        int nextMultipleOf5 = ((grade / 5) + 1) * 5;
        if (nextMultipleOf5 - grade < 3)
            return nextMultipleOf5;
        else
            return grade;
    }