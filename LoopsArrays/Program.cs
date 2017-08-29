using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsArrays
{
    class Program
    {
        static void Main(string[] args)
        {

            //Arrays
            //an array's elements are numbered starting at 0. The numbers are called indices.
            //Arrays are like a dresser
            //access arrays using indexes
            //The total number of elemnts in a given array is the length

            //How to declare an array
            //DataType[] nameOFArray = {elements};
            //int[] myArray = { 1, 2, 3, 4, 5, 6 };
            //string[] students = { "Brad", "Amy", "Jackie", "Ric", "Mike" };
            //Console.WriteLine(students[4]);
            //Console.WriteLine(students[0]);


            //create an array of 10 vacation spots.  print the last and the first
            string[] vacation = { "London", "Paris", "Rome", "Costa Rica", "Tokyo", "New York City", "Las Vegas", "Portland", "Toronto", "Belize" };
            Console.WriteLine(vacation[0]);
            Console.WriteLine(vacation[vacation.Length-1]);

            //create an array with the ages of three children.  print out each child's age.
            int[] ages = { 7, 4, 2 };
            Console.WriteLine(ages[0]);
            Console.WriteLine(ages[1]);
            Console.WriteLine(ages[2]);

            //GPA on a 4.0 scale of 8 students.
            //When you DON'T KNOW the elements of your array upfront 
            //data type[] name OfArray = new dataType[#OfElements];
            float[] grades = new float[8];
            grades[0] = 4.0f;
            grades[1] = 3.5f;

            

            //first letter of your peer's names who are sitting near you
            char[] firstLetters = { 'A', 'S', 'D', 'R'};
            Console.WriteLine(firstLetters);

            //Delcare and initialize an array for the days of the week
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            Console.WriteLine(days.Length);
            Console.WriteLine(days[0]);
            days.SetValue("Funday", 0);
            Console.WriteLine(days[0]);

            //Declare and initialize an array of students ages using the "new keyword"
            int[] studentAges = new int[5];
            studentAges[0] = 20;
            studentAges[1] = 25;
            studentAges[2] = 30;
            studentAges[3] = 35;
            studentAges[4] = 40;

            string[] birthMonths = { "December", "July", "May", "July" };
            Console.WriteLine(Array.IndexOf(birthMonths,"July"));
            Console.WriteLine(Array.LastIndexOf(birthMonths,"July"));

            int[] numbers = { 2, 3, 5, 8, 10, -2, 4, 897, 0 };
            Console.WriteLine(numbers[0]);
            Array.Reverse(numbers);
            Console.WriteLine(numbers[0]);
            Array.Sort(numbers);
            Console.WriteLine(numbers[numbers.Length-1]);



            //Declare and initialize a string array of first names. Choose a name to find and print the IndexOf.
            string[] firstNames = { "John", "Aaron", "Carrie", "Megan", "Amy", "Rachel" };
            Console.WriteLine(Array.IndexOf(firstNames,"Amy"));

            //OR

            string[] fNames = new string[5];
            fNames[0] = "John";
            fNames[1] = "Aaron";
            fNames[2] = "Carrie";
            fNames[3] = "Megan";
            Array.IndexOf(fNames, "Aaron");
            Console.WriteLine(Array.IndexOf(fNames, "Aaron"));


            //Create an array of lucky numbers. Each number should repeat at least once. 
            //Choose a lucky number, find and print the last index of it.
            int[] luckyNumbers = { 3, 14, 15, 19, 26, 1, 17, 14, 15, 26, 1, 17, 3, 14, 15, 19, 26, 1, 17 };
            Console.WriteLine(Array.LastIndexOf(luckyNumbers, 26));

            //Create an array of alphabet characters. Print the first index of the array. 
            //Now reverse the array and print the first index.
            char[] alphabet = { 'A', 'E', 'T', 'J', 'T', 'D', 'S', 'J', 'A', 'C', 'M', 'M', 'K', 'R', 'S'};
            Console.WriteLine(alphabet[0]);
            Array.Reverse(alphabet);
            Console.WriteLine(alphabet[0]);


            //Create an array of student names in random order. 
            //Order the students’ names using the sort method. Print the first and last students’ names.
            string[] sNames = { "John Thompson", "Stacy Daniels", "Dana Johnson", "Sonja Smith", "Brad Reed", "adam" };
            Console.WriteLine(sNames[0]);
            Array.Sort(sNames);
            Console.WriteLine(sNames[0]);

            //Ask 10 people for their favorite numbers and create an array of those numbers. 
            //Order the numbers using the sort method. Print the first and last numbers.
            int[] favoriteNumbers = { 15, 7, 22, 5, 43, 45, 23, 3, 42, 17 };
            Array.Sort(favoriteNumbers);
            Console.WriteLine(favoriteNumbers[0] + " " + favoriteNumbers[favoriteNumbers.Length-1]);

        }
    }
}
