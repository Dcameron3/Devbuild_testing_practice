using System;
using System.Collections.Generic;
using System.Linq;

namespace DevBuild_Lab_TDD
{
    public class StringToBuild
    {

        public static int Add(string numbers)
        {
            List<string> list = new List<string>();
            list = numbers.Split(',' , '\n').ToList();
            List<int> newNumbers = new List<int>();
            newNumbers = list.Select(int.Parse).ToList();
            int result = newNumbers.Sum();
            return result;

        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter nums");
            StringToBuild.Add(Console.ReadLine());

        }
    }
}

