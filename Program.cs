using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsWeekendHomeWork072316
{
    class Program
    {
        static void Main(string[] args)
        {
            ////PROBLEM 1
            //Console.WriteLine("Type in a phrase");
            //string y = Console.ReadLine();
            //ReverseString(y);





            ////PROBLEM 2
            //Console.WriteLine("type out your first name:");
            //string a = Console.ReadLine();

            //Console.WriteLine("type out your birth month:");
            //string b = Console.ReadLine();
            //string c = b.ToUpper();

            //NameBirthday(a, c);








            ////PROBLEM 3
            //Console.WriteLine("Type out your first name?");
            //string c = Console.ReadLine();

            //Spacing purposes to look cleaner while running
            //Console.WriteLine();

            //Console.WriteLine("Type out your last name?");
            //string d = Console.ReadLine();

            ////Spacing purposes to look cleaner while running
            //Console.WriteLine();

            //name(c, d);






            ////PROBLEM 4
            //Console.WriteLine("Type in a phrase with a 0 in it");
            //string x = Console.ReadLine();
            //ridOfZero(x);














            Console.ReadKey();
        }























        ////PROBLEM 1
        //static void ReverseString(string x)
        //{
        //    string[] items = x.Split(' ');
        //    Array.Reverse(items);
        //    foreach (string s in items)
        //    {
        //        Console.Write(s + " ");
        //    }
        //}




        ////PROBLEM 2
        //static void NameBirthday(string x, string y)
        //{
        //    if (y == "JANUARY")
        //    {
        //        Console.WriteLine(x + " is a January baby");
        //    }
        //    if (y == "FEBRUARY")
        //    {
        //        Console.WriteLine(x + " is a February baby");
        //    }
        //    if (y == "MARCH")
        //    {
        //        Console.WriteLine(x + " is a March baby");
        //    }
        //    if (y == "MAY")
        //    {
        //        Console.WriteLine(x + " is a May baby");
        //    }
        //    if (y == "JUNE")
        //    {
        //        Console.WriteLine(x + " is a June baby");
        //    }
        //    if (y == "JULY")
        //    {
        //        Console.WriteLine(x + " is a July baby");
        //    }
        //    if (y == "SEPTEMBER")
        //    {
        //        Console.WriteLine(x + " is a September baby");
        //    }
        //    if (y == "NOVEMBER")
        //    {
        //        Console.WriteLine(x + " is a November baby");
        //    }
        //    if (y == "DECEMBER")
        //    {
        //        Console.WriteLine(x + " is a December baby");
        //    }
        //    if (y == "APRIL")
        //    {
        //        Console.WriteLine(x + " is an April baby");
        //    }
        //    if (y == "AUGUST")
        //    {
        //        Console.WriteLine(x + " is an August baby");
        //    }
        //    if (y == "OCTOBER")
        //    {
        //        Console.WriteLine(x + " is an October baby");
        //    }
        //    else
        //    {
        //        Console.WriteLine("N/A");
        //    }
        //}




        ////PROBLEM 3
        //static void name(string firstName, string lastName)
        //{
        //    string firstNameCasing = firstName.Substring(0, 1);
        //    string a = firstNameCasing.ToUpper();
        //    string restOfFirstName = firstName.Substring(1, firstName.Length - 1);
        //    string entireFirstName = a + restOfFirstName;


        //    string lastNameCasing = lastName.Substring(0, 1);
        //    string b = lastNameCasing.ToUpper();
        //    string restOfLastname = lastName.Substring(1, lastName.Length - 1);
        //    string entireLastName = b + restOfLastname;


        //    Console.Write(entireFirstName + " " + entireLastName);
        //}





        ////PROBLEM 4
        //static void ridOfZero(string a)
        //{
        //    int indexZero = a.IndexOf('0');
        //    if (indexZero != -1)
        //    {
        //        string Remove = a.Remove(indexZero, 1);
        //        Console.WriteLine(Remove);
        //    }
        //    if (indexZero == -1)
        //    {
        //        Console.WriteLine("This string is okay!");
        //    }
        //}














    }
}
